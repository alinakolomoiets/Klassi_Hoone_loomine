using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
	public class EraMaja: Hoone
	{
		string info;
		public EraMaja(int pindala = 50) : base(pindala)
		{
			if (Pindala < 100)
			{
				info = "vaike maja";
			}
			else if (Pindala >= 100 && Pindala < 150)
			{
				info = "keskmine maja";
			}
			else if (Pindala < 300)
			{
				info = "suur maja";
			}
			else
			{
				info = "liiga suur maja";
			}
		}
		public string Info  
		{
			get { return info; }   
		}
		public void NaitaInf()
		{
			Console.WriteLine($"Mina olen {info}, minu pindala on {Pindala} m2");
		}
	}
}
