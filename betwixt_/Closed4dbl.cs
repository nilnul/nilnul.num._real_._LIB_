using nilnul.obj.algebra_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.range_
{
	public class Closed4dbl
		:
		real.IBetwixt
		//,
		//real.betwixt_.IDwelt
	{
		private Real4dblI _lowerMark;

		public Real4dblI lowerMark
		{
			get { return _lowerMark; }
			set { _lowerMark = value; }
		}
		private Real4dblI _upperMark;

		public Real4dblI upperMark
		{
			get { return _upperMark; }
			set { _upperMark = value; }
		}

		public Closed4dbl(Real4dblI lowerMark,Real4dblI upperMark)
		{
			_lowerMark = lowerMark;
			_upperMark = upperMark;
		}

		public real.bound_.ClosedDbl toBound() {
			if (_lowerMark.errable<=_upperMark.errable)
			{
				return new bound_.ClosedDbl( _lowerMark.errable,upperMark.errable);

			}
			return new bound_.ClosedDbl( upperMark.errable , _lowerMark.errable);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="basis"></param>
		/// <param name="drift">
		/// <see cref="nilnul.num.real.of_.unary_._NeutralizeX._Drift_0anchor(double, double)"/>
		/// </param>
		/// <returns></returns>
		static public Closed4dbl OfBase9drift(Real4dblI basis,Real4dblI drift) {
			return new Closed4dbl(
				basis
				,
				num.real.of_.binary_.Add.Singleton.op(basis,drift)
			);
		}
		static public Closed4dbl OfBase9drift(Real4dbl basis,Real4dbl drift) {
			return OfBase9drift(
				(Real4dblI)basis
				,
				(Real4dblI)drift
			);
		}

		static public Closed4dbl OfBase9drift(Real4dbl lowerMark,double upperMark) {
			return OfBase9drift(
				 (lowerMark)
				,
				new Real4dbl(upperMark)
			);
		}

		static public Closed4dbl OfBase9drift(double lowerMark, Real4dbl upperMark) {
			return OfBase9drift(
				new Real4dbl(lowerMark)
				,
				 (upperMark)
			);
		}

		static public Closed4dbl OfBase9drift(double lowerMark,double upperMark) {
			return OfBase9drift(
				new Real4dbl(lowerMark)
				,
				upperMark
			);
		}







	}
}
