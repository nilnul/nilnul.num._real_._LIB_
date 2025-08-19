using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.reals.aggregate_
{
	public class SqSum:
		nilnul.objs_.seq.AggregateA<double>,
		nilnul.num.reals.Aggregate4dblI
		,
		nilnul.num.reals.Aggregate4floatI
		,
		nilnul.num.reals.Aggregate4decimalI
	{
		 public override double aggregate(IEnumerable<double> x) {
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(x)
			);
		}

		 public float aggregate(IEnumerable<float> x) {
			return
				nilnul.num.real.co.alesce_.add.Cumulator4float.Singleton.cumulate(
				x.Select(a=>a*a)
			);
		}

		public float aggregate(params float[] x) {
			return aggregate( (IEnumerable<float>)x );
		}
		 public decimal aggregate(IEnumerable<decimal> x) {
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(x)
			);
		}

		public decimal aggregate(params decimal[] x) {
			return aggregate( (IEnumerable<decimal>)x );
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
