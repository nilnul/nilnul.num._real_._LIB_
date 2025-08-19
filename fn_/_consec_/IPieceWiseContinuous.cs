using System;

namespace nilnul.num.real.fn_
{
	/// <summary>
	/// <see cref="consec_."/>
	/// </summary>
	/// <see cref="fn_.IConsecutive"/>
	///
	[Obsolete(nameof(fn_.IConsecutive))]
	public interface IPieceWiseContinuous
		:
		fn_.IConsecutive
		,

		real.IConvert,real.func_.IUnary{ }
}
