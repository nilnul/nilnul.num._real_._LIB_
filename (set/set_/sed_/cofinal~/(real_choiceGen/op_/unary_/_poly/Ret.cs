using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.real.op_._poly
{
	public class Ret
		: nilnul.num.real.Arg
		,
		R
	{

		private N _index;

		public N index
		{
			get { return _index; }
			set { _index = value; }
		}

		public Ret(R arg, N index) : base(arg)
		{
			_index = index;
		}

		public GeneratorI choice
		{
			get
			{
				return nilnul.num._real.approach.generator.op_.Poly.Singleton.eval(arg.choice,index);
			}
		}
	}
}
