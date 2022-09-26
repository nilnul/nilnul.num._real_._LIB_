using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._approach.members;
using nilnul.num.quotient;
using nilnul.num.quotient.be;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.stream_._cauchy._approach_;
using nilnul.num.quotient_;
using Q1 = nilnul.num.Quotient1;//.quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real._cauchy.approach_
{
	public class Quotient
		: nilnul.num._real._cauchy.ApproachI
	{
		private Q1 _quotient;

		public Q1 quotient
		{
			get { return _quotient; }
			set { _quotient = value; }
		}

		public Quotient(Q1 q)
		{
			_quotient = q;

		}

		public Quotient(int num, int den=1):this(new nilnul.num.Quotient1(num,den))
		{

		}

		public Quotient():this(0)
		{

		}

		public Quotient(BigInteger a):this(new Q1(a))
		{
		}

		public		Range1 range =>  Range1.CreateSingleton(_quotient);


		public override string ToString()
		{
			return _quotient.ToString();
		}

		public  static Quotient CreateOne()
		{
			return new Quotient(1);
			throw new NotImplementedException();
		}

		public  static Quotient CreateHalf()
		{
			return new Quotient(1,2);
			//throw new NotImplementedException();
		}


		public void squeeze(Positive1 diameter)
		{
			return;
			throw new NotImplementedException();
		}
	}
}
