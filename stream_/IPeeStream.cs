namespace nilnul.num.real.stream_
{
	/// <summary>
	/// eg:
	///		1/1^p, 1/2^p, 1/3^p.
	///	Note this is not <see cref="stream_.pee.ISeries"/>, which is the sum of the terms;
	/// </summary>
	public interface IPeeStream { }

	public interface PeeStreamI:IPeeStream {
		/// <summary>
		/// a negative, zero, or positive number.
		/// eg:
		///		1/ 1^-x, 1/2^-x, 1/3^-x, ...
		///		which is equivalent to: 1^x, 2^x, 3^x
		/// </summary>
		nilnul.num.RealI1 pee { get; }
	}
}
