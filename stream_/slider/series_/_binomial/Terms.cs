using nilnul.set.family;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_._binomial
{
	/// <summary>
	/// 1, ax, a*(a-1) / 2! *x^2
	/// </summary>
	public class Terms4dbl :
		real.stream_.SliderA
	{
		

		private real.stream_.slider_.Combinate _combinate;

		public real.stream_.slider_.Combinate combinate
		{	
			get { return _combinate; }
			set { _combinate = value; }
		}


		private slider_.geometric_.Std _geometric;

		public slider_.geometric_.Std geometric
		{
			get { return _geometric; }
			set { _geometric = value; }
		}


		public Terms4dbl(num.RealI x_,num.RealI supscript_)
		{
			_combinate = new slider_.Combinate(supscript_);
			_geometric = new slider_.geometric_.Std(x_);
			
		}
		private num.Real _current=1;
		public override num.RealI current =>_combinate.current.ToImpl() * _geometric.current;

		public override void moveNext()
		{
			_combinate.moveNext();
			_geometric.moveNext();

		}
	}
}
