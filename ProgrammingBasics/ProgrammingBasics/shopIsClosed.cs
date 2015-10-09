using System;

namespace ProgrammingBasics
{
	public class shopIsClosed
	{
		static void Main (string[] args)
		{
			bool shopIsClosed = false;
			bool hasManaPotions = true;
			bool hasHealthPotions = false;
			int gold = 20;
			int manaPotionPrize = 1;
			int healthPotionPrize = 2;
			bool enter;

			if (!shopIsClosed && (hasManaPotions && gold >= manaPotionPrize || hasHealthPotions && gold >= healthPotionPrize)) {
				enter = true;
			}
		}
	}
}

