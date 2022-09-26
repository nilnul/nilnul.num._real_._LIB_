using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.obj.stream_._slider._cursor_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.series_.arcsin_
{

	public class OfPortion
		: nilnul.num.real.stream_.slider.cumulus_.Series
		,
		nilnul.num._real_.ClampI1
		,
		num.real.stream_.bounded_._cauchy_._SqueezeI
		,
		nilnul.num.RealI
	{

		public OfPortion(RealI val) : base(new _arcsin.Term(val))
		{
		}

		public OfPortion(Real val) : this((RealI)(val))
		{
			this.arg = val;
			argSquared = nilnul.num.real.op_.unary_._SquareX.Op(this.arg);
			_computeBound();
		}

		public RealI arg { get; private set; }

		private RealI argSquared;

		private Bound1 _bound;

		void _computeBound()
		{
			var variation = real.stream_.slider_.geometric.cumulus_.sum_._CauchyX._Limit_assumeCauchy(
				this.toBeCumulated
				,
				argSquared
			);
			_bound = new nilnul.num.real.bound_.closed_.Based(this.current, variation);

		}

		public Bound1 bound
		{
			get
			{
				return _bound;
				//var variation = real.stream_.slider_.geometic.cumulus_.sum_._CauchyX._Limit_assumeCauchy(this.toBeCumulated, arg);
				//return new nilnul.num.real.bound_.closed_.Based(this.current, variation);
			}
		}

		Closed CurrentI<Closed>.current
		{
			get
			{
				nilnul.num.real.bound_.spanned_.disengaged.OuterOvDiameterX.Outer_assumeSpanned(_bound, 2);

				return new Closed(
					_bound.lower.mark.current.upper
					,
					_bound.upper.mark.current.lower
				);
			}
		}

		public void clamp(Positive1 diameter)
		{
			squeeze(new real_.Positive(diameter / 3));
		}
		public void squeeze(Positive1 diameter)
		{
			clamp(diameter);
		}

		public void squeeze(real_.PositiveI diameter)
		{
			var currentDiameter = bound.diameter;

			var ratio = diameter / currentDiameter.ToReal();

			var ratioRangeForOneStep = new nilnul.num.real.bound_.closed_.Spanned(
				 argSquared.ToReal()
				,
				1

			);

			var t = nilnul.num.real.bound_.closed_.spanned.vsReal_.trich_._GeX.Trich(
				ratioRangeForOneStep
				, ratio
			);
			switch (t)
			{
				case bound_.closed_.spanned.vsReal_.trich_._ge.Rel.GeUpper:
					return;
					break;
				case bound_.closed_.spanned.vsReal_.trich_._ge.Rel.GeLower:
					this.boxed.moveNext();


					//return;
					break;
				case bound_.closed_.spanned.vsReal_.trich_._ge.Rel.LtUpper:
					var nRequired = nilnul.num.real.co_.starT_.positive_.neOne_.enD_.positive._LogX.Log(
						argSquared
						,
						ratio
					);

					nRequired.Clamp(1);

					var ceiled = nilnul.num.quotient_.FlooredX.Ceil(nRequired.current.upper.mark);

					for (BigInteger i = 0; i < ceiled; i++)
					{
						boxed.moveNext();
					}

					break;
				default:
					break;
			}






			_computeBound();

		}


		//public Arcsin(Quotient1 quotient1):this( (Real)quotient1)
		//{

		//}
	}
}
