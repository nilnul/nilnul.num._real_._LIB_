using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._measure
{
	public interface IUnit
	{
	}
	public interface UnitI :
		IUnit
		,_unit_.MagnitudeI
	{
	}
	public  class UnitA :
		nilnul.obj.Box1< nilnul.num.real_.PositiveI>
		,

		UnitI
	{
		protected UnitA(PositiveI val) : base(val)
		{
		}

		public PositiveI magnitude => boxed;

	}

	/// <summary>
	/// the base unit
	/// </summary>
	public class Unit : UnitI
	{
		public PositiveI magnitude => new nilnul.num.real_.Positive(1);
	}

}
