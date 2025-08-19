using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.convergent.co_.neighbor
{
	///
	///  for matrix:
	///		p   p'
	///		q   q'
	///	we have determinant:
	///		pq' - p'q
	/// <summary>
	/// the first such cross product is -1.
	/// that is:
	///		p0	p1
	///		q0  q1
	///		=
	///		a0  a0a1+1
	///		1	a1
	///		= -1
	///	for previous item where the index is -1:
	///		p[-1]   p0
	///		q[-1]   q0
	///		=
	///		1	p0
	///		0	1
	///		= 1
	///	for item[-2]
	///		0	1
	///		1   0
	///		= -1
	///	for index at n, n+1:
	///		(-1) ^ (n+1)
	/// </summary>
	internal class CrossProduct
	{
	}
}
