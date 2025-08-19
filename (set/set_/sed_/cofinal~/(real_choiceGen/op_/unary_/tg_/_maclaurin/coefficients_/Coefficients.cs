using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q0 = nilnul.num.Quotient1;
using System.Numerics;

namespace nilnul.num.real.op_.unary_.tg_._maclaurin.coefficients_
{
	/// <summary>
	/// (-1) ^ n * 2^(2n+2) * (2^ (2n+2) -1) / (2n+2)! * B[2n+2] * x^(2n+1)
	/// </summary>
	public class Cumulative
		: nilnul.num.quotient.SliderI2	//2
	{

		private List<Q0> _up2current=new List<Q0>() { 1};

		public Cumulative()
		{
			

		}

		public Q0 current
		{
			get
			{
				return _up2current.Last();
			}
		}
		//private Q1 x;



		public void moveNext()
		{
			var c = _up2current.Count;
			_up2current.Add(
				nilnul.num.quotient.accumulate_._SumX.Sum(
					_up2current.Select(
						(ele,index)=> _up2current[index]*_up2current[c-1-index]
					)
				)
				/(2*c+1)
			);

		}
	}
}
