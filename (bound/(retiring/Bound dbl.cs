using System;

namespace nilnul.num.dbl
{
	[Obsolete(nameof(nilnul.num.real.BoundDbl))]
	public class Bound
		: nilnul.num.dbl.border.co.be_.dwelt.vow.En
		,
		nilnul.obj.BoundI<Border>
	{
		public Bound(border.Co val) : base(val)
		{
		}

		public Bound(Border x, Border y) : this(new border.Co(x, y))
		{

		}

		public Border lower => this.en.lower;

		public Border upper => this.en.upper;

		public bool contain(double x)
		{
			return border.comp_.lower.Re.Singleton.le(lower, x) && border.comp_.upper.Re.Singleton.ge(upper, x);
		}

		public static Bound CreateClose(double x, double y)
		{
			return new Bound(Border.CreateClose(x), Border.CreateClose(y));
		}
		public static Bound CreateOpen(double x, double y)
		{
			return new Bound(Border.CreateOpen(x), Border.CreateOpen(y));
		}

		public static Bound CreateClopen(double x, double y)
		{
			return new Bound(Border.CreateClose(x), Border.CreateOpen(y));
		}
		public static Bound CreateOpenClose(double x, double y)
		{
			return new Bound(Border.CreateOpen(x), Border.CreateClose(y));
		}

		public static Bound CreateSingle(double x)
		{
			return CreateClose(x, x);
		}

		public static Bound CreateCloseOvNeighbor(double center, dbl_.Nonneg radius)
		{
			return CreateClose(center - radius, center + radius
					);
		}


		public static Bound CreateCloseOvNeighbor(double center,double radius)
		{
			return CreateCloseOvNeighbor(center, new dbl_.Nonneg(radius));
		}



		public static Bound CreateOpenOvNeighbor(double center, dbl_.Positive radius)
		{
			return CreateOpen(center - radius, center + radius
			);
		}

		public static Bound CreateOpenOvNeighbor(double center, double radius)
		{
			return CreateOpenOvNeighbor(center, new dbl_.Positive(radius)
			);
		}

		public static Bound CreateClopenOvNeighbor(double center, dbl_.Positive radius)
		{
			return CreateClopen(center - radius, center + radius
			);
		}
		public static Bound CreateClopenOvNeighbor(double center, double radius)
		{
			return CreateClopenOvNeighbor(center, new dbl_.Positive(radius));
		}

		public static Bound CreateOpenCloseOvNeighbor(double center, dbl_.Positive radius)
		{
			return CreateOpenClose(center - radius, center + radius
			);
		}
		public static Bound CreateOpenCloseOvNeighbor(double center, double radius)
		{
			return CreateOpenCloseOvNeighbor(center , new dbl_.Positive(radius)
			);
		}


	}

}
