namespace nilnul.num.real.re_
{
	/// <summary>
	/// a compatible relation, which by definition is reflexive and symmetric, but not necessarily transitive.
	/// </summary>
	/// <remarks>
	/// defaulted to <see cref="re_.approx_.Ratio1"/>;
	///  for absolute distance, just use <see cref="INear"/>.
	/// </remarks>
	///

	public interface IApproximate:nilnul.num.real.IRe,nilnul.obj.re_.ICompatible{ }

}
