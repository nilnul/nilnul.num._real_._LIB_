using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	
	public interface Metric4dblI<TUnit>
		:_metric_.Quantity4dblI
		,
		_metric_.MarkI1<TUnit>
		,_metric_.ToStd4DblI
		,
		IMetric
		where TUnit: nilnul.obj._metric.MarkI1
	{

	}

	public abstract class Metric4dblA<TUnit>
		:Metric4dblI<TUnit>
		where TUnit:_metric.MarkI1

	{
		private TUnit _unit;

		public TUnit mark
		{
			get { return _unit; }
			set { _unit = value; }
		}



		private double _quantity;

		public double quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		public abstract double toStd();
		public Metric4dblA(
			double amount
			,
			TUnit unit
		)
		{
			_quantity = amount;
			_unit = unit;

		}

		


		public Metric4dblA(long amount, TUnit unit):this(
			(double)amount,unit
		)
		{
		}

		public Metric4dblA(int amount, TUnit unit):this(
			(double)amount,unit
		)
		{
		}

	}
}
