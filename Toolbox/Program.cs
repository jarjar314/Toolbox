using System;
using System.Collections.Generic;

namespace Toolbox
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TestNext ();
			Console.ReadLine ();
		}

		public static void TestNext ()
		{
			string input = "abdcba";
			Console.WriteLine("next {0} => {1}", input, StringToolbox.next(input));
		}

		public static void TestNumber ()
		{
			List<Tuple<int,int, int>> couples = new  List<Tuple<int, int, int>> ();
			couples.Add (new Tuple<int,int,int> (5, 2, 1));
			couples.Add (new Tuple<int,int,int> (2, 5, 1));
			couples.Add (new Tuple<int,int,int> (5, 5, 5));
			couples.Add (new Tuple<int,int,int> (15, 15, 15));
			couples.Add (new Tuple<int,int,int> (56, 2, 2));
			couples.Add (new Tuple<int,int,int> (5, 26, 1));
			couples.Add (new Tuple<int,int,int> (6, 26, 2));
			couples.Add (new Tuple<int,int,int> (6, 36, 6));
			couples.Add (new Tuple<int,int,int> (6, 24, 6));
			couples.Add (new Tuple<int,int,int> (270, 120, 30));
			foreach (var couple in couples) {
				Console.WriteLine ("pgcd of {0} and {1} is {2}, computed : {3}", couple.Item1, couple.Item2, couple.Item3, NumberToolbox.pgcd (couple.Item1, couple.Item2));
			}
		}

		public static void TestString ()
		{
			List<string> strings = new List<string> {
				"a",
				"ab",
				"ba",
				"abc",
				"aaabc",
				"azerty",
				"azerty1234",
				"AZErtyazeRTY",
				"abccba",
				"ABCabcABC",
				"cabbage"
			};
			foreach (var s in strings) {
				Console.WriteLine ("{0} sorted is {1}", s, StringToolbox.sort (s));
				Console.WriteLine ("{0} reversed is {1}", s, StringToolbox.reverse (s));
			}

		}
	}
}
