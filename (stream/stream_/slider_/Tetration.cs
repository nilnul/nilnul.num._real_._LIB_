using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._stream;

using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_
{
	/// <summary>
	/// a :=1, x^1, x^x, x^(x^x), ....
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Tetration
		: nilnul.num.real.stream_.SliderA
	{


		private nilnul.num.real_.PositiveI _basis;

		public nilnul.num.real_.PositiveI basis
		{
			get { return _basis; }
			set { _basis = value; }
		}
		R _current;
		public override R current =>_current ;


		public Tetration(nilnul.num.real_.PositiveI basis)
		{
			_basis = basis;
			_current = new nilnul.num.real_.Quotient(1);
		}


		public override void moveNext()
		{
			_current= nilnul.num.real.co_.starT_.positive._PowX.RetRealI(_basis, _current) ;
		}

		

		
	}
}
/*
 	/// 关键在于把它表示成一个序列。
	/// 令 x[1] = x, x[k + 1] = x ^ x[k]
	/// 则 这个序列的极限就是你那个式子
	/// 至于这个序列什么条件下有极限？可以两边取极限算一下。结果是0<x<=1时收敛，1<x<e^(1/e)=1.445时震荡不收敛，x=e^(1/e)时收敛，x>e^(1/e)时发散。
	///
	///
	/// sqrt(2) ^ ....  =2 吧？
	///
	/// 写几行代码，运行结果，至少（0，1.4】收敛，根2收敛到2；然后e^（1/e）收敛缓慢，也许在临界点，截断误差影响了普通的计算。
	///
	/// 不用那么麻烦，构造函数列f_n(x)，对任意正数a，设f_n(a)收敛且极限为A，
	因为lnf_n(a)=f_{n-1}
(a) * lna，两边取极限得A* lna = lnA
设lna=k，即考虑kA=lnA是否有正数解的问题
	/// 
在0附近不会收敛，而是振荡的。没错，小于e^（-e）时，振荡，不收敛。
奇怪的函数。
 */
