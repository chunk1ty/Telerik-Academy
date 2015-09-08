var students = data.getAllStudents();

var studentInAgeRange = _.filter(students, function (student) {
    if(student.getAge() > 18 && student.getAge() < 24)
    {
        return student;
    }
})

_.each(studentInAgeRange, function (student) {
    console.log(student.getFullName())
});