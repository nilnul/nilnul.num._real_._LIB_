using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;


namespace nilnul.num.real.bound_
{
	public abstract class Centered4dblA
	{
		private double _center;

		public double center
		{
			get { return _center; }
			set { _center = value; }
		}
		private num.real.be_.positive.vow.EeDbl _radius;

		public num.real.be_.positive.vow.EeDbl radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public Centered4dblA(
			double center,
			be_.positive.vow.EeDbl radius
		)
		{
			_center = center;
			_radius = radius;
		}

		public Centered4dblA(
			double center,
			double radius
		)
			: this(center, new be_.positive.vow.EeDbl(radius))
		{
		}


		public Centered4dblA(
			double center,
			real_.PositiveDblI radius
		) : this(center, radius.dblen)
		{


		}

		public Centered4dblA(
			double center,
			real_.PositiveDbl radius
		) : this(center, (real_.PositiveDblI)radius)
		{


		}

		public Centered4dblA(real_.PositiveDblI radius) : this(0, radius)
		{

		}



	}
}
