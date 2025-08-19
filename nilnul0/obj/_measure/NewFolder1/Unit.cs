using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._metric
{
	[Obsolete()]
	public interface IUnit
	{
	}
	[Obsolete()]
	public interface UnitI :
		IUnit
		,_unit_.MagnitudeI
	{
	}

	/// <summary>
	/// the base unit
	/// </summary>
	[Obsolete()]
	public class Unit : UnitI
	{
		public PositiveI magnitude => new nilnul.num.real_.Positive(1);
	}

	[Obsolete()]
	public abstract class UnitA :
		nilnul.obj.Box1< nilnul.num.real_.PositiveI>
		,

		UnitI
	{
		protected UnitA(PositiveI val) : base(val)
		{
		}

		public PositiveI magnitude => boxed;

	}
}
