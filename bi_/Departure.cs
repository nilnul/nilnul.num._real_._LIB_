using System;

namespace nilnul.num.real.of_.binary_
{
	/// <summary>
	/// (x,y) 's distance from origin;
	/// </summary>
	public class Departure
		:
		of_.Binary4dblA
		,
		of_.Binary4dblI
	{


		public double of(double x, double y)
		{
			return Math.Sqrt(Variance.Singleton.of(x,y));
		}

		public double op(double x, double y)
		{
			return of(x,y);
		}

		public override double _op_01finite(double x, double y)
		{
			return Math.Sqrt(Variance.Singleton.of(x,y));

		}

		static public Departure Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Departure>.Instance;
			}
		}

	}

}
