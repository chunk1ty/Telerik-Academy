function Student(firstName, lastName, age, marks) {
    this._firstName = firstName;
    this._lastName = lastName;
    this._age = age;
    this._marks = marks;
}

Student.prototype.getFirstName = function () {
    return this._firstName;
}

Student.prototype.getLastName = function () {
    return this._lastName;
}

Student.prototype.getAge = function () {
    return this._age;
}

Student.prototype.getMarks = function () {
    return this._marks.slice(0);
}

Student.prototype.getFullName = function () {
    return this._firstName + " " + this._lastName;
}

Student.prototype.setAverageMark = function (averageMark) {
    return this.averageMark = averageMark;
}