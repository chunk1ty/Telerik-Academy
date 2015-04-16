(function () {
    $('#get-students-button').on('click', function () {
        httpRequester.getRequest()
            .then(function (data) {
                visualizeStudents(data);
            }, function (err) {
                console.log(err);
            });
    });

    function visualizeStudents(data) {
        var containar = $('#students-get-result'),
            ul = $('<ul />'),
            currentStudent,
            i,
            len,
            liText;

        console.log(data.students);

        for (i = 0, len = data.students.length; i < len; i++) {
            currentStudent = data.students[i];

            liText = 'Id ' + currentStudent.id + ' Name ' + currentStudent.name + ' Grade ' + currentStudent.grade;

            ul.append($('<li />').html(liText));
        }

        containar.append(ul);
    }

    $('#add-student-button').on('click', function () {
        var name = $('#student-name').val();
        var grade = $('#student-grade').val();

        httpRequester.postRequest({
            name: name,
            grade: grade
        }).then(function (data) {
            var addStudent = $('#add-student-result');
            //addStudent.fadeIn(200);
            addStudent.html('Student ' + JSON.stringify(data) + ' added successfully.');
            //addStudent.fadeOut(2000);
        }, function (err) {
            var addStudent = $('#students-get-result');
            //addStudent.fadeIn(200);
            addStudent.html(err);
           // addStudent.fadeOut(2000);
        })

    });

    $('#delete-student-button').on('click', function () {
        var studentId = $('#student-id').val();

        httpRequester.deleteRequest(studentId)
            .then(function (data) {
                var deleteStudent = $('#delete-student-result');
                //deleteStudent.fadeIn(200);
                deleteStuden.html(JSON.stringify(data));
                //deleteStudent.fadeOut(2000);
            }, function (err) {
                var deleteStudent = $('#delete-student-result');
                //deleteStudent.fadeIn(200);
                deleteStuden.html(err);
                //deleteStudent.fadeOut(2000)
            });

    });

    function refreshStudents() {
        $.ajax({
            url: 'http://localhost:3000/students',
            type: 'GET',
            contentType: 'application/json',
            success: function (data) {
                container.html('');
                for (var i = 0; i < data.students.length; i++) {
                    container.append(
                        '<tr>' +
                            '<td>' + data.students[i].id + '</td>' +
                            '<td><strong>' + data.students[i].name + '</strong></td>' +
                            '<td>' + data.students[i].grade + '</td>' +
                            '<td><button>Delete</button></td>' +
                        '</tr>');
                }
            },
            error: function (err) {
                alert('You have to start the server first')
            }
        })
    }
}());