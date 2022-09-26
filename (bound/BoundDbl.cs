using nilnul.num.real._bound;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class BoundDbl
		:
		nilnul.obj.be.En_beDefaultable<real._bound.LowerUpperDbl, real._bound.lowerUpper.be_.Nonempty>
	{
		public BoundDbl(LowerUpperDbl val) : base(val)
		{
		}

		public BoundDbl(LowerDbl x, UpperDbl y):this(new LowerUpperDbl(x,y))
		{

		}

		public BoundDbl(border.AsLowerDbl borderDbl1, border.AsUpperDbl borderDbl2):this( new LowerDbl(borderDbl1),new UpperDbl(borderDbl2))
		{
		}

		public BoundDbl(BorderDbl borderDbl1, BorderDbl borderDbl2):this( new border.AsLowerDbl(borderDbl1),new border.AsUpperDbl(borderDbl2))
		{
		}

		public bool has(double x) {
			return this.avowed.lower.has(x) && this.avowed.upper.has(x);
		}

		public double width {
			get {
				return this.avowed.upper.mark -this.avowed.lower.mark  ;
			}
		}

		static public BoundDbl CreateClose(double x, double y) {
			return new BoundDbl(
				new LowerDbl(true,x)
				,
				new UpperDbl(true,y)
			);
		}

		static public BoundDbl CreateClose(double x) {
			return CreateClose(x,x);
		}

		public static BoundDbl CreateOpen(double p, double x)
		{
			return new BoundDbl(
				new LowerDbl(false,p)
				,
				new UpperDbl(false,x)
			);
		}

		public static BoundDbl CreateCopen(double p, double x)
		{
			return new BoundDbl(
				new LowerDbl(true,p)
				,
				new UpperDbl(false,x)
			);
		}

		public static BoundDbl CreateOpenClose(double p, double x)
		{
			return new BoundDbl(
				new LowerDbl(false,p)
				,
				new UpperDbl(true,x)
			);
		}

		public static BoundDbl CreateClopen(double v1, double v2)
		{
			return new BoundDbl(
				new LowerDbl(false,v1)
				,
				new UpperDbl(false,v2)
			);
		}
	}
}
