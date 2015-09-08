var requestModule = (function () {

    function getJSON(url, data) {
        var deffered = Q.defer();

       // headers = headers || {};

        $.ajax({
            url: url,
            type: 'GET',
           // headers: headers,
            contentType: 'application/json',
            success: function (data) {
                //var student, $studentsList, i, len;
                //$studentsList = $('<ul/>').addClass('students-list');
                //for (i = 0, len = data.students.length; i < len; i++) {
                //    student = data.students[i];
                //    $('<li />')
                //      .addClass('student-item')
                //      .append($('<strong /> ')
                //        .html(student.count))
                //      .append($('<span />')
                //        .html(student.students))
                //      .appendTo($studentsList);
                deffered.resolve(data);
                //}
               
                //$('#result').html($studentsList);
            },
            error: function (err) {
                deffered.reject(err);
            }
        });

        return deffered.promise;
    }

    function postJSON(url, data, headers) {
        var deffered = Q.defer();

        headers = headers || {};

        $.ajax({
            url: url,
            type: 'POST',
            headers: headers,
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (data) {
                deffered.resolve(data);
                console.log(deffered.resolve(data));
            },
            error: function (err) {
                deffered.reject(err);
            }
        });
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON
    }
}());