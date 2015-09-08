var students = data.getAllStudents();

var studentsWithFirstNameBeforeLastName = _.filter(students, function (student) {
    return student.getFirstName() < student.getLastName();
});

var sortedStudentsByName = _.sortBy(studentsWithFirstNameBeforeLastName, function (student) {
    return student.getFullName();
})

console.log(studentsWithFirstNameBeforeLastName);
console.log(sortedStudentsByName);