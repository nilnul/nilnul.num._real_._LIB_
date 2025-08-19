namespace nilnul.num._real_._current_
{
	/// <summary>
	/// guaranteed that the <see cref="_real_.current_"/> is always sorted|<see cref="num.quotient.clasp"/>|<see cref="num.quotient.co_.le"/>
	/// </summary>
	/// <remarks>
	/// the defaulted is true in that:
	///		-) the implementation knows well and can conveniently, at no cost more than the other alternative, returned a guranteed one;
	///		-) if it's sorted, for caller it can help save computation to determine whether it's sorted outside;
	///		-) if we really nedd to return unsorted, we can define another member named for example, _current, or currentUnsorted;
	/// </remarks>
	public interface IsGuaranteedSortI
	{
		bool beGuaranteedSort { get; }
	}

}
