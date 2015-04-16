var people = data.getAllStudents();

var groupByFirstName = _.groupBy(people, '_firstName');
var groupByLastName = _.groupBy(people, '_lastName');

console.log('Most common first name is -> ' + mostCommonName(groupByFirstName));
console.log('Most common last name is  -> ' + mostCommonName(groupByLastName));


function mostCommonName(collection) {
    var mostCommonFirstName = '';
    var mostCommon = 0

    _.each(collection, function (groupbyName, name) {
        if (mostCommon < groupbyName.length) {
            mostCommon = groupbyName.length;
            mostCommonFirstName = name;
        }
    })

    return mostCommonFirstName;
}
