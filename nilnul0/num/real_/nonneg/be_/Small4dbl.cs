using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.be_
{
	/// <summary>
	/// around nil
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		nilish
	///		nily
	///		minimal
	///		insignicant
	///		unimportant
	///		ignorable
	///		neglectable
	///		nilectable
	public class Small4dbl
		: nilnul.obj.Box_ofIn<nilnul.num.real_.NonnegOfDoubleI>
		,
		nilnul.num.real_.nonneg.Be4dblI
	{
		public real_.NonnegOfDoubleI radius {
			get {
				return boxed;
			}
		}
		public Small4dbl(real_.NonnegOfDoubleI val):base(val) 
		{
		}
		public Small4dbl(real_.NonnegOfDouble val) : this((NonnegOfDoubleI)(val))
		{
		}

		public Small4dbl(double x):this(new real_.NonnegOfDouble(x) )
		{
				
		}

		public bool _be_0finiteNonneg(double x) {
			return x <= boxed.realee.ee;
		}
	
		public bool be(in NonnegOfDoubleI val)
		{
			return nonneg.re_.Le.Singleton.re(val, boxed);
		}

		public bool be( NonnegOfDoubleI val)
		{
			return nonneg.re_.Le.Singleton.re(val, boxed);
		}

		public bool be( NonnegOfDouble val)
		{
			return nonneg.re_.Le.Singleton.re(val, boxed);
		}

		public bool be(double obj)
		{
			return be( new NonnegOfDouble( obj ));

			//throw new NotImplementedException();
		}

		public bool not(double x) {
			return !be(x);
		}

	

	}
}
