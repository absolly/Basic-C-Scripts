using System;

public class Assignment1
{
		
	static void Main (string[] args)
	{
		//instantiate variables
		bool i = true;
		string Name;
		int Age = 0;
		int WisdomAge;
		float Lenght = 0f;
		float Growth = 0f;

		//Color console background and text
		Console.BackgroundColor = ConsoleColor.Black;
		Console.ForegroundColor = ConsoleColor.Green;

		//Ask for the name
		Console.WriteLine ("Hello adventurer!\nMay i ask you, what is your name?\nMy name is:");
		Name = Console.ReadLine ();

		//Ask for age
		Console.WriteLine ("Hello " + Name + "! You look like a wise adventurer. if i may be so rude, what is the age?");

		//Age input with falback if the input isn't an int
		while (i == true) {
			try {
				Age = int.Parse (Console.ReadLine ());
				WisdomAge = Age - 18;

				if (Age == 19) {
					Console.WriteLine ("Aah so you are " + Age + " years of age and thus have " + WisdomAge + " year of wisdom!");
				} else {
					Console.WriteLine ("Aah so you are " + Age + " years of age and thus have " + WisdomAge + " years of wisdom!\n");
				}
				i = false;
			} catch {
				Console.WriteLine ("Sorry, i didn't quite catch that.");
			}
			//Ask for length
			Console.WriteLine ("Now! This is important, what is your lenght in meters? I need to know for reasons.\nJust to clarify, its not for me a friend needs to know, just tell me.");
			i = true;
			while (i == true) {
				try {
					Lenght = float.Parse (Console.ReadLine ());
					if (Lenght == 1.88) {
						Console.WriteLine ("\n" + Lenght + " meters? Woah that exactly the same as me!");

						i = false;

					} else {
						Console.WriteLine (Lenght + " Huh? well i guess we can use that, cya!");
						i = false;
					}
			
				} catch {
					Console.WriteLine ("\nSorry i didn't quite catch that. Please, consentrate. what is your lenght in meters?");
					Console.WriteLine ("You know what, i'll tell you mine, i am 1.88 meters tall, now what are you?");

				}
				Growth = (Lenght / Age) * 39.370f;
				Console.WriteLine ("that means your have grown "+ Growth +" inches per year.");
				Console.WriteLine ("*the strange man dissapears*");
			}
		}
	}
}
