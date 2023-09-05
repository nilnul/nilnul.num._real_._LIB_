using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.real.stream_.slider_.geometric_
{
	/// <summary>
	/// x^0, x^1, x^2,..., x^n,...
	/// </summary>
	public class Std4dbl:nilnul.num.real.stream_.Slider4dblA
		
	{
		private R _rate;

		public Std4dbl( R rate)
		{
			this._rate = rate;
		}

		private double _accumulated= 1;

		public override R current => _accumulated;

		public override void moveNext()
		{
			_accumulated *=  _rate;

		}


	}
}
