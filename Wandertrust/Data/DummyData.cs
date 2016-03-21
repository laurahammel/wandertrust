using System;
using System.Collections.Generic;

namespace Wandertrust
{
	public class DummyData
	{
		public static Traveler Emily = new Traveler("Emily", "WanderWizard", new string[]{"Coffee", "Food", "Shopping", "Books", "Architecture"});
		public static Traveler Carol = new Traveler("Carol", "Hometown Hero", new string[]{"Coffee", "Food", "Shopping", "Books", "Architecture"});
		public static Traveler John = new Traveler("John", "Travel Junkie", new string[]{"Coffee", "Food", "Shopping", "Books", "Architecture"});
		public static Traveler Timmy = new Traveler("Timmy", "Local Genius", new string[]{"Coffee", "Food"});
		public static Traveler Eric = new Traveler("Eric", "WanderWizard", new string[]{"Coffee"});
		public static Traveler Sam = new Traveler("Sam", "Travel Junkie", new string[]{"Coffee", "Food", "Shopping"});

		public static Traveler Sloane = new Traveler("Sloane", "Newbie", new string[]{"Coffee", "Food", "Shopping", "Books", "Architecture"});
	
		public static List<Traveler> Matches = new List<Traveler>{Emily, Carol, John, Timmy, Eric, Sam};
	}
}

