using System.Security.Cryptography;

namespace nilnul.num.real
{
	///--------------------------------
	/// we need to define some fundamental concepts of function to make real the obj a closure for some fundamental operations.
	///
	/// However, when some operations on fn is beyond this fundamental closure, they are deferred; eg: derivative would treat fn as operand, all of which would be a collective of cardinality:2^R, higher than this, So it's deferred to <see cref="nilnul.num.real.func"/>, and integral would be further deferred to <see cref="nilnul.math.calculus"/>
	/// --------------------------------
	/// 
	///  we have the "uncountable sequences", that is, the set of functions from R	to R   , which does have a greater cardinality: 2^R.
	/// <summary>
	/// 
	/// </summary>
	public interface IFn
		:nilnul.obj.IFn<num.IReal>
	{ }


}
