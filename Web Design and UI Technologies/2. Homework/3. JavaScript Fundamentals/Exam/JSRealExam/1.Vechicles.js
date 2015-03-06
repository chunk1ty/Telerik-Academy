function solve(params) {
	//•	Cars with 4 wheels
	//•	Trucks with 10 wheels
	//•	Trikes with 3 wheels

	var s = parseInt(params);
	var count = [];
	var counter = 0;
	var vechicel = [10, 4, 3];

	printAllCombination(vechicel, count, 0, s);

	function printAllCombination(coins, counts, startIndex, totalAmount) {
		//firstly decide if we should proceed or not by track startIndex
		if (startIndex >= coins.length)//we have processed all coins
		{
			counter++;
			var result = '';
			//format the print out as "amount=?*25 + ?*10+..."
			for (var i = 0; i < coins.length; i++)
				result += " " + counts[i] + "*" + coins[i] + "+";
			//need a new line per case
			//console.log(result);
			return;
		}

		//other wise we need proceed
		//but notice if startIndex is the last one, we need check if it can be dividable by the smallest coin
		//if so, this is a good combination, otherwise, this is not possible combination thus discarded
		if (startIndex == coins.length - 1) {
			if (totalAmount % coins[startIndex] == 0)//good combination
			{
				//set the counts of coins at start index
				counts[startIndex] = totalAmount / coins[startIndex];
				//proceed to recursive call
				printAllCombination(coins, counts, startIndex + 1, 0);//notice startIndex+1 and remaining amount = 0
			}
		}
		else//we still have option to choose 0-N larger coins
		{
			for (var i = 0; i <= totalAmount / coins[startIndex]; i++) {
				//for every cycle in a loop, we choose an arbitrary number of larger coins and proceed next
				counts[startIndex] = i;
				printAllCombination(coins, counts, startIndex + 1, totalAmount - coins[startIndex] * i);
				//notice we need update the remaining amount
			}
		}
	}

	console.log(counter);
}

//console.log(count);


solve(200);