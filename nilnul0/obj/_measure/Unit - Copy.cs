using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._measure
{
	
	public interface Unit4dblI :
		IUnit
		,_measure._unit_.Magnitude4dblI
	{
	}
	public  class Unit4dblA :
		nilnul.obj.Box1< nilnul.num.real_.PositiveDblI>
		,

		Unit4dblI
	{
		protected Unit4dblA(PositiveDblI val) : base(val)
		{
		}

		public Unit4dblA(PositiveDbl x):this(( PositiveDblI)x )
		{

		}
		public Unit4dblA(double x):this(new PositiveDbl(x) )
		{

		}

		public PositiveDblI magnitude => boxed;

	}

	/// <summary>
	/// the base unit
	/// </summary>
	public class Unit4dbl : Unit4dblA
	{
		public Unit4dbl() : base(new PositiveDbl(1))
		{
		}
	}

}
