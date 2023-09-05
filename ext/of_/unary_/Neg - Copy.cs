using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_
{
	public class Neg : real.ext.of_.Unary4dblI
	{
		public Ext4dblI op(Ext4dblI par)
		{
			switch (par)
			{
				case real.Ext4dbl ext:
					return -ext;
				case ext_.inf_.Neg4dbl neg:
					return  Ext4dbl.PosInf;// ext_.inf_.Pos4dbl.Singleton;
				case ext_.Finite4dbl bare:
					return new Ext4dbl( -bare.errable );

				default:
					return Ext4dbl.NegInf;// ext_.inf_.Neg4dbl.Singleton;

					break;
			}
		}

		static public Neg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Neg>.Instance;
			}
		}

	}


}
