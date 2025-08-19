using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	
	/// <summary>
	/// such as length, area, unit. a measure on a set is a systematic way to assign a number to each suitable subset of that set, intuitively interpreted as its size. In this sense, a measure is a generalization of the concepts of length, area, and volume
	/// </summary>
	/// <remarks>
	///
	/// alias:
	///		magnitude
	/// </remarks>
	///
	[Obsolete()]
	public interface MetricI<TUnit>
		:_metric_.AmountI
		,
		_metric_.UnitI<TUnit>
		where TUnit: nilnul.obj._metric.IUnit
	{
	}

	[Obsolete()]
	public class Metric<TUnit>
		:MetricI<TUnit>
		where TUnit:_metric.UnitI

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

		public nilnul.num.real_.Nonneg toStd() {
			return new nilnul.num.real_.Nonneg( _amount.ToReal() * _unit.magnitude );
		}
		public Metric(
			nilnul.num.real_.NonnegI amount
			,
			TUnit unit
		)
		{
			_amount = amount;
			_unit = unit;

		}

		public Metric(RealI amount, TUnit unit):this(
			new nilnul.num.real_.Nonneg(amount),unit
		)
		{
		}


		public Metric(nilnul.num.QuotientI1 amount, TUnit unit):this(
			new nilnul.num.real_.Nonneg(amount),unit
		)
		{
		}

		public Metric(nilnul.num.Quotient1 amount, TUnit unit):this(
			(nilnul.num.QuotientI1)amount,unit
		)
		{
		}

		public Metric(long amount, TUnit unit):this(
			(nilnul.num.Quotient1)amount,unit
		)
		{
		}

		public Metric(int amount, TUnit unit):this(
			(nilnul.num.Quotient1)amount,unit
		)
		{
		}

	}
}
