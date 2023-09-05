using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.nulable.phrase_.null_;
using nilnul.num.real.ext.border;

namespace nilnul.num.real
{
	public class Interval4dbl
		:
		nilnul.num.real.ext.border.co.be_.dwelt_.infless.vow.Ee4dbl 
		,
		nilnul.obj._collection_.HasI<num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee>
		,
		nilnul.obj._collection_.HasI<double>

	{
		public Interval4dbl(in (ext.Border4dblI, ext.Border4dblI) val) : base(val)
		{
		}

		public Interval4dbl((ext.Border4dblI, ext.Border4dblI) val) : base(val)
		{
		}

		public Interval4dbl(ext.Border4dblI v, ext.Border4dblI val) : this((v,val))
		{
		}


		public ext.Border4dblI lower { get {
				return eeByRef.Item1;
			} }

		public ext.Border4dblI upper { get {
				return eeByRef.Item2;
			} }

		public bool has(num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee element)
		{
			return
				nilnul.num.real.ext.border_.lower.be_._HasX.Has( lower, element)
				&&
				nilnul.num.real.ext.border_.upper.be_._HasX.Has( upper, element)
			;
		}
		public bool has(double element)
		{
			return has(
				new quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee(element)
			);
		}


		static public Interval4dbl CreateClopen(
			num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee lower, num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee upper
		) {
			return new  Interval4dbl(
				 ext.border._Co4dblX.CreateClopen(lower, upper)
			);
		}

		static public Interval4dbl CreateClopen(num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee lower) {
			return new  Interval4dbl(
				 ext.border._Co4dblX.CreateClopen(lower)
			);
		}


		public static Interval4dbl Create(bool closed, double v1, bool closed1, double v2)
		{
			return new Interval4dbl(
				new ext.Border4dbl(closed,v1)
				,
				new ext.Border4dbl(closed1,v2)
			);
		}
		public static Interval4dbl CreateClopen(double v1, double v2)
		{
			return CreateClopen(
				new num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee(v1)
				,
				new quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee (v2)

			);
			//throw new NotImplementedException();
		}

		public static Interval4dbl CreateClopen(double v1)
		{
			return CreateClopen(
				new num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee(v1)

			);
			//throw new NotImplementedException();
		}

	}
}
