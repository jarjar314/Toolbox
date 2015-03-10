using System;
using System.Collections.Generic;

namespace Toolbox
{
	public static class ListeToolbox
	{
		public static int Mean (List<int> liste)
		{
			int count=0;
			foreach (var l in liste)
				count += l;
			return count / liste.Count;
		}

		public static int Median (List<int> liste)
		{
			liste.Sort ();
			if (liste.Count % 2 == 1) 	// 0 .. n .. 2*n -> 2n+1 items
				return liste [liste.Count / 2];
			else 					// 0 .. n-1 n 2*n-1 -> 2n items
				return (liste [liste.Count / 2] + liste [liste.Count / 2 - 1]) / 2;
		}
	}
}
