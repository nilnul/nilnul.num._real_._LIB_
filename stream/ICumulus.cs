namespace nilnul.num.real.stream
{
	/// <summary>
	/// augment the <see cref="nilnul.obj.str.ITop"/>|<see cref="nilnul.obj.stream.Take{T}"/> one by one, and for each str we apply an accumulate function such as sum.
	/// </summary>
	/// <remarks>
	/// note the order is present, and cannot be changed, otherwise, the result would change; eg:
	///		1-1+1-1+1
	///		is not:
	///			1+1+1 -1-1-1 +1+1+1 -1-1-1 +...
	/// </remarks>
	/// alias:
	///		cumuli
	public interface ICumulus
		:num.real.stream_.ISlider
	{ }


}
