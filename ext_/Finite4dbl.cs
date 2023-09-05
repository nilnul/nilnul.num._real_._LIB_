using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = System.Double;


namespace nilnul.num.real.ext_
{

	[Obsolete(nameof(real.Ext4dbl))]
	public class Finite4dbl
		:
		nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee
		,
		Ext4dblI
		,
		INoninf
	{
		public Finite4dbl(R val) : base(val)
		{
		}

		public Finite4dbl(in double val) : base(val)
		{
		}

		static public Finite4dbl operator -(Finite4dbl x) {
			if (x.errable==0)
			{
				return x;
			}
			return new Finite4dbl(x.errable);
		}

		public double errable => eeByRef;
	}
}
