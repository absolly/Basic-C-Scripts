using System;
using System.IO;

public class Assignment2
{
	static void Main (string[] args)
	{


		int healthPotions = 0;
		int manaPotions = 0;
		Random random = new Random ();
		int stockHpPotions = random.Next (2, 20);
		int stockManaPotions = random.Next (2, 20);
		bool talking = true;
		float gold = 15.0f;
		int request;
		int playerRoll;
		int keeperRoll;

		Console.SetCursorPosition (0, 23);
		Console.Write ("Gold: " + gold + "\tHealth potions: " + healthPotions + "\tMana potions: " + manaPotions);
		Console.SetCursorPosition (0, 0);

		Console.WriteLine ("<Shop Keeper> Hello there!\n<Shop Keeper> How can i help you customer?\nPress enter to continue...");
		Console.ReadLine ();
		Console.Clear ();

		while (talking == true) {
			Console.SetCursorPosition (0, 23);
			Console.Write ("Gold: " + gold + "\tHealth potions: " + healthPotions + "\tMana potions: " + manaPotions);
			Console.SetCursorPosition (0, 0);

			Console.WriteLine ("<You> I would like to:\n1) Buy health potions.\n2) Buy mana potions.\n3) Gamble\n4) Leave");
			try {
				switch (int.Parse (Console.ReadLine ())) {
				case 1:
					Console.WriteLine ("<Shop Keeper> Aah yes, i have me some of those\n\nIn stock:\nHealth potions: " + stockHpPotions + "\tPrize: 2.5g\n\nhow many would you like?");
					while (talking == true) {
						try {
							request = int.Parse (Console.ReadLine ());
							Console.WriteLine ("<You> I would like to buy " + request + " potions please");
							if (request * 2.5f <= gold) {
								gold -= (request * 2.5f);
								healthPotions += request;
								stockHpPotions -= request;

								Console.Clear ();
								Console.SetCursorPosition (0, 23);
								Console.Write ("Gold: " + gold + "\tHealth potions: " + healthPotions + "\tMana potions: " + manaPotions);
								Console.SetCursorPosition (0, 0);
								Console.WriteLine ("<Shop Keeper> Here you go " + request + " potions\n<Shop Keeper> Anything else?");
								Console.WriteLine ("Press enter to continue....");
								Console.ReadLine ();
								Console.Clear ();


								talking = false;
							} else {
								Console.WriteLine ("<Shop Keeper> Sorry, you don't have enough gold for that.");
							}
						
						} catch {
							Console.WriteLine ("I didn't quite catch that.");
						}
					}
					talking = true;
					break;
				case 2:
					Console.WriteLine ("<Shop Keeper> Aah yes, i have me some of those\n\nIn stock:\nMana potions: " + stockManaPotions + "\tPrize: 1.5g\n\nhow many would you like?");
					while (talking == true) {
						try {
							request = int.Parse (Console.ReadLine ());
							Console.WriteLine ("<You> I would like to buy " + request + " potions please");
							if (request * 1.5f <= gold) {
								gold -= (request * 1.5f);
								stockManaPotions -= request;
								manaPotions += request;

								Console.Clear ();
								Console.SetCursorPosition (0, 23);
								Console.Write ("Gold: " + gold + "\tHealth potions: " + healthPotions + "\tMana potions: " + manaPotions);
								Console.SetCursorPosition (0, 0);
								Console.WriteLine ("<Shop Keeper> Here you go " + request + " potions\n<Shop Keeper> Anything else?");
								Console.WriteLine ("Press enter to continue....");
								Console.ReadLine ();
								Console.Clear ();
								talking = false;
							} else {
								Console.WriteLine ("<Shop Keeper> Sorry, you don't have enough gold for that.");
							}

						} catch {
							Console.WriteLine ("I didn't quite catch that.");
						}
					}
					talking = true;	
					break;
				case 3:
					Console.Clear();
					Console.SetCursorPosition (0, 23);
					Console.Write ("Gold: " + gold + "\tHealth potions: " + healthPotions + "\tMana potions: " + manaPotions);
					Console.SetCursorPosition (0, 0);
					Console.WriteLine ("<Shop Keeper> If you roll higher then me you get 1.1g, else i get 1g from you.\n<Shop Keeper> Are you sure you want to continue?(Yes/No)");
					string answer = Console.ReadLine ();
					answer = answer.ToLower ();
					if (answer == "yes") {
						playerRoll = random.Next (1, 6);
						keeperRoll = random.Next (1, 6);
						Console.WriteLine ("\nRoll a dice.\nPress enter to continue...");
						Console.ReadLine();
						Console.WriteLine ("<You>\n_______\n|-----|\n|--" + playerRoll + "--|\n|-----|\n¯¯¯¯¯¯¯" +
						"");
						Console.WriteLine ("<Shop Keeper>\n_______\n|-----|\n|--" + keeperRoll + "--|\n|-----|\n¯¯¯¯¯¯¯");
						if (playerRoll > keeperRoll) {
							Console.WriteLine ("<Shop Keeper> Aagh bugger, you won!\n<Shop Keeper> Here you go kid, 1.1g");
							gold += 1.1f;
						} else {
							Console.WriteLine ("<Shop Keeper> Ha hahaa, better luck next time kid!\n<Shop Keeper> That will be 1g.");
							gold -= 1.0f;
						}

					}else{
						Console.WriteLine("<Shop Keeper> Well i guess not everyone wants to live on the wild side.");
					}
					Console.WriteLine("Press enter to continue...");
					Console.ReadLine();
					Console.Clear();
					Console.SetCursorPosition (0, 23);
					Console.Write ("Gold: " + gold + "\tHealth potions: " + healthPotions + "\tMana potions: " + manaPotions);
					Console.SetCursorPosition (0, 0);

					break;
				case 4:
					Console.WriteLine ("bye!");
					talking = false;					
					break;
				}
			} catch {
				Console.WriteLine ("Please select a number 1-4.");
				Console.WriteLine ("Press enter to continue....");
				Console.ReadLine ();
				Console.Clear ();
			}

		}



	}
}


