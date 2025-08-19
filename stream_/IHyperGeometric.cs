using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// the start term is: 1;
	/// and c[k+1] / c[k]  is rational function of index. That is:
	///		= P(k) / Q(k)
	///			,where P, Q are polynomials with respect to k.
	/// 
	/// </summary>
	/// <remarks>
	/// If the polynomials are completely factored, the ratio of successive terms can be written:
	///		(k+a1)(k+a2)...(k+a[p])
	///		/
	///		(k+b1)(k+b2)...(k+b[q])(k+1)
	///	, and the generated funciton can be written as:
	///		 ( a1,a2,...a[p]; b1,b2,...b[q];      )
	///		 ,
	///		  sigma ( c[k] * x^k ) where k is from 0 to inf.
	/// </remarks>
	internal class IHyperGeometric
	{
	}
}
