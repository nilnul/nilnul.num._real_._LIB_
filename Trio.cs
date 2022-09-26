using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class Trio : nilnul.obj.Trio<nilnul.num.RealI>
	{
		public Trio(num.RealI a, num.RealI b, num.RealI c) : base(a, b, c)
		{
		}

		public Trio(int a,int b, int c):this(
			new nilnul.num.real_.Quotient(a)
			,
			new nilnul.num.real_.Quotient(b)
			,
			new nilnul.num.real_.Quotient(c)

		)
		{

		}

		public Trio(BigInteger a,BigInteger b, BigInteger c):this(
			new nilnul.num.real_.Quotient(a)
			,
			new nilnul.num.real_.Quotient(b)
			,
			new nilnul.num.real_.Quotient(c)

		)
		{

		}

	}
}
