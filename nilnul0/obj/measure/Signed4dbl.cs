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
using nilnul.num.real_;

namespace nilnul.obj.measure
{
	public class Signed4dbl<TUnit>
		: Signed4dblI<TUnit>
		,
		_signed_.ToStd4DblI
		where TUnit : _measure.Unit4dblI

	{
		private TUnit _unit;

		public TUnit unit
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

	
		public Signed4dbl(
			double quantity0
			,
			TUnit unit
		)
		{
			_quantity = quantity0;
			_unit = unit;

		}
		

		public Signed4dbl(
			decimal quantity0
			,
			TUnit unit
		):this(
			(double)quantity0
			,
			unit
		)
		{
		}

		public Signed4dbl(long amount, TUnit unit) : this(
			(double)amount, unit
		)
		{
		}

		public Signed4dbl(int amount, TUnit unit) : this(
			(double)amount, unit
		)
		{
		}

		public double toStd()
		{
			return (_quantity * _unit.magnitude.dblen);

		}
		public override string ToString()
		{
			return $"{quantity}{unit}";
		}
	}
}