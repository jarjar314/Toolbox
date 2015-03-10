using System;

namespace Toolbox
{
	public static class NumberToolbox
	{
		public static int pgcd(int a, int b)
		{
			int big, small, remain;
			if (a > b) {
				big = a;
				small = b;
			} else {
				big = b;
				small = a;
			}

			while (small >= 1) {
				remain = big % small;
				big = small;
				small = remain;
			}
			return big;
		}

		public static int ppcm(int a, int b)
		{
			// Not bullet proof if a and b are very big (otherwise, cast one in long and go through long methods :D)
			return a / pgcd (a, b) * b;
		}

		public static long pgcd(long a, long b)
		{
			long big, small, remain;
			if (a > b) {
				big = a;
				small = b;
			} else {
				big = b;
				small = a;
			}

			while (small >= 1) {
				remain = big % small;
				big = small;
				small = remain;
			}
			return big;
		}

		public static long ppcm(long a, long b)
		{
			return a / pgcd (a, b) * b;
		}

	}
}

