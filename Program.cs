﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
	class Program
	{
		static void Main(string[] args)
		{
			EraMaja majake = new EraMaja();
			Console.WriteLine("Pindala:");
			majake.Pindala = int.Parse(Console.ReadLine());
			majake.NaitaInf();
			Inimene mees = new Inimene("Juku");
			majake.uks = new Uks("must");
			mees.hoone = majake;
			mees.NaitaInfo();
			Console.ReadLine();
		}
	}
}
