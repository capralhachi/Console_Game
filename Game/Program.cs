using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
			int lets_fight()
			{
				Console.WriteLine("Press 1 to fight. Press 2 to exit.");
				int lets_fight = Convert.ToInt32(Console.ReadLine());
				return lets_fight;
			}
			int hp = 5;
			int coin = 10;
			int damage = 4;

			Random rand = new Random();

			Console.WriteLine("Welcome to game!");
			Console.WriteLine("What are you doing?");
			lets_fight();



			while (true)
			{
				if (lets_fight() == 1)
				{
					int[] mob = { 1, 2, 3 };
					int index = rand.Next(mob.Length);

					if (mob[index] == 1)
					{
						Console.WriteLine("Goblin!");
					}
					if (mob[index] == 2)
					{
						Console.WriteLine("Ogr!");
					}
					if (mob[index] == 3)
					{
						Console.WriteLine("Dragon!");
					}
					if (lets_fight() == 2)
					{
						break;
					}

				}
			}
		}
	}
}