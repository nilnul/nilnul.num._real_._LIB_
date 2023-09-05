using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext_.inf_
{
	[Obsolete(nameof(real.Ext4dbl))]

	public class Neg4dbl
		:Inf4dblI
	{

		public const string TXT = "-" + Pos.TXT;

		public override string ToString()
		{
			return $"-{ Pos.CHAR }";
		}


		static public Neg4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neg4dbl>.Instance;
			}
		}

		public double errable => double.NegativeInfinity;
	}
}
