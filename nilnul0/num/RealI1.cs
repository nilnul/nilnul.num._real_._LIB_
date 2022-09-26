using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
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
	/// 
	/// </remarks>
	public interface RealI1
		:_real_.BoundI_closed
		,_real_.ClampI
	{
	}

}
