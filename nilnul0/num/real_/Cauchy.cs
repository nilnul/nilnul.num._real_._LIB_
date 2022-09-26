using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q = nilnul.num.quotient;
using q_ = nilnul.num.quotient_;

using nilnul.num.quotient.be;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.ext.border.duo.be;
using Q = nilnul.num.Quotient1;
using nilnul.num.quotient.stream_.bounded_.cauchy_;
using nilnul.num.quotient.stream_.bounded_;

namespace nilnul.num.real_
{
	/// <summary>
	/// supposing  a stram This demonstrate that even the range of the stream (not the nested interava) doesn't contain 0, the limit is still able to be zero.
	/// </summary>
	public class Cauchy
		:
		nilnul.obj.Box<
		nilnul.num.quotient.stream_.bounded_.CauchyI
			>
		,
		RealI
	{

		public Cauchy(CauchyI val) : base(val)
		{
		}

		public 		q.bound_.Closed current
		{
			get
			{
				///the limit may be on the border.
				return new q.bound_.Closed(boxed.bound.lower.mark,boxed.bound.upper.mark);


			}
		}

		/// <summary>
		/// here we can see nilnul.num.quotient.stream_.bounded_._cauchy_.Squeeze shall better make the bound strictly less than, other than less than or equal to, the given diameter.
		/// </summary>
		/// <param name="diameter"></param>
		public void squeeze(q_.Positive1 diameter)
		{
			///make the diameter smaller
			boxed.makeBoundDiameterLt(diameter);

		}
	}

	public class Cauchy_streamNew<T> : Cauchy
		where T : nilnul.num.quotient.stream_.bounded_.CauchyI,new()
	{
		public Cauchy_streamNew() : base(new T())
		{
		}
	}
}
