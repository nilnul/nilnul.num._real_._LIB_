using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
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
	///
	[Obsolete(nameof(Insignificant4dbl))]
	public class AboutNil4Dbl
		:
		nilnul.obj.Box1<nilnul.num.real.bound_.ClosedDbl>
		,
		nilnul.num.real.BeDblI
	{
		private real_.NonnegOfDouble _radius;
		public real_.NonnegOfDouble radius {
			get {
				return _radius;
			}
		}
		public AboutNil4Dbl(real_.NonnegOfDouble val) : base(nilnul.num.real.bound_.closed_.centered_._AroundNil4DblX.Closed(val))
		{
			_radius = val;
		}
		public AboutNil4Dbl(real_.NonnegOfDoubleI val) : base(nilnul.num.real.bound_.closed_.centered_._AroundNil4DblX.Closed(val))
		{
		}

		public AboutNil4Dbl(double x):this(new real_.NonnegOfDouble(x) )
		{
				
		}

		public bool _be_0finite(double x) {
			return boxed.has(x);

		}

		public bool be(double obj)
		{
			return boxed.has(obj);

			//throw new NotImplementedException();
		}

		public bool not(double x) {
			return !be(x);
		}

		/// <summary>
		/// this can be changed before call this
		/// </summary>
		public static AboutNil4Dbl Injected = new AboutNil4Dbl(double.Epsilon*1000);

		public static void SetInjected(double x) {
			Injected = new AboutNil4Dbl(x);
		}


	}
}
