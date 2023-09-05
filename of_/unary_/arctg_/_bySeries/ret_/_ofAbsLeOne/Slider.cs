using nilnul.num.quotient.bound_;
using nilnul.num.quotient.stream_.slider;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.arctg_._bySeries.ret_._ofAbsLeOne
{
	public class _SliderX
	{
		static public num.quotient.stream_.SliderI1 Multi(num.Quotient1 val)
		{

			return num.quotient.stream_.slider.op_.binary_.Multi.Lazy.op(
				new nilnul.num.quotient.stream_.slider_.odd.inversed.Alt()
				,
				new num.quotient.stream_.slider_.geometric_.PolyOdd(val)
			);

		}
	}

	public class Slider : num.quotient.stream_.slider.op_.binary_._multi.Ret
	{
		public num.Quotient1 val;
		public Slider(num.Quotient1 val) :
			base(
				new nilnul.num.quotient.stream_.slider_.odd.inversed.Alt()
				,
				new num.quotient.stream_.slider_.geometric_.PolyOdd(val)
		)
		{
			this.val = val;
		}
	}

	/// <summary>
	///  1/(2n+1) * x^(2n+1) - 1/(2n+3) * x^(2n+3)
	/// </summary>
	public class SliderPaired : num.quotient.stream_.slider.op_.unary_.batch_._pair.PairedByAdd
	{

		public num.Quotient1 val;

		public SliderPaired(num.Quotient1 q) : base(
			new Slider(q)
		)
		{
			this.val = q;
		}
	}

	public class Series : num.quotient.stream_.slider.Series

	{
		public num.Quotient1 val;

		public Series(num.Quotient1 v) : base(new Slider(v))
		{
			this.val = v;
		}


	}

	[Obsolete(nameof(_ofAbsLtOneNeNil))]
	public class AsReal
		: nilnul.obj.Box<Series>
		, RealI
	{
		public AsReal(num.Quotient1 val) : base(new Series(val))
		{
			_current = Closed.Create_orderIfNecessary(0, val);

		}
		private Closed _current;
		public Closed current => _current;

		private BigInteger _index = 0;
		public void squeeze(Positive1 diameter)
		{



			while (current.diameterGt(diameter))
			{
				this.boxed.moveNext();
				_current = num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_current
					,
					Closed.Create_orderIfNecessary(boxed.current,
	boxed.current + boxed.nextAugend)
				);

			}


		}
	}


}
