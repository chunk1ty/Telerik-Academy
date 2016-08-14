namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
    using Common.Constants;
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Driver : Identifiable, IDriver
    {       
        private string name;
        private GenderType gender;
        private IMotorVehicle activeVehicle;
        private ICollection<IMotorVehicle> motorVechiles;

        public Driver(string name, GenderType gender) : base()
        {           
            this.name = name;
            this.gender = gender;

            this.motorVechiles = new List<IMotorVehicle>();
        }

        public IMotorVehicle ActiveVehicle
        {
            get
            {
                return this.activeVehicle;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public IEnumerable<IMotorVehicle> Vehicles
        {
            get
            {
                return this.motorVechiles;
            }
        }

        public void AddVehicle(IMotorVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentException();
            }

            if (this.Vehicles.Any(x => x.Id == vehicle.Id))
            {
                throw new ArgumentException(GlobalConstants.DriverCannotBeAssignedAsOwnerToVehicleMoreThanOnceExceptionMessage);
            }

            this.motorVechiles.Add(vehicle);
        }

        public bool RemoveVehicle(IMotorVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentException();
            }

            return this.motorVechiles.Remove(vehicle);
        }

        public void SetActiveVehicle(IMotorVehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(GlobalConstants.CannotSetNullObjectAsActiveVehicleExceptionMessage);
            }

            if (!this.Vehicles.Any(x => x.Id == vehicle.Id))
            {
                throw new InvalidOperationException(GlobalConstants.CannotSetForeignVehicleAsActiveExceptionMessage);
            }

            this.activeVehicle = vehicle;
        }
    }
}
