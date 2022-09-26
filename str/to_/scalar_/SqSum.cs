using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.to_.scalar_
{
	 public class SqSum
		:
		to_.Scalar4dblA
		//nilnul.obj._accumulate_.OfSeqA<double>
		,
		to_.Scalar4dblI
		,
		to_.ScalarI
		
	{
	
	

		public override double op(IEnumerable<double> arg)
		{
			return				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(arg)
			);

		}
		public  double op(params double[] arg)
		{
			return				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(arg)
			);
		}

		public  double op((double,double) arg)
		{
			return				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.op_.unary_._SquareX.Square(arg)
			);
		}
		public  double op((double,double,double) arg)
		{
			return				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.op_.unary_._SquareX.Square(arg)
			);
		}

		public  double op((double,double,double,double) arg)
		{
			return				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.op_.unary_._SquareX.Square(arg)
			);
		}
		public  double op((double,double,double,double,double) arg)
		{
			return				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.op_.unary_._SquareX.Square(arg)
			);
		}

		public RealI to(IEnumerable<RealI> arg)
		{
			return nilnul.num.real.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
				nilnul.num.real.str.op_.unary_._SquareX.Square(arg)
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
