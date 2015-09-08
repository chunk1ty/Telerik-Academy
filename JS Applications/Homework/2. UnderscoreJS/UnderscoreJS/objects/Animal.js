function Animal(species, legs) {
    this._species = species;
    this._legs = legs;
}

Animal.prototype.getSpecies = function () {
    return this._species;
}

Animal.prototype.getLegs = function () {
    return this._legs;
}