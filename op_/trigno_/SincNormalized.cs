using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.trigno_
{

	/// <summary>
	/// sin(pi x) / (pi x), the normalized sinc by pi, not tau.
	/// </summary>
	/// alias:
	///		sync, where y replaces the "i" in sinc, and it sounds like the "i" in "pi"
	///		sinc (which is for unnormalized)
	public interface ISync:ITrigno { }
	/// <summary>
	/// make the integral =1;
	/// sin(pi x) / (pi x)
	/// ;
	/// </summary>
	/// <remarks>
	/// The normalized sinc function is the Fourier transform of the rectangular function with no scaling. 
	/// </remarks>
	static public class _SincNormalizedX
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double SincNormalized(double x) {
			return x == 0 ? 1 : _SincX.Sinc(x * Math.PI);
			return  _SincX.Sinc(x * Math.PI); /// where x=0 output 1.

		}
    }
}
