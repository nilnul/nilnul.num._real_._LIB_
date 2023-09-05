using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real._bound.lowerUpper.be_.dwelt;
using nilnul.num.real.border;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	/// <summary>
	/// The Range is the difference between the lowest and highest values. It scans from the lowest to the upperest.
	/// </summary>
	///
	[Obsolete()]
	public class Bound
		: border.co.be_.nonempty.vow.En
		,
		nilnul.num.real.border._co_.LowerI
		,
		nilnul.num.real.border._co_.UpperI
	{

		public Bound(border.Co val) : base(val)
		{

		}

		public Bound(Border border1, Border border2):this(new border.Co(border1,border2))
		{
		}

		public Bound(En borders):this(
			borders.ee.lower, borders.ee.upper
		)
		{
		}

		public Border lower
		{
			get
			{
				return this.en.lower;
				//throw new NotImplementedException();
			}
		}

		public Border upper
		{
			get
			{
				return en.upper;
				//throw new NotImplementedException();
			}
		}

		public R diameter
		{
			get
			{
				return nilnul.num.real.border.CoX.Diameter(this);
			}
		}

		public R center
		{
			get
			{
				return (lower.mark.ToReal()+ upper.mark)/2;
			}
		}


		public bool contains(R x)
		{
			return nilnul.num.real.border.comparer_.lower.Re.Singleton.le(lower, x)

				&&
				nilnul.num.real.border.comparer_.upper.Decider.Singleton.ge(upper, x);
				
				

		}

		static public Bound CreateOpen(R a, R b) {
			return new Bound(
				 border.Co.CreateOpen(a,b)
			);
		}

		public static Bound CreateClopen(Real real1, Real real2)
		{
			return new Bound(
				num.real.Border.CreateClose(real1)
				,
				num.real.Border.CreateOpen(real2)
			);
		}

		public static Bound CreateOpenClose(Real real1, Real real2)
		{
			return new Bound(
				num.real.Border.CreateOpen(real1)
				,
				num.real.Border.CreateClose(real2)
			);
		}

		static public Bound CreateClose(R a, R b) {
			return new Bound(
				 border.Co.CreateClose(a,b)
			);
		}


	}
}
