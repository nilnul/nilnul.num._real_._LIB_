using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.measure_
{
	public class Positive4dbl<TUnit, TMeasure> : measure.be_.positive.vow.Ee<
		TUnit, TMeasure


	>
		,
		obj.Measure4dblI<TUnit>
		where TUnit : _measure.Unit4dblI
		where TMeasure : obj.Measure4dblI<TUnit>
	{
		public Positive4dbl(TMeasure val) : base(val)
		{
		}

		public NonnegOfDoubleI amount => boxed.amount;

		public TUnit unit => boxed.unit;
	}

	public class Positive<TUnit> :
		measure.be_.positive.vow.Ee<
		TUnit
	>
		,
		obj.Measure4dblI<TUnit>
		where TUnit : _measure.Unit4dblI
	{
		public Positive(obj.Measure4dblI<TUnit> val) : base(val)
		{
		}

		public NonnegOfDoubleI amount =>boxed.amount;

		public TUnit unit => boxed.unit;
	}

}
