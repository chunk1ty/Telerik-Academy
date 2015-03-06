define(function () {
    var people = [
        { id: 1, name: "Doncho Minkov", age: 26, avatarUrl: "images/doncho.jpg" },
        { id: 2, name: "Georgi Georgiev", age: 24, avatarUrl: "images/georgi-georgiev.jpg" },
        { id: 3, name: "Nikolay Kostov", age: 23, avatarUrl: "images/nikolay-kostov.jpg" },
        { id: 4, name: "Ivaylo Kenov", age: 25, avatarUrl: "images/ivaylo-kenov.jpg" }
    ];

    var getPeople = function () {
        return people;
    };

    return {
        getPeople: getPeople
    }
});