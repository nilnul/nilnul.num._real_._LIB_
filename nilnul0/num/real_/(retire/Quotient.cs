using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using nilnul.num._real.limit.sow;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real
{
	/// <summary>
	/// the instance of this type is a cluster of all cauchies that converge to the same number: the quotient field. if a cauchy converges to this quotient, the cauchy belongs to the instance of this class.
	/// So this type is the cluster generator. this type can generate many such clusters.
	/// </summary>
	/// 
	//[Obsolete("single")]
	[Obsolete()]
	public class Quotient:num.RealI_blank
		, num.RealI1

	{
		private Q _quotient;

		public Q quotient
		{
			get { return _quotient; }
			set { _quotient = value;
				_approach =new  num.real._quotient.Quotient(_quotient);
			}
		}

		private num.real._quotient.Quotient _approach;

		public num.real._quotient.Quotient approach
		{
			get { return _approach; }
		}


		public ApproachI choice
		{
			get
			{
				return _approach;
				throw new NotImplementedException();
			}
		}

	

		public Quotient(Q q)
		{
			this.quotient = q;
		}

		public Quotient(int num,int den):this(new Q(num,den))
		{

		}
		public Quotient():this(new Q())
		{

		}

	}


}
