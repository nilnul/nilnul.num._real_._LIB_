using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// measure is always nonneg. eg: energy cannot be negative.
	/// This is better put under a set, not <see cref="nilnul.obj"/>; or we need the <see cref="nilnul.obj"/> as a set. eg: nilnul.time.measure is incorrect, but <see cref="nilnul.time.tend.Measure"/> is right;
	/// </summary>
	/// <remarks>
	/// measure is defined on a collection. so <see cref="obj"/> must be a set, such as the <see cref="num.real.IBound"/> as directionless; <see cref="nilnul.geometry.linear.Tend"/> which is a directionless collection, not a grad which is directed, a mapping from time to point on a line. 
	/// </remarks>
	/// 
	/// <seealso cref="obj.IMetric"/>
	/// <seealso cref="nilnul.rel_.ITally"/>
	///

	[Obsolete("Measure can only be applied onto a collection, not an obj. see: nilnul.collection.family_.ring_.sigma.IMeasure")]
	public interface IMeasure
	{

	}



	/// <summary>
	/// such as length, area, unit. a measure on a set is a systematic way to assign a number to each suitable subset of that set, intuitively interpreted as its size. In this sense, a measure is a generalization of the concepts of length, area, and volume
	/// </summary>
	/// <remarks>
	///
	/// alias:
	///		magnitude
	/// </remarks>
	///
	public interface MeasureI<TUnit>
		: _measure_.AmountI
		,
		_measure_.UnitI<TUnit>


	,
	IMeasure

		where TUnit : nilnul.obj._measure.UnitI
	{
	}

	public class Measure<TUnit>
		: MeasureI<TUnit>
		where TUnit : _measure.UnitI

	{
		private TUnit _unit;

		public TUnit unit
		{
			get { return _unit; }
			set { _unit = value; }
		}



		private nilnul.num.real_.NonnegI _amount;

		public nilnul.num.real_.NonnegI amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		public nilnul.num.real_.Nonneg toStd()
		{
			return new nilnul.num.real_.Nonneg(_amount.ToReal() * _unit.magnitude);
		}
		public Measure(
			nilnul.num.real_.NonnegI amount
			,
			TUnit unit
		)
		{
			_amount = amount;
			_unit = unit;

		}

		public Measure(RealI amount, TUnit unit) : this(
			new nilnul.num.real_.Nonneg(amount), unit
		)
		{
		}


		public Measure(nilnul.num.QuotientI1 amount, TUnit unit) : this(
			new nilnul.num.real_.Nonneg(amount), unit
		)
		{
		}

		public Measure(nilnul.num.Quotient1 amount, TUnit unit) : this(
			(nilnul.num.QuotientI1)amount, unit
		)
		{
		}

		public Measure(long amount, TUnit unit) : this(
			(nilnul.num.Quotient1)amount, unit
		)
		{
		}

		public Measure(int amount, TUnit unit) : this(
			(nilnul.num.Quotient1)amount, unit
		)
		{
		}

		public override string ToString()
		{
			return $"{amount}{unit}";
		}

	}

}
