﻿using System;

namespace crystal_weed
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//start of program, this is the loading screen, ment as a bit of test code.
			Console.WriteLine ("Made by Strand In Space Games");
			//this calls the function intro, check the comments on intro for more details.
			Console.WriteLine ("Engine by Halo and Zac");
			Console.WriteLine ("Story by Zac and Halo");
			Console.WriteLine ("Works best on anything with anything with a cpu and a screen, with a working keyboard...");
			Console.WriteLine ("Check GitHub /haloguysm1th/strandinspace_games for the code");
			intro ();
			mm ();
		}

		public static void mm(){
			//function main menu, delcairs int
			int mm = 0;
			Console.Clear();
			Console.WriteLine ("Do you want to play a game? yes  = 1 /no = 2 ");
			//reads the user input, then stores it, seeing as it should be a number in a  int.
			mm = Convert.ToInt32 (Console.Read());
			// if mm the int is = to 2 , then exit else start the game
			if (mm == 2) {
				System.Environment.Exit(0);
			} else{
				load();
			}

		}

		public static void load(){
			Console.Clear ();
		}

		public static void game(){
			Console.Clear();
			}


		public static void timeout (){
			int i = 0;
			while (i < 1000000) {
				Console.Clear ();
				Console.WriteLine (i);
				i++;
			}
		}


		public static void intro (){
			/* This is the function intro, it first will declair a double precise float, then a int,
			both are equal to 0. Then we have a while statement which says, while the double i is = to 0
			then, it will see if b less then 30, if it is, it write's nothing to the screen, after this, 
			we change I to a double again, this needs to be cleaned up a little. anyways, after we convert i
			we at .1 to it, thus creating a timer, so that it looks better, this is sill under construction
			and I will probably fix it so that it not only looks better, but works better as well. 
			*/
			double i = 0;
			int b = 0;
			while(i <100000000){
				while (b < 10) {
					Console.WriteLine ();
					b++;
				}
				i = i + .1;
			}
		}
	}
}
