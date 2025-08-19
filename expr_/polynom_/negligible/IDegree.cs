using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom_.negligible
{
	/// <summary>
	/// -inf, <see cref="polynom.IDegree"/>
	/// ;
	///		, this would make d(PQ) = d(P) + d(Q)
	///			,  deg(P+Q) le max( deg(P) ,deg(Q) ); eg: deg( x-x) le 1
	///			, deg(P) = deg(-P), that is deg(0) = deg(-0)
	///			, deg(remainder of A/B) lt deg(B), when B !=0, and A might be 0
	/// </summary>
	/// <see cref="polynom.IDegree"/>
	public interface IDegree
	{
	}
}
