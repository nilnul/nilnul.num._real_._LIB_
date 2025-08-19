namespace nilnul.num.real.xt_
{
	/// <summary>
	/// it's not <see cref="xt_.IFinite"/>; so it includes both <see cref="inf_.Neg"/> or <see cref="inf_.Pos"/>
	/// </summary>
	/// <remarks>
	/// positive infinite is imagined as a point upper to the real axis, and negative infinity is imagined as a point under the real axis.
	/// This is better than regarding positive infinity as a point at the right endpoint of the real axis, as it's not continuous at the lower side, in that we cannot find any other xt(except the posInf) that is closer than a given magnitude (<see cref="nilnul.obj._measure._unit_.MagnitudeI"/>). Analogously, negative infinity is not regarded as a point at the left endpoint of the real axis.
	/// This perspective's advantage is more obvious when we consider the complex plane, where the upperInfinity is regarded as a point on the upper side of the complex plane, along an axis (generally denoted as "z" the 3rd axis) perpendicular to the complex axis, and the lowerInfinity is regarded as a point on the lower side of the complex plane, as on complex plane, it's 2d and there is no suitable point on the complex plane to represent the infinity. In fact the infinity shall be regarded as the side(front/back or positive/negative) that is enclosed by an infinite boundary. <see cref="nilnul.num.complex.xt"/> for more;
	/// </remarks>
	/// alias:
	///		unFinite
	///		nonfinite
	///		transfinite
	public interface IInfinite :IXt{ }

}
