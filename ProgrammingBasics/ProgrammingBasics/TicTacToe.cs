using System;

class Sample
{
	static int[,] gameBoard;
	static int player;
	static int _size = 3;
	static string[] cells;
	static int j;
	static string[] colom;
	static bool won;

	static void Main (string[] args)
	{
		Console.WriteLine ("What is the preferred game size? (example: \"9\" for 9x9)");
		_size = int.Parse(Console.ReadLine ());	
		if (_size < 3) {
			_size = 3;
		}

		//define the gameBoard using a 2d array:
		//0 is free spot, 1 is taken by player 1 (eg crosses), 2 is taken by player 2 (naughts)
		//first element is an array of 3 elements (first element indicating column, second row , eg x,y)
		gameBoard = new int[_size, _size];

		//keep track of amount of moves, current player and whether a player has won
		int moves = 0;
		player = 1;
		int playerWon = 0;

		while (moves < (_size * _size)) {
			PrintBoard (gameBoard);

			//has a player won? if so exit
			if (playerWon > 0)
				break;

			Console.WriteLine ("Player {0}, it's your turn!", player);

			//we need access to column and row outside of the loop
			int column = 0;
			int row = 0;

			//allow user to specify a move, continue until the move is valid
			while (true) {
				//DONE: Prevent loop from crashing on invalid input and out of bounds exceptions
				try {
					Console.WriteLine ("Pick a column !");
					column = int.Parse (Console.ReadLine ()) - 1;
					Console.WriteLine ("Pick a row !");
					row = int.Parse (Console.ReadLine ()) - 1;

					if (MakeMove (row, column) == true) {
						break;

					}

				} catch {
					Console.WriteLine ("Invalid input");
				}
			}

			//check whether player has won




			//update administration
			playerWon = won ? player : 0;		//playerWon is now either zero, or contains the winning player
			player = (player == 1) ? 2 : 1;		//set next player
			moves++;						//update move count
		}

		if (playerWon != 0) {
			Console.WriteLine ("Player {0} won!", playerWon);
		} else {
			Console.WriteLine ("It's a draw!");
		}
	}


	//DONE: move the board print code into PrintBoard
	static void PrintBoard (int[,] gameBoard)
	{
		colom = new string[(_size + 1)];
		int k = 1;
		while (k <= _size) {
			colom [k] = "\tc" + k;
			k++;

		}
		Console.WriteLine (string.Join ("", colom));

		int i = 0;
		while (i < _size) {
			j = 0;
			cells = new string[_size];
			while (j < _size) {
				

				cells [j] = "\t[" + gameBoard [j, i] + "]";
				j++;
			}
			Console.WriteLine ("r" + (i + 1) + string.Join ("", cells));
			i++;

		}
	}



	//DONE: move the make move code into MakeMove
	//DONE: provide correct parameters
	static bool MakeMove (int row, int column)
	{
		if (gameBoard [column, row] != 0) {
			Console.WriteLine (
				"Invalid move, this spot already belongs to Player {0} !", 
				gameBoard [column, row]
			);
			return false;
		} else {
			//DONE: store the player id (1 or 2) in the 2d gameBoard array at the correct column and row
			gameBoard [column, row] = player;
			CheckWin (column, row);
			return true;
		}

	}



	//TODO: move the check win code into CheckWin
	//TODO: provide correct parameters
	//TODO: provide correct return type
	static bool CheckWin (int column, int row)
	{
		int i;
//		check rows
		if (row == column) {
			i = 0;
			won = true;
			while (i < _size) {
				if (gameBoard [i, i] == player && won != false) {
					won = true;
				} else {
					won = false;
				}
				i++;
			}
			if (won == true) {
				return won;
			}

		} 

		if ((column + row) == (_size-1)) {
			i = 0;
			won = true;
			while (i < _size) {
				if (gameBoard [i, ((_size-1) - i)] == player && won != false) {
					won = true;
				} else {
					won = false;
				}
				i++;
			}
			if (won == true) {
				return won;
			}
			
		}
			i = 0;
			won = true;
			while (i < _size) {
				if (gameBoard [i, row] == player && won != false) {
					won = true;
				} else {
					won = false;
				}
				i++;
			}
			if (won == true) {
				return won;
			}

//		check coloms
			won = true;
			i = 0;
			while (i < _size) {
				if (gameBoard [column, i] == player && won != false) {
					won = true;
				} else {
					won = false;

				}
				i++;
			}
		
		return won;
	}




}