using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.accumulate_
{
	[Obsolete()]
	 public class SqSum
		:
		nilnul.obj._accumulate_.OfSeqA<double>
		
	{
	
		public override double accumulate(IEnumerable<double> arg)
		{
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(arg)
			);
		}


		static public SqSum Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<SqSum>.Instance;
			}
		}
		static public SqSum Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SqSum>.Instance;
			}
		}


	}
}
