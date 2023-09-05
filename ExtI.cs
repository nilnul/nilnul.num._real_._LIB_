using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public interface IExt { }
	/// <summary>
	/// real numbers and infinity.
	///
	/// imaging a three layred graph:
	///			PosInf
	///	-----------------0--------------------->    real number
	///			NegInf
	/// </summary>
	public interface ExtI:IExt
	{
	}


	/// <summary>
	/// operator can be defined here
	/// </summary>
	public abstract class ExtA:ExtI
	{

	}
}
