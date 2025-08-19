using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num;

namespace nilnul.num.real.op_.unary_.arctg_._byInverse.ret_
{
	/// <summary>
	/// 
	/// </summary>
	public class OfAroundOne :
		nilnul.obj.Box<nilnul.num.RealI>
		,
		nilnul.num.RealI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_around1">
		/// in ( tg(tau/12) = 1/cubicRoot(3) ,  tg(tau/6) = cubicRoot(3) )
		/// </param>
		public OfAroundOne(nilnul.num.RealI _around1) : base(_around1)
		{
			//var cubicRoot3 = nilnul.num.real.op_.unary_.Sqrt.Singleton.op(3);

			var tauOver6 = nilnul.num.real_.Tau.Singleton.ToReal() / 6;

			var tauOver12 = tauOver6 / 2;

			//tauOver6.Clamp( nilnul.num.Quotient1.CreateHalf());

			tauOver6.Clamp(1);
			_bound = new quotient.bound_.Closed(
				tauOver12.current.lower.mark
				,
				tauOver6.current.upper.mark
			);
		}

		private num.quotient.bound_.Closed _bound;
		public num.quotient.bound_.Closed current => _bound;

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			_bound = num.quotient.bound_.Closed.Create_byMergeBorder(
				nilnul.num.real.op_.unary_.injective_.upward._inverse._ret_._clamp._NarrowSrcX.DomainNarrowDown(
					boxed
					,
					num.real.op_.unary_.Tg.Singleton
					,
					num.quotient.Bound.CreateClose(_bound.lower.mark, _bound.upper.mark)
					,
					diameter
				)
			);
		}
	}
}

