namespace nilnul.num.real
{
	/// <summary>
	/// like <see cref="nilnul.geometry.planar.IGrad"/>, this can be negatively oriented, erstwhile <see cref="nilnul.num.real.IBound"/> is always positively oriented.
	/// </summary>
	/// <remarks>
	/// used in nilnul.math.calculus;
	/// the range can be empty, where we use "+" or '-' to denote direction; eg: (1+, 1-), that means, from more than one (not including one) to less than one (not including one);
	/// </remarks>
	/// <see cref="nilnul.num.real.IBound"/>
	public interface  IBetwixt
		:nilnul.obj.IBetwixt<IReal> //emptible, can be in oppsite direction; 
	{
	}
}
