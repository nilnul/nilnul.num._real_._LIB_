using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext_.inf_
{
	public class Neg
		:InfI
	{


		public override string ToString()
		{
			return $"-{ Pos.CHAR }";
		}

		public const string TXT = "-" + Pos.TXT;

		static public Neg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Neg>.Instance;
			}
		}


	}
}
