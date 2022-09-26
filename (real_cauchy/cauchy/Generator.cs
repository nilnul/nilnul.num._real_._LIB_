using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach
{
	/// <summary>
	/// /// In mathematics, real is defined as the collection of all that converges to the same limit.
	/// Here we define Real as a generator of convergens; by this definition, two of our Reals might converge the same, thus are the same mathematical real number.
	/// Note: two instance of the same type of generator may be different real numbers. So type cannot determine the equation.
	/// <see cref="nameof(nilnul.num.quotient.stream_.convergent.SedI)"/>
	/// 
	/// </summary>
	public interface GeneratorI
	{
		ApproachI1 generate();

	}

	public static class GeneratorX
	{
		static public int Sign(this GeneratorI generator) {
			return nilnul.num._real.approach.SignOfLimit.Eval(generator.generate());
		}

	}
}
