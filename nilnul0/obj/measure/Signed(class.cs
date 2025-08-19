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

namespace nilnul.obj.measure
{
	


	public class Signed<TUnit>
		: SignedI<TUnit>
		where TUnit : _measure.UnitI

	{
		private TUnit _unit;

		public TUnit unit
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

		public nilnul.num.RealI toStd()
		{
			return (_quantity.ToReal() * _unit.magnitude);
		}
		public Signed(
			nilnul.num.RealI amount
			,
			TUnit unit
		)
		{
			_quantity = amount;
			_unit = unit;

		}

		


		public Signed(nilnul.num.real_.Quotient amount, TUnit unit) : this(
			(RealI)(amount), unit
		)
		{
		}

		public Signed(nilnul.num.QuotientI1 amount, TUnit unit) : this(
			new nilnul.num.real_.Quotient(amount), unit
		)
		{
		}

		public Signed(nilnul.num.Quotient1 amount, TUnit unit) : this(
			(nilnul.num.QuotientI1)amount, unit
		)
		{
		}

		public Signed(long amount, TUnit unit) : this(
			(nilnul.num.Quotient1)amount, unit
		)
		{
		}

		public Signed(int amount, TUnit unit) : this(
			(nilnul.num.Quotient1)amount, unit
		)
		{
		}

		public override string ToString()
		{
			return $"{quantity}{unit}";
		}

	}

}
