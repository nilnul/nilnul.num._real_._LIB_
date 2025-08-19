using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._metric._unit_
{
	/// <summary>
	/// of how many baseUnitS
	/// </summary>
	///
	[Obsolete()]
	public interface MagnitudeI
	{
		nilnul.num.real_.PositiveI magnitude { get; }
	}

	[Obsolete()]
	public abstract class MagnitudeA : nilnul.obj.Box1<nilnul.num.real_.PositiveI>
		,
		MagnitudeI
	{
		protected MagnitudeA(PositiveI val) : base(val)
		{
		}

		public PositiveI magnitude => boxed;
	}
}
