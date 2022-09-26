using nilnul.num.real._bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real.bound_
{


	/// <summary>
	/// </summary>
	public interface IClosedDbl { }

	public class ClosedDbl : nilnul.num.real.BoundDbl
		,
		IClosedDbl
	{
		

		public ClosedDbl(double border1, double border2) : base( LowerDbl.CreateClose(border1), UpperDbl.CreateClose(border2))
		{
		}

		public ClosedDbl(double x ):this(x,x)
		{

		}
		public ClosedDbl():this(0)
		{

		}


		
	}
}
