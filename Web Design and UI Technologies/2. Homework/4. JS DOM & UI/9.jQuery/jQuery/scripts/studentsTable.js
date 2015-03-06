(function studentsTable() {

    var students = [
        { firstName: 'Andriyan', lastName: 'Krastev', grade: '4' },
        { firstName: 'Ivan', lastName: 'Ivanov', grade: '12' },
        { firstName: 'Ivaylo', lastName: 'Stoqnov', grade: '3' },
        { firstName: 'Petar', lastName: 'Petrov', grade: '1' }
    ];

    var $wrapper = $("#wrapper");

    //function createTable($ank) {
    var $table = $("<table />");
    $table.css({ 'border-collapse': 'collapse' });
    $table.attr('border', '2px solid black');
    var $thead = $("<thead />");
    var $headingRow = $("<tr />");
    $headingRow.append($("<th />").text('First Name'));
    $headingRow.append($("<th />").text('Last Name'));
    $headingRow.append($("<th />").text('Grade'));
        
    $thead.append($headingRow);
    $table.append($thead);

    var $tbody = $("<tbody />");

    for (var i = 0; i < students.length; i++) {
        var $currentRow = $("<tr />")
        
        var currentStud = students[i];
        
        for (var prop in currentStud) {
            var $currentCell = $("<td />").html(currentStud[prop]).appendTo($currentRow);
        }

        $currentRow.appendTo($tbody);
    }
    $tbody.appendTo($table);

    $wrapper.append($table);
    //}   
}());