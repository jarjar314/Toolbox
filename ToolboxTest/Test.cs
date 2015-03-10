using NUnit.Framework;
using System;
using Toolbox;

namespace ToolboxTest
{
	[TestFixture ()]
	public class Test
	{
		[Test ("aabc","cbaa")]
		public void TestCase (string input, string output)
		{
			Assert.AreEquals (StringToolbox.reverse (input), output);
		}
	}
}

