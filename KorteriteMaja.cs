using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
	public class KoreteriteMaja : Hoone
	{
		public KoreteriteMaja(int uks) : base(uks)
		{

		}
		public  void NaitaInfo()
		{
			Console.WriteLine($"Olen {uks}!");
		}
	}
}
