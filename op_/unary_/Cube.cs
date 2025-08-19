using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_
{
	public class Cube : Unary4dblI, IPoly
	{
		public double op(double par)
		{
			return par*par*par;
		}


		static public Cube Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cube>.Instance;
			}
		}

	}
}
