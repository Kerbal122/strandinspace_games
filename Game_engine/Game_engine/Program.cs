using System;

namespace Game_engine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Made by Strand In Space Games");
			intro ();
			Console.WriteLine ("Engine by Halo and Zac");
			intro ();
			Console.WriteLine ("Story by Zac and Halo");
			intro ();
			Console.WriteLine ("Works best on anything with anything with a cpu and a screen, with a working keyboard, oh and needs c# and windows...");
			intro ();
			Console.WriteLine ("Check GitHub /haloguysm1th/strandinspace_games for the code");
			intro ();
			Console.ReadKey ();
		}
		public static void intro (){
			double i = 0;
			int b = 0;
			while(i <100000000){
				while (b < 30) {
					Console.WriteLine ();
					b++;
				}
				i = Convert.ToDouble (i + .1);
			}
		}
	}
}
