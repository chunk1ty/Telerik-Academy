function Solve(input) {
	
	var N = parseInt(input[0]);
	var numbers = [];

	for (var i = 1; i <= N; i++) {
		numbers[i - 1] = parseInt(input[i]);
	}

	var answer = -20000000;	
	var currentSum = 0;

	for (var i = 0; i < N; i++) {		
		currentSum += numbers[i];

		if (answer < currentSum) {
			answer = currentSum;
		}
		
		if (currentSum <= 0) {
			currentSum = 0;
		}
	}

	console.log(answer);
}

var test1 = [
	'8',
	'1',
	'6',
	'-9',
	'4',
	'4',
	'-2',
	'10',
	'-1'
]

var test2 = [
	'6',
	'1',
	'3',
	'-5',
	'8',
	'7',
	'-6',
	
]

var test3 = [
	'9',
	'-9',
	'-8',
	'-8',
	'-7',
	'-6',
	'-5',
	'-1',
	'-7',
	'-6',
]

var test4 = [
'	20',
'-1867694',
'1968105',
'1759381',
'1243976',
'-1038741',
'791044',
'1024747',
'250484',
'693515',
'-1364378',
'1015720',
'805332',
'1995499',
'1595482',
'-1661341',
'-1775591',
'-698357',
'-1285748',
'1826697',
'1544340'
]

Solve(test3)

