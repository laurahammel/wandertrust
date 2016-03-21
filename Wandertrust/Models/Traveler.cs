using System;

namespace Wandertrust
{
	public class Traveler
	{
		public string Name { get; set; }
		public string Level { get; set; }
		public string[] Interests { get; set; }

		public Traveler (string name, string level, string[] interests)
		{
			Name = name;
			Level = level;
			Interests = interests;
		}
	}
}

