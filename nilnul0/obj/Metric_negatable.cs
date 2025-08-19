using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface Metric2I<TUnit>
		:_metric_.QuantityI
		,
		_metric_.MarkI1<TUnit>
		,_metric_.ToStdI
		,
		IMetric
		where TUnit: nilnul.obj._metric.MarkI1
	{
	}

	public abstract class MetricA2<TUnit>
		:Metric2I<TUnit>
		where TUnit:_metric.MarkI1

	{
		private TUnit _unit;

		public TUnit mark
		{
			get { return _unit; }
			set { _unit = value; }
		}



		private nilnul.num.RealI _quantity;

		public nilnul.num.RealI quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		public abstract nilnul.num.RealI toStd();
		public MetricA2(
			nilnul.num.RealI amount
			,
			TUnit unit
		)
		{
			_quantity = amount;
			_unit = unit;

		}

		

		public MetricA2(nilnul.num.real_.Quotient amount, TUnit unit):this(
			(RealI)(amount),unit
		)
		{
		}

		public MetricA2(nilnul.num.QuotientI1 amount, TUnit unit):this(
			new nilnul.num.real_.Quotient(amount),unit
		)
		{
		}


		public MetricA2(nilnul.num.Quotient1 amount, TUnit unit):this(
			(nilnul.num.QuotientI1)amount,unit
		)
		{
		}

		public MetricA2(long amount, TUnit unit):this(
			(nilnul.num.Quotient1)amount,unit
		)
		{
		}

		public MetricA2(int amount, TUnit unit):this(
			(nilnul.num.Quotient1)amount,unit
		)
		{
		}

	}
}
