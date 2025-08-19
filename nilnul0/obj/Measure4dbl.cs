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
	public interface Measure4dblI<TUnit>
		: _measure_.Amount4dblI
		,
		_measure_.Unit4dblI<TUnit>
	,
	IMeasure
		where TUnit : nilnul.obj._measure.Unit4dblI
	{
	}

	public class Measure4dbl<TUnit>
		: Measure4dblI<TUnit>
		,
		_measure_.ToStd4DblI
		where TUnit : _measure.Unit4dblI

	{
		private TUnit _unit;

		public TUnit unit
		{
			get { return _unit; }
			set { _unit = value; }
		}



		private nilnul.num.real_.NonnegOfDoubleI _amount;

		public nilnul.num.real_.NonnegOfDoubleI amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

	
		public Measure4dbl(
			nilnul.num.real_.NonnegOfDoubleI amount
			,
			TUnit unit
		)
		{
			_amount = amount;
			_unit = unit;

		}
		public Measure4dbl(
			nilnul.num.real_.NonnegOfDouble amount
			,
			TUnit unit
		):this((num.real_.NonnegOfDoubleI)amount,unit)
		{
			

		}


		public Measure4dbl(double amount, TUnit unit) : this(
			new nilnul.num.real_.NonnegOfDouble(amount), unit
		)
		{
		}


		

		

		public Measure4dbl(long amount, TUnit unit) : this(
			(double)amount, unit
		)
		{
		}

		public Measure4dbl(int amount, TUnit unit) : this(
			(double)amount, unit
		)
		{
		}

		public NonnegOfDoubleI toStd()
		{
			return new nilnul.num.real_.NonnegOfDouble(_amount.realee * _unit.magnitude.dblen);

		}

		public override string ToString()
		{
			return $"{amount}{unit}";
		}
	}

}
