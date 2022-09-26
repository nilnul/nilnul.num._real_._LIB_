using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.doubl
{
	/// <summary>
	///Avoid double.
	/// You don't need this. 
	/// double is essential a method of discretization: a finite discrete values to asympotically approximate real value. 
	/// But double is a bad discretization method. You can use integers and quotient to do the same and have these advantage:
	/// 1) it's easy to understand.
	/// 2) you have full control
	/// 3) you know where and how much the deviation from the real value is, and thus regulate it to conform to preset range.
	/// 
	/// The steps taken when using Quotient to discreitze:
	/// Approximate the problem to a quotient problem. Sample using natural numbers.	/// 
	///  Let's see an example: nilnul.prob._test.Rain Drop On Road
	/// 
	/// 
	/// 
	/// 
   ///  You should not use double. When you want to sample from an interval, you can acheive the same effect by dividing it into  finite elements of cardinality of a natural number as using double
	/// </summary>
	/// 
	[Obsolete()]
	public class DoubleX
	{
	}
}
