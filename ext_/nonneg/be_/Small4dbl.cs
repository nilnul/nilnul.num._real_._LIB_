using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext_.nonneg.be_
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
		: nilnul.obj.Box1<nilnul.num.real_.nonneg.be_.Small4dbl>
		,
		nilnul.num.real.ext_.nonneg.Be4dblI
	{
		private real_.NonnegOfDouble _radius;
		public real_.NonnegOfDouble radius
		{
			get
			{
				return _radius;
			}
		}

		public Small4dbl(nilnul.num.real_.nonneg.be_.Small4dbl v):base(v)
		{
			
		}
		public Small4dbl(real_.NonnegOfDouble val) : this(new real_.nonneg.be_.Small4dbl(val))
		{
			_radius = val;
		}
		public Small4dbl(real_.NonnegOfDoubleI val) : this(new real_.nonneg.be_.Small4dbl(val))
		{
		}

		public Small4dbl(double x) : this(new real_.NonnegOfDouble(x))
		{

		}

		public bool _be_0extNonneg(double concil)
		{
			if (double.IsInfinity( concil) )
			{
				return false;
			}
			return boxed._be_0finiteNonneg(concil);
		}
	


		public bool be(in Nonneg4dblI val)
		{
			return _be_0extNonneg(val.errable);
		}

		public bool be( Nonneg4dblI val)
		{
			
			return be( in val);
		}

		public bool be( Nonneg4dbl val)
		{
			
			return be( (Nonneg4dblI) val);
		}

		public bool be(double obj)
		{
			return be(new Nonneg4dbl(obj));

			//throw new NotImplementedException();
		}

	}

}
