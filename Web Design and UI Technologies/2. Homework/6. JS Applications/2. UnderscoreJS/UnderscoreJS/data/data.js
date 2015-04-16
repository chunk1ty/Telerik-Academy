var data = (function () {
    function getMarks() {
        var mark, marks = [];
        for (var i = 0; i < 15; i += 1) {
            mark = Math.random() * 4 + 2;

            marks.push(mark);
        }

        return marks;
    }

    function getAllStudents() {
        var students = [];
        var people = [
            new Student('Andriyan', 'Krastev', 21, getMarks()),
            new Student('Ivaylo', 'Georgiev', 25, getMarks()),
            new Student('Petar', 'Stoyanov', 18, getMarks()),
            new Student('Nikifor', 'Vladov', 16, getMarks()),
            new Student('Stacimir', 'Stoqnov', 29, getMarks()),
            new Student('Andriyan', 'Krastev', 24, getMarks()),
            new Student('Kvaylo', 'Oeorgiev', 17, getMarks()),
            new Student('Letar', 'Gtoyanov', 22, getMarks()),
            new Student('Yikifor', 'Zladov', 23, getMarks()),
            new Student('Qtacimir', 'Krastev', 30, getMarks())
        ];

        for (var i = 0; i < people.length; i++) {
            students.push(people[i]);
        }

        return students;
    }

    var species = ['big-cats', 'primates', 'marine-animals', 'reptile', 'birds'];
    var possibleNumberOfLegs = [2, 4, 6, 8, 100];

    function getAllAnimals() {
        var animals = [],
            animal;
        for (var i = 0; i < 30; i += 1) {
            var animalSpecies = species[Math.floor(Math.random() * species.length)];
            var animalNumberOfLegs = possibleNumberOfLegs[Math.floor(Math.random() * possibleNumberOfLegs.length)];

            animal = new Animal(animalSpecies, animalNumberOfLegs);

            animals.push(animal);
        }

        return animals;
    }

    function getAllBooks() {
        var booksStorage = [];
        var books = [
            new Book('Andriyan', 'Ankk'),
            new Book('Pesho', 'Pep'),
            new Book('Andriyan', 'Ankk. The Paladin Master'),
            new Book('Shosho', 'Shushunkata'),
            new Book('Andriyan', 'Svishtov.'),
            new Book('Pesho', 'papapapa'),
            new Book('Ivaylo', 'rororororor'),
            new Book('Ico', 'Hazarta'),
            new Book('Andriyan', 'samsung'),
            new Book('Ivaylo', 'BABA'),
            new Book('KOKO', 'kakokoka'),
        ];

        for (var i = 0; i < books.length; i++) {
            booksStorage.push(books[i]);
        }

        return booksStorage;
    }

    return {
        getAllStudents: getAllStudents,
        getAllAnimals: getAllAnimals,
        getAllBooks: getAllBooks
    }
}());