using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_
{
	///
	///Piecewise definition is actually a way of specifying the function, rather than a characteristic of the resulting function itself.
	/// <summary>
	/// defined by finite number of pieces. 
	/// </summary>
	/// <remarks>
	/// When it comes to definition, it has to be done in finite number of clauses (for denumerability, or infinite countability, it also has to be defined by recursion, a string of, finite number of clauses). So piecewise means for definability, hence means finite pieces.
	///
	/// piecewise linear, piecewise smooth, piecewise continuous, and others;
	/// </remarks>
	///
	/// 
	/// 
	/// alias:
	///		components, like the component of a vector.
	///		segment
	///			,splittable
	///			,defragment
	///		sectional, as sections in an article
	///		piecewise
	///			,piece by piece
	///		partitionable
	///		dissectable
	///		separable
	///		fragments
	///		piecewise-defined function
	///		hybrid
	///		 function defined by cases
	///		 partwise
	///		aspect
	///		module
    public interface ISegmented
		:IFn
    {
    }

}
