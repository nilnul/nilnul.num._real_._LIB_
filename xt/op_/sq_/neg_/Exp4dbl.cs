using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_.sq_.neg_
{
	/// <summary>
	/// when this is integrated incomplete, it's useful to define Erf the error function;
	/// </summary>
	public class Exp4dbl
		:
		real.ext.of_.unary_.OfExt4dblA
	{
		public override double _op_0ext(double par)
		{
			return Math.Exp(-par*par);
			//throw new NotImplementedException();
		}


		static public Exp4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Exp4dbl>.Instance;
			}
		}

	}
}
