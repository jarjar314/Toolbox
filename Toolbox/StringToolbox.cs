using System;

namespace Toolbox
{
	public static class StringToolbox
	{
		public static char[] reverse(char[] input)
		{
			char tmp;
			int l = input.Length;
			for (int i = 0; i < l / 2; i++) 
			{
				tmp = input [i];
				input [i] = input [l - 1 - i];
				input [l - 1 - i] = tmp;
			}
			return input;
		}

		public static string reverse (string input)
		{
			return string.Join("",reverse(input.ToCharArray()));
		}

		public static string sort(string input)
		{
			var arrays = input.ToCharArray ();
			Array.Sort (arrays);
			return string.Join ("", arrays);
		}

		/// <summary>
		/// next input 
		/// </summary>
		/// <param name="input">Input.</param>
		public static string next(string input)
		{
			string output = string.Empty;
			bool start = true;
			char tmp=' ';
			int n = input.Length;
			for (int i = n - 1; i >= 0; i++) {
				if (start) {
					start = false;
					tmp = input [i];
					continue;
				}
				char elem = input [i];
				if (elem >= tmp) {
					continue;
				}



			}
		}
	}
}

