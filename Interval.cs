using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.ext.border;

namespace nilnul.num.real
{
	public class Interval
		: nilnul.num.real.ext.border.duo.ed_.Dwelled
		,
		nilnul.num.real._collection_.ContainI
	{
		public Interval(ext.border.Duo val) : base(val)
		{
		}

		

		static public Interval CreateClopen(nilnul.num.RealI lower, nilnul.num.RealI upper) {
			return new Interval(
				 ext.border.Duo.CreateClopen(lower, upper)
			);
		}

		static public Interval CreateClopen(nilnul.num.RealI lower) {
			return new Interval(
				 ext.border.Duo.CreateClopen(lower)
			);
		}


		public static Interval CreateClopen(int v1, int v2)
		{
			return CreateClopen(
				(nilnul.num.real_.Quotient)v1
				,
				(nilnul.num.real_.Quotient)v2

			);
			//throw new NotImplementedException();
		}
		public static Interval CreateClopen(int v1)
		{
			return CreateClopen(
				(nilnul.num.real_.Quotient)v1

			);
			//throw new NotImplementedException();
		}

		public bool contain(RealI element)
		{
			return
				nilnul.num.real.ext.border_._LowerX.Contain( this.ed.lower, element)
				&&
				nilnul.num.real.ext.border_._UpperX.Contain( this.ed.upper, element)

			;
		}
	}
}
