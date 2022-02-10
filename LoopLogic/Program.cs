//Program to simulate a role playing game

using System;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int MonsterHealth = 10;
			int HeroHealth = 10; 

			Random dice = new Random();

			// Hero attacks first. Battle continues until either health is 0 or below
			do 
			{
				// Hero Attacks
				int damage = dice.Next(1, 11);
				MonsterHealth -= damage;
				Console.WriteLine($"Monster was damaged and lost {damage} health and now has {MonsterHealth} health.");

				// Monster Attacks
				if (MonsterHealth > 0)
				{
					damage = dice.Next(1, 11);
					HeroHealth -= damage;
					Console.WriteLine($"Hero was damaged and lost {damage} health and now has {HeroHealth} health.");
				} 

			} while (MonsterHealth > 0 && HeroHealth > 0);

			// Display the winner
			if (HeroHealth > MonsterHealth)
				Console.WriteLine("Hero wins!");
			else
				Console.WriteLine("Monster wins.");		
		}
	}
}


