using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.op_._remainder_.by_
{
	/// <summary>
	/// </summary>
	/// <see cref="num.real_.floored._TailX.Doub(double)"/>
	/// 
	static public class _ByTruncateX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Obsolete(nameof(IBySubtractFloor) + " is more readable|understandable;")]
		static public double Floor(double x) {
			///learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators?devlangs=csharp&f1url=%3FappId%3DDev17IDEF1%26l%3DEN-US%26k%3Dk(%2525_CSharpKeyword)%3Bk(SolutionItemsProject)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%253Dv4.8.1)%3Bk(DevLang-csharp)%26rd%3Dtrue#remainder-operator-
			///
			/// x%1 is the truncate of the x /1.
			/// <seealso cref="of_.binary_.modulo_._RemainderX"/>

			if (x>=0)
			{
				return x % 1;
			}

			var t = (-x) % 1;

			if (t ==0)
			{
				return 0;
			}
			return 1-t;


			//return x>=0? x%1: 1- (-x)%1;  
		}
	}


}
