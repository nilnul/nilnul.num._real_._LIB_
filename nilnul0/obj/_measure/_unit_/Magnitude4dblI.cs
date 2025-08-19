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
	public interface Magnitude4dblI
	{
		nilnul.num.real_.PositiveDblI magnitude { get; }
	}

	public abstract class Magnitude4dblA : nilnul.obj.Box1<nilnul.num.real_.PositiveDblI>
		,
		Magnitude4dblI
	{
		protected Magnitude4dblA(PositiveDblI val) : base(val)
		{
		}

		protected Magnitude4dblA(PositiveDbl val) : base(val)
		{
		}

		public Magnitude4dblA(double x):this( new PositiveDbl(x))
		{

		}

		public PositiveDblI magnitude => boxed;
	}
}
