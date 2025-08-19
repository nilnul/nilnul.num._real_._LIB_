using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.convergent_
{
	/// <summary>
	/// the limit of this is x.
	/// so sqrt(2)^x=x
	/// so sqrt(2) = x  ^ 1/x 
	/// so 2 ^ 1/2= x ^1/x.
	///		and the function x^1/2 is monotonic?
	///	so x=2;
	/// </summary>
	public class PowSqrtTwo
		: nilnul.num.real.SliderI

	{
		/// <summary>
		/// sqrt(2)
		/// </summary>
		public num.RealI3 current => throw new NotImplementedException();

		public void moveNext()
		{
			//current = current ^ sqrt(2);
			throw new NotImplementedException();
		}
	}

	/*
	 x^(x^ (x...))=2 ; get x.


	sln:
	let x:=sqrt(2) , and  a := x, x^x, x^(x^x), ....then a is bounded in that if a[n] <2, then a[n+1] = x^a[n] <2. also a is increasing monotonically.  So a has a limit.This limit cannot be 4, 'cuz 4 is over the upper bound.Is it 2?The limit is somewhere between (sqrt(2), 2).If you suppose it's two, then the video is right. but first You have to prove it's two; that's the missing part of the video.﻿ 
	 
	 */
}
