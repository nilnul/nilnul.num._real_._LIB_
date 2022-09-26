using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num.real_.positive.ln_._byReverseExp
{
	/// <summary>
	/// 
	/// </summary>
	public class Ret :
		nilnul.obj.Box<nilnul.num.real_.PositiveI>
		,
		nilnul.num.RealI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="targetOfExp"></param>
		public Ret(PositiveI targetOfExp) : base(targetOfExp)
		{
			var lowerSrc = new positive.cast_.sup_._ln.ret_.OfQ(
					targetOfExp.current.lower.mark
				);

			var upperSrc = new positive.cast_.sup_._ln.ret_.OfQ(
					targetOfExp.current.upper.mark
				);

			_bound = new nilnul.num.quotient.bound_.Closed(
				
					lowerSrc.current.lower.mark
				

				,
				
					upperSrc.current.upper.mark
				


			);


		}
		private num.quotient.bound_.Closed _bound;
		public num.quotient.bound_.Closed current => _bound;

		public void squeeze(num.quotient_.Positive1 diameter)
		{

			_bound = nilnul.num.real.op_.unary_.injective_.upward._inverse._ret_._clamp._NarrowSrcX.DomainNarrowDown(
				boxed, 
				num.real.op_.unary_.Exp.Singleton,
				_bound,
				diameter
				);




		}


	}
}

