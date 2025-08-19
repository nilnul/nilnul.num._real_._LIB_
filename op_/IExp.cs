using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.op_
{
	/// <summary>
	/// x=> a^x, where a defaults to e
	/// a^x = e^(a ln(x)) 
	/// </summary>
	/// <see cref="real.bi_.pow_.IExPonent"/>
	/// 
	public interface IExp:IOp { }

	static public class _ExpX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Exp(double x) {
			return Math.Exp(x);
		}
	}



}
