﻿using System;

namespace question_one
{
	class MainClass
	{
		// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
		// The sum of these multiples is 23.
		// Find the sum of all the multiples of 3 or 5 below 1000.
		public const int MAX = 1000;

		public static void Main(string[] args)
		{
			for (var i = 0; i < MAX; i++)
			{
				if ((i % 5 == 0)||(i % 3 == 0))
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
