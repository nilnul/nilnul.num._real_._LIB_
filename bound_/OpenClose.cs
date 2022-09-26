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
	public interface IOpenClose4Dbl { }

	public class OpenClose4Dbl : nilnul.num.real.BoundDbl
		,
		IOpenClose4Dbl
	{
		

		public OpenClose4Dbl(double border1, double border2) : base( LowerDbl.CreateOpen(border1), UpperDbl.CreateClose(border2))
		{
		}

		
	}
}
