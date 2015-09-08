var animals = data.getAllAnimals();

var sortedByNumberOfLegs = _.sortBy(animals, function (animal) {
    return animal.getLegs();
})

var groupAnimalBySpecies = _.groupBy(sortedByNumberOfLegs, '_species');

console.log(groupAnimalBySpecies);