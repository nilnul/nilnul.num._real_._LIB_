using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_
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
	///		little
	///		small
	public class Small4dbl
		: nilnul.obj.Box1<nilnul.num.real.ext_.nonneg.be_.Small4dbl>
		,
		nilnul.num.real.ext.Be4dblI
	{
		public real_.NonnegOfDouble radius
		{
			get
			{
				return boxed.radius;
			}
		}
		public Small4dbl(nilnul.num.real.ext_.nonneg.be_.Small4dbl v):base(v)
		{
			
		}
		public Small4dbl(real_.NonnegOfDouble val) : this(new ext_.nonneg.be_.Small4dbl(val))
		{
		}
		public Small4dbl(real_.NonnegOfDoubleI val) : this(new ext_.nonneg.be_.Small4dbl(val))
		{
		}

		public Small4dbl(double x) : this(new real_.NonnegOfDouble(x))
		{

		}

		public bool _be_0ext(double concil)
		{
			
			return boxed._be_0extNonneg( Math.Abs(concil ));
		}
		public bool be(in Ext4dblI val)
		{
			return _be_0ext(val.errable);
		}

		public bool be( Ext4dblI val)
		{
			return _be_0ext(val.errable);
		}
		public bool be( Ext4dbl val)
		{
			return _be_0ext(val.errable);
		}


		public bool be(double obj)
		{
			return be(new Ext4dbl(obj));

			//throw new NotImplementedException();
		}



	}

}
