using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._measure._unit_
{
	/// <summary>
	/// of how many baseUnitS
	/// </summary>
	/// alias:
	///		magnitude
	///		departure
	///		quantity
	///		amount
	///		
	public interface MagnitudeI
	{
		nilnul.num.real_.PositiveI magnitude { get; }
	}

	public abstract class MagnitudeA : nilnul.obj.Box1<nilnul.num.real_.PositiveI>
		,
		MagnitudeI
	{
		protected MagnitudeA(PositiveI val) : base(val)
		{
		}

		public MagnitudeA(nilnul.num.RealI x):this(new nilnul.num.real_.Positive(x) )
		{

		}

		public PositiveI magnitude => boxed;
	}
}
