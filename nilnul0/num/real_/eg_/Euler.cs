using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using q = nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;

namespace nilnul.num.real_
{
	/// <summary>
	/// the base for natural logarithm;
	/// 2.718281828459
	/// </summary>
	/// alias:
	///		exp
	///		euler
	///			<see cref="IEuler"/>
	public class Euler
		:
		nilnul.obj.box_.OfNew<_euler.Series>
		//nilnul.num.quotient.stream_.bound_.cauchy_.slider_.SliderSeriesA
		,
		nilnul.num.RealI

	{

		private nilnul.num.quotient.Bound _exp0_x;
		public nilnul.num.quotient.Bound exp0_x
		{
			get { return _exp0_x; }
			//set { _exp0_x = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public Euler() : base(

		)
		{
			_exp0_x = nilnul.num.quotient.Bound.CreateOpen(
				1,
				3
			);

			_bound = new nilnul.num.quotient.bound_.Closed(
				1,
				3
			);
		}

		private nilnul.num.quotient.bound_.Closed _bound;
		public nilnul.num.quotient.bound_.Closed current => _bound;


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			while (
				current.diameterGt(diameter)

			)
			{


				boxed.moveNext();

				var newEstimate = nilnul.num.quotient.bound_.closed.op_.unary_._ShiftX.Op(
					this.boxed.current //.accumulated ,it's 0 initally
					,
					num.quotient.bound_.Closed.Create_byMergeBorder(
					this.boxed.nextAugend * _exp0_x )  // [the (n+1)th derivative of (e^y)]  * (x-0)^(n+1) /(n+1)!, where y is in [0, x]. 
				);

				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(_bound, newEstimate);

			}
		}


		static public Euler Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Euler>.Instance;
			}
		}

		public static nilnul.num.Real SingletonAsReal
		{
			get
			{
				return new nilnul.num.Real(Singleton);

			}
		}

	}

	/*
	 事物发展的两个典型模式
1，变化速度与存量成正比，这个是指数模式，与e相关
2，回复加速度与偏离成正比, 方向相反；这个震荡模式，与π相关
	 * 
	 * ****/

}
