using System;

namespace Presentation.Slides.U99_Presentation
{
	public class Code
	{
		#region CSharpStyleRegion
		public int C;

		private int E { get; set; }
		#endregion CSharpStyleRegion

		//region CommentRegion

		public int D;

		// info
		public void A()
		{
			Console.WriteLine("another A");
		}

		//endregion CommentRegion


		// just comment

		public void A(int a)
		{
		}

		public void A(string s)
		{
			var a = 0;
			for (var i = 0; i < 100; ++i)
			{
				a += i;
			}
		}

		private static void B()
		{
			// TODO
		}
	}

	public enum Enum
	{
		A,
		B,
		C
	}
}