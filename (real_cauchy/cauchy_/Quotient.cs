using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

using Squee = nilnul.num._real.squeeze.Quotient;
using nilnul.num.real._quotient;
using nilnul.num.quotient.stream_._cauchy;

namespace nilnul.num._real.cauchy_
{
	public class Quotient
		
		: nilnul.num._real.CauchyI2

	{
		private Q1 _q;
		public Q1 q
		{
			get { return _q; }
			set {
				
					_q = value;



			}
		}

		

		public _cauchy.ApproachI approach => new _cauchy.approach_.Quotient(_q);

		public Quotient():this(0)
		{

		}

		public Quotient(Q1 q)
		{
			this.q = q; 

		}

		//public ApproachI1 generate()
		//{
		//	return _squeeze;
			
		//	throw new NotImplementedException();
		//}

		public override string ToString()
		{
			return _q.ToString();
		}

		public Quotient1 next()
		{
			return _q;
			//throw new NotImplementedException();
		}
	}
}
