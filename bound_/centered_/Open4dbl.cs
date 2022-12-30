using nilnul.num.real.be_.positive.vow;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.centered_
{
	public class Open4dbl
		:
		Centered4dblA
		
	{
		public Open4dbl(PositiveDblI radius) : base(radius)
		{
		}

		public Open4dbl(double center, EeDbl radius) : base(center, radius)
		{
		}

		public Open4dbl(double center, double radius) : base(center, radius)
		{
		}

		public Open4dbl(double center, PositiveDblI radius) : base(center, radius)
		{
		}

		public Open4dbl(double center, PositiveDbl radius) : base(center, radius)
		{
		}

		public BoundDbl toBound() {
			return new bound_.Open4dbl(
				center - this.radius.ee
				,
				center + this.radius.ee
			);
		}


	}
}
