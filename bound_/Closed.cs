using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real.bound_
{

	static public class _ClosedX
	{
		static public Bound Bound(R a, R b)
		{
			return new Bound(
				 border.Co.CreateClose(a, b)
			);
		}

		static public Bound Bound(BigInteger a, BigInteger b)
		{
			return Bound( new nilnul.num.real_.Quotient(a),new real_.Quotient(b));
		}


	}

	/// <summary>
	/// when it comes to real.number, bound that is not closed has some weird properties, for example, the limit might be at the border even the border is open
	/// </summary>
	/// alias:
	///		range.
	///		interval is reserved for real.ext.Bound
	public interface IClosed { }

	public class Closed : nilnul.num.real.Bound1
		,
		IClosed
	{
		

		public Closed(nilnul.num.RealI border1, nilnul.num.RealI border2) : base( Lower.CreateClose(border1), Upper.CreateClose(border2))
		{
		}

		
	}
}
