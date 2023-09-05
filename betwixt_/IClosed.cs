namespace nilnul.num.real.betwixt_
{
	/// <summary>
	/// both border are closed;
	/// </summary>
	/// alias:
	///		clasp
	///			:similar to closed
	///			:as this always has member, it's used often and a reserved word is needed.
	///				whileas <see cref="bound_.IClosed"/> is reserved for <see cref="IBound"/>
	///		clamp
	///			<see cref="System.Math.Clamp"/>
	///			to clamp, we don't need to consider the direction of the clamp, so it can be [2,4] or [4,2] and that doesnot make much difference;
	///			
	public interface IClosed
		:IBetwixt
	{ }
}
