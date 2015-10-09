using System;

class Sample
{
	
	static void Main (string[] args)
	{
		//define the gameBoard using a 2d array:
		//0 is free spot, 1 is taken by player 1 (eg crosses), 2 is taken by player 2 (naughts)
		//first element is an array of 3 elements (first element indicating column, second row , eg x,y)
		int[,] gameBoard = new int[,] { 
			{ 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }
		};
		
		//keep track of amount of moves, current player and whether a player has won
		int moves = 0;
		int player = 1;
		int playerWon = 0;
		
		while (moves < 9) {
			//simple version only works for 3x3 gameboards without using a loop
			Console.WriteLine ("\tc1\tc2\tc3");
			Console.WriteLine ("r1\t[{0}]\t[{1}]\t[{2}]", gameBoard [0, 0], gameBoard [1, 0], gameBoard [2, 0]);
			//TODO: fix the second row (r2) of the board, it only prints zeros now
			Console.WriteLine ("r1\t[{0}]\t[{1}]\t[{2}]", 0, 0, 0);
			Console.WriteLine ("r3\t[{0}]\t[{1}]\t[{2}]", gameBoard [0, 2], gameBoard [1, 2], gameBoard [2, 2]);
			
			//has a player won? if so exit
			if (playerWon > 0)
				break;

			Console.WriteLine ("Player {0}, it's your turn!", player);

			//we need access to column and row outside of the loop
			int column = 0;
			int row = 0;
			
			//allow user to specify a move, continue until the move is valid
			while (true) {
				//TODO: Prevent loop from crashing on invalid input and out of bounds exceptions
				Console.WriteLine ("Pick a column !");
				column = int.Parse (Console.ReadLine ()) - 1;
				Console.WriteLine ("Pick a row !");
				row = int.Parse (Console.ReadLine ()) - 1;
				
				if (gameBoard [column, row] != 0) {
					Console.WriteLine (
						"Invalid move, this spot already belongs to Player {0} !", 
						gameBoard [column, row]
					);
				} else {
					//TODO: store the player id (1 or 2) in the 2d gameBoard array at the correct column and row
					break;
				}
			}
			
			//check whether player has won
			bool won = 
						//rows
				(gameBoard [0, 0] == player && gameBoard [1, 0] == player && gameBoard [2, 0] == player) ||
						//TODO: replace false with win check for second row
				false ||
				(gameBoard [0, 2] == player && gameBoard [1, 2] == player && gameBoard [2, 2] == player) ||
						
						//columns
				(gameBoard [0, 0] == player && gameBoard [0, 1] == player && gameBoard [0, 2] == player) ||
				(gameBoard [1, 0] == player && gameBoard [1, 1] == player && gameBoard [1, 2] == player) ||
						//TODO: replace false with win check for last column
				false ||
						//topleftbottomright diagonal
				(gameBoard [0, 0] == player && gameBoard [1, 1] == player && gameBoard [2, 2] == player) ||
						//bottomleft top right diagonal
						//TODO: replace false with win check for bottomleft topright diagonal
				false;
						

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

	/*
	//TODO: move the board print code into PrintBoard
	static void PrintBoard (int[,] gameBoard) {
		//...
	}
	*/
	
	/*
	//TODO: move the make move code into MakeMove
	//TODO: provide correct parameters
	static void MakeMove (..., ...) {
		//...
	}
	*/

	/*
	//TODO: move the check win code into CheckWin
	//TODO: provide correct parameters
	//TODO: provide correct return type
	static ... CheckWin (..., ...) {
		//...
	}
	*/

}