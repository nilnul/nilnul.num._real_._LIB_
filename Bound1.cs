using nilnul.num.real._bound;
using nilnul.num.real._bound.lowerUpper.be_.dwelt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real
{
	/// <summary>
	/// the border of the bound is like a column of some thickness, if we think of the bound in terms of quotients
	/// </summary>
	public class Bound1
		:
		_bound.lowerUpper.be_.dwelt.En
		,
		_bound_.LowerI
		,
		_bound_.UpperI
		,
		_bound_.BordersI
		,
		nilnul.obj._set_.ContainI<num.RealI>
		,
		_bound_.MidI
		,
		_bound_.DiameterI
		,
		BoundI
	{
		public Bound1(LowerUpper obj) : base(obj)
		{
		}

		public Bound1(Lower border1, Upper border2) : this(new LowerUpper(border1, border2))
		{
		}


		public Bound1(Border border1, Border border2) : this(new Lower(border1), new Upper(border2))
		{
		}
		public Lower lower => base.ee.lower;

		public Upper upper => base.ee.upper;

		public En borders => this;

		public RealI mid =>

			 (lower.mark.ToReal() + upper.mark) / 2;

		public RealI diameter => upper.mark.ToReal() - lower.mark;

		public bool contain(RealI x)
		{
			return nilnul.num.real.border.comparer_.lower.Re.Singleton.le(lower, x)
				&&
			nilnul.num.real.border.comparer_.upper.Decider.Singleton.ge(upper, x);
		}

		static public Bound1 CreateOpen(R a, R b)
		{
			return new Bound1(
				 Lower.CreateOpen(a)
				

				 ,
				 Upper.CreateOpen(
					b
				 )
			);
		}

		public static Bound1 CreateClopen(RealI real1, RealI real2)
		{
			return new Bound1(
				Lower.CreateClose(real1)
				,
				Upper.CreateOpen(real2)
			);
		}

		public static Bound1 CreateOpenClose(RealI real1, RealI real2)
		{
			return new Bound1(
				Lower.CreateOpen(real1)
				,
				Upper.CreateClose(real2)
			);
		}

		static public Bound1 CreateClose(R a, R b)
		{
			return new Bound1(
				 Lower.CreateClose(a)
				 ,
				 Upper.CreateClose(b)
			);
		}

		public static Bound1 CreateClose(int v, R argSquared)
		{
			return CreateClose(
				new nilnul.num.real_.Quotient(v),argSquared
			);
		}
		public static Bound1 CreateClose(nilnul.num.real_.Quotient v, nilnul.num.real_.Quotient argSquared)
		{
			return CreateClose(
				(RealI)(v),(RealI)(argSquared)
			);
		}
		public static Bound1 CreateClose(int v, int argSquared)
		{
			return CreateClose(
				new nilnul.num.real_.Quotient(v),new nilnul.num.real_.Quotient(argSquared)
			);
		}
		public static Bound1 CreateClose(nilnul.num.Quotient1 v, nilnul.num.Quotient1 argSquared)
		{
			return CreateClose(
				new nilnul.num.real_.Quotient(v),new nilnul.num.real_.Quotient(argSquared)
			);
		}



	}


}
