using nilnul.obj.op_;
using nilnul.obj.op_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_.add
{
	public class Cumulator:
		nilnul.obj.op_.binary.cumulator_.OpDefault<RealI, Add>
		,
		op_.binary.CumulatorI

	{
		public Cumulator() : base(new nilnul.num.real_.Quotient(0))
		{
		}


		static public Cumulator Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator>.Instance;
			}
		}


	}
}
