using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext_.inf_
{
	[Obsolete(nameof(real.Ext4dbl))]

	public class Pos4dbl
		:Inf4dblI
	{
		public const char CHAR = '∞';
		public const string TXT = "∞";


		public override string ToString()
		{
			return CHAR.ToString();
		}



		static public Pos4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Pos4dbl>.Instance;
			}
		}

		public double errable => double.PositiveInfinity;
	}
}
