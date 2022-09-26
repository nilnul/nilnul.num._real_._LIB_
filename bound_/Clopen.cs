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
	public interface IClopen4dbl { }

	public class Clopen4dbl : nilnul.num.real.BoundDbl
		,
		IClopen4dbl
	{
		

		public Clopen4dbl(double border1, double border2) : base( LowerDbl.CreateClose(border1), UpperDbl.CreateOpen(border2))
		{
		}

		
	}
}
