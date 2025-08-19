namespace nilnul.num.real.bi_
{
	///en.wikipedia.org/wiki/Deviation_(statistics)
	///In mathematics and statistics, deviation serves as a measure to quantify the disparity between an observed value of a variable and another designated value, frequently the mean of that variable.
	/// <summary>
	/// <see cref="geometry.linear.grad.IMetric"/>; signed length
	/// deviation;
	/// 
	/// </summary>
	/// alias:
	///		displace
	///			,like distance
	///			, in 2d, displace is better termed as vector.
	///		diversion
	///		dispersion
	///		departure, but <see cref="real.vec.IDeparture"/> which is nonneg
	///		stray
	///		drift
	///		difference, but this in git means -a+b
	///		diverge
	///		delta
	///		deviate
	///
	static public class _DisplaceX
	{
		static public double Displace(double x, double y) {
			return y - x;
		}
	}


}
