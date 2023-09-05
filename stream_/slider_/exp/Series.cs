using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.exp
{
	public class Series : real.stream_.slider.Series
	{
		public Series(RealI v) : base(new real.stream_.slider_.Exp(v))
		{
		}


		public nilnul.Num1 index
		{
			get {


			}
		}

	}
}
