namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using Moq;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
             //: this(new JustMockCarsRepository())
             : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        public void Index_ShouldReturnIViewInstance()
        {            
            var mock = new Mock<ICarsRepository>();
           
            var carController = new CarsController(mock.Object);

            Assert.IsInstanceOfType(carController.Index(), typeof(IView));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Details_ShouldThrowArgumentNullException_WhenCarIsNull()
        {
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.GetById(It.IsAny<int>())).Returns((Car)null);

            var carController = new CarsController(mock.Object);

            carController.Details(1);
        }

        [TestMethod]        
        public void Details_ShouldReturnCar_WhenCarExistsInDb()
        {
            var car = new Car();
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.GetById(It.IsAny<int>())).Returns(car);

            var carController = new CarsController(mock.Object);

            Assert.AreEqual(car, carController.Details(1).Model);
        }

        [TestMethod]
        public void Details_ShouldReturnIViewInstance()
        {
            var car = new Car();
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.GetById(It.IsAny<int>())).Returns(car);

            var carController = new CarsController(mock.Object);

            Assert.IsInstanceOfType(carController.Details(1), typeof(IView));
        }

        [TestMethod]
        public void Search_ShouldReturnIViewInstance()
        {
            var cars = new List<Car>();
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.Search(It.IsAny<string>())).Returns(cars);

            var carController = new CarsController(mock.Object);

            Assert.IsInstanceOfType(carController.Search("Ankk"), typeof(IView));
        }

        [TestMethod]
        public void Search_ShouldReturnCars()
        {
            var cars = new List<Car>()
            {
                new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 },
                new Car { Id = 3, Make = "BMW", Model = "330d", Year = 2007 },
                new Car { Id = 4, Make = "Opel", Model = "Astra", Year = 2010 },
            };

            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.Search(It.IsAny<string>())).Returns(cars);

            var carController = new CarsController(mock.Object);

            Assert.AreEqual(cars.Count, ((List<Car>)carController.Search("Ankk").Model).Count);
        }

        [TestMethod]
        public void Search_ShouldReturnCars_WithGetModel()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Search("ANkk"));

            Assert.AreEqual(2, model.Count);
        }

        [TestMethod]
        public void Sort_ShouldCallSortByMake()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);
        
            controller.Sort("make");

            mock.Verify(m => m.SortedByMake());
        }

        [TestMethod]
        public void Sort_ShouldReturnCarsSortByMake()
        {
            var cars = new List<Car>
            {
                new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 }
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.SortedByMake()).Returns(cars);
            var controller = new CarsController(mock.Object);

            Assert.AreEqual(cars, controller.Sort("make").Model);
        }

        [TestMethod]
        public void Sort_ShouldCallSortByYear()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);

            controller.Sort("year");

            mock.Verify(m => m.SortedByYear());
        }

        [TestMethod]
        public void Sort_ShouldReturnCarsSortByYear()
        {
            var cars = new List<Car>
            {
                new Car { Id = 1, Make = "Audi", Model = "A5", Year = 2005 },
                new Car { Id = 2, Make = "BMW", Model = "325i", Year = 2008 }
            };
            var mock = new Mock<ICarsRepository>();
            mock.Setup(m => m.SortedByYear()).Returns(cars);
            var controller = new CarsController(mock.Object);

            Assert.AreEqual(cars, controller.Sort("year").Model);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_ShouldThrowArgumentException_WhenParameterIsInvalid()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);

            controller.Sort("ankk");
        }

        [TestMethod]        
        public void Sort_ShouldReturnIViewInstance()
        {
            var mock = new Mock<ICarsRepository>();
            var controller = new CarsController(mock.Object);

            Assert.IsInstanceOfType(controller.Sort("year"), typeof(IView)); 
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
