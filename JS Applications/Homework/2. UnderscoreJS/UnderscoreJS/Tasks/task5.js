var animals = data.getAllAnimals();

var totalLegs = 0;

 _.each(animals, function (animal) {
     totalLegs += animal.getLegs();
 })

 console.log(totalLegs);