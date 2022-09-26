using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real_;
using R = nilnul.num.RealI;


namespace nilnul.num.real
{
//[Obsolete("too slow;may perpetual", true)]

	public class Comparer
		:
		nilnul.obj.CompareA<R>
		,
		IComparer<R>
	{
		public override int Compare(R x, R y)
		{
			return nilnul.num.real._SignX.Int(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(x, y)
			);
		}


		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}
	}
}