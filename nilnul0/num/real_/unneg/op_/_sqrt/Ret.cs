using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.obj.stream_._slider._skid_;

namespace nilnul.num.real_.nonneg.op_._sqrt
{
	/// <summary>
	/// 
	/// </summary>
	public class Ret :
		nilnul.obj.Box_ofIn<nilnul.num.real_.NonnegI_onQuotient>
		,
		nilnul.num.RealI_onQuotient
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="targetOfSqrt"></param>
		public Ret(in nilnul.num.real_.NonnegI_onQuotient targetOfSqrt) : base(in targetOfSqrt)
		{
			var lowerSrc = _SqrtX.Real_assumeNonneg(
					targetOfSqrt.current.begin	
				);

			var upperSrc = _SqrtX.Real_assumeNonneg(
					targetOfSqrt.current.end	
				);

			_bound = (
				lowerSrc.current.begin
				,
				upperSrc.current.end	
			);
		}

		public Ret(real_.PositiveI_onQuotient  arg) : this(new real_.Nonneg_onQuotient(arg))
		{
		}

		private (Q4 begin, Q4	 end) _bound;
		public (Q4 begin, Q4 end) current => _bound; 

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{

			_bound = (
				nilnul.num.real.op_.injective_.upward._inverse._ret_._cinch._NarrowSrcX.DomainNarrowDown(
					boxed
					,

					num.real.op_.Square.Singleton, (_bound.begin, _bound.end)
					,
					diameter
				)
			);




		}


	}
}

