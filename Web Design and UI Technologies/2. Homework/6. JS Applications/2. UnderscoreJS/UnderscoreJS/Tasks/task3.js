var students = data.getAllStudents();

var studentWithHighestMarks = _.max(students, function (student) {
    var averageMark = 0;
    _.each(student.getMarks(), function (mark) {
        averageMark += mark;
    });

    averageMark /= student.getMarks().length;

    student.setAverageMark(averageMark);
    return averageMark;
});

console.log(students);
console.log(studentWithHighestMarks);