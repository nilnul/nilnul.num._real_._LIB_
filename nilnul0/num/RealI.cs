using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{

	/// todo: make <see cref="nilnul.NumI1"/> to box <see cref="System.Numerics.Plane"/>
	/// <summary>
	/// defined using nested quotient bound stream that is converging. (nested interval;区间套).
	/// Real number can be defined in otherways such as:
	///		cauchy stream/sequence-that-is-infinite
	///		dedekind cut
	///		
	///These definitions are equivolent so:
	///			you can find an equivalent number in other definition
	///			you can define a number that is simultaneously expessed in two or more definitions such as cauchy and nested interval
	/// </summary>
	/// <remarks>
	/// note here, the bounds (a stream of bounds) are not guaranteed as nested; in some cases, a bound later may exceed a former bound. We intend that bounds are nested, but not gurantee. (What's guaranteed is that the bound's radius can be arbitrary short)
	/// To guarantee bounds are nested, wrap this to make nilnul.num.quotient.bound.stream_.nested; we can instersect later bound with former bound to make sure later bound is nested in former ones.
	/// </remarks>
	///
	[Obsolete(nameof(RealI1))]
	public interface RealI
		:_real_.BoundI1
		,_real_.ClampI
	{
	}

}
