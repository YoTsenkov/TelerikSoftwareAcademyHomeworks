(function () {
	'use strict';

	var div = $('<div/>'),
		numberToBeGuessed,
		generateRandomFourDigitNumber,
		generateRandomDigit,
		isInputNumberValid,
		countSheepAndRams,
		initNewGame,
		playerMoves,
		playerWon,
		saveToLocalStorage,
		updateScoreBoard;

	generateRandomDigit = function generateRandomDigit() {
		return Math.floor(Math.random() * 9);
	};

	generateRandomFourDigitNumber = function generateRandomFourDifferentDigitNumber() {
		var firstDigit,
			secondDigit,
			thirdDigit,
			fourthDigit,
			number;

		do {
			firstDigit = generateRandomDigit();
		} while (firstDigit === 0);

		do {
			secondDigit = generateRandomDigit();
		} while (secondDigit === firstDigit);

		do {
			thirdDigit = generateRandomDigit();
		} while (thirdDigit === firstDigit || thirdDigit === secondDigit);

		do {
			fourthDigit = generateRandomDigit();
		} while (fourthDigit === firstDigit || fourthDigit === secondDigit || fourthDigit === thirdDigit);

		number = parseInt(firstDigit.toString() + secondDigit.toString() + thirdDigit.toString() + fourthDigit.toString(), 10);

		return number;
	};

	isInputNumberValid = function isInputNumberValid(selector) {
		var inputNumber = $(selector).val();

		return inputNumber.length === 4 && $.isNumeric(inputNumber);
	};

	countSheepAndRams = function (firstNumber, secondNumber) {
		var sheepCounter = 0,
			ramCounter = 0,
			firstNumberAsString = firstNumber.toString(),
			secondNumberAsString = secondNumber.toString(),
			len = firstNumberAsString.length,
			i;

		for (i = 0; i < len; i += 1) {
			if (firstNumberAsString[i] === secondNumberAsString[i]) {
				ramCounter += 1;
			} else if (firstNumberAsString.indexOf(secondNumberAsString[i]) >= 0) {
				sheepCounter += 1;
			}
		}

		return {
			ramCount: ramCounter,
			sheepCount: sheepCounter
		}
	};

	initNewGame = function initNewGame() {
		numberToBeGuessed = generateRandomFourDigitNumber();
		updateScoreBoard();
		playerMoves = 0;
		$('#clear-button').trigger('click');
		$('#user-input').val('');
		$("#nickname-dialog").hide();
		$("#scores-dialog").hide();
	};

	saveToLocalStorage = function saveToScoreboard(nickname, score) {
		localStorage[nickname] = score;
	};

	playerWon = function playerWon() {
		var nickname;

		$("#nickname-dialog").show()
			.dialog({ buttons: [
				{ text: 'Leave my legacy', click: function () {
					$(this).dialog('close');
					nickname = $('#nickname').val();
					saveToLocalStorage(nickname, playerMoves);
					updateScoreBoard();
					initNewGame();
				}}
			]});
	};

	updateScoreBoard = function updateScoreBoard() {
		var propCounter = 0,
			sortable = [],
			len,
			i,
			key,
			value,
			cachedSelector;

		if (localStorage.length <= 10) {
			len = localStorage.length;
		} else {
			len = 10;
		}

		for (var log in localStorage) {
			sortable.push([log, localStorage[log]])
		}
		sortable.sort(function (first, second) {
			return first[1] - second[1]
		});

		for (i = 0; i < len; i += 1) {
			key = sortable[i][0];
			value = sortable[i][1];
			propCounter += 1;

			cachedSelector = '#score-table tbody tr:nth-child(' + propCounter + ')';
			$(cachedSelector + ' td:nth-child(1)').text(propCounter + '.');
			$(cachedSelector + ' td:nth-child(2)').text(key);
			$(cachedSelector + ' td:nth-child(3)').text(value);
		}
	};

	//STYLES
	$('input[type=button]').button();
	$('#scores-dialog').dialog().dialog('close');
	$('#show-number-dialog').dialog().dialog('close');
	$('#invalid-number-dialog').dialog({ buttons: [
		{ text: 'Coolax', click: function () {
			$(this).dialog('close');
		}}
	]}).dialog('close');

	//Initialize new game
	initNewGame();

	//EVENT HANDLERS
	$('#submit-button').on('click', function () {
		var userGuessNumber,
			sheep,
			rams,
			result;

		if (isInputNumberValid('#user-input')) {
			playerMoves += 1;
			userGuessNumber = parseInt($('#user-input').val(), 10);
			result = countSheepAndRams(numberToBeGuessed, userGuessNumber);
			sheep = result.sheepCount;
			rams = result.ramCount;

			if (rams === 4) {
				playerWon();
			}

			$('#state-container').append(div.clone()
				.text(userGuessNumber + ' -> ' + sheep + ' sheep ; ' + rams + ' rams'));
		} else {
			$('#invalid-number-dialog').dialog('open');
		}
	});

	$('#clear-storage').on('click', function () {
		localStorage.clear();
		$('td').text('');
		updateScoreBoard();
	});

	$('#show-scoreboard').on('click', function () {
		if ($("#scores-dialog").dialog('isOpen')) {
			$("#scores-dialog").dialog('close');
		} else {
			$("#scores-dialog").dialog('open')
		}
	});

	$('#clear-button').on('click', function () {
		$('#state-container').empty();
	});

	$('#show-button').on('click', function () {
		var cachedSelector = '#show-number-dialog';
		$('#show-number-dialog' + ' div').text(numberToBeGuessed);
		if ($(cachedSelector).dialog('isOpen')) {
			$(cachedSelector).dialog('close');
		} else {
			$(cachedSelector).dialog('open')
		}
	});

	$('#restart-button').on('click', function () {
		initNewGame();
	});
}());