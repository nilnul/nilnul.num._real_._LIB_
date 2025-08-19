using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.real.vec.co
	//.to_.scalar_
{
	/// <summary>
	/// dot product, inner product
	/// denoted as a.b, (a,b), 
	/// </summary>
	/// <remarks>
	/// sum of multiplication
	/// </remarks>
	/// alias:
	///		som, sum of multiplication
	///			,somewhat like sum
	///		sum of product
	///			,sop
	///		sum of mul
	///		sum of multi
	///		scalar
	///		zip
	///		zap
	///		dot
	///		inner
	///		inner product
	///	<see cref="vec.bi"/>
	///

	/*
	 or denoted as : <a,b> <a|b>
	*/

	public interface ISumOfMultiplication
		:
		nilnul.num.real.vec.IZap
		//nilnul.obj.co.IAlesce<IReal>
		//,
		//IAlesce  // returns a vec, not a number;
		//,
		//nilnul.objs.IAggregate<IReal>	/// it's not on two, but on one vec
		//,
		//nilnul.obj.str.IScala<IReal>	/// it's not on two, but on one vec;
	{}


}
