namespace nilnul.num.real.bi_
{
	/// <summary>
	/// like spend money, or expend
	/// </summary>
	/// <remarks>
	/// for matrix, A/B = A * B^-1, while A\B = A^-1 * B. This justifies the differentiality of this and <see cref="bi_._PerX"/>
	/// </remarks>
	/// alias:
	///		sever
	///		tear
	///		split
	///		break
	///		share
	///		portion
	///		slice
	///		quota, to get quotient
	///		ration
	///		divide
	///		use
	///		enjoy
	///		
	/// vs:
	///		<see cref="nilnul.num.re_._DivideX"/>
	static public class _QuotaX
	{
		public const char TOKEN = '\\';
		/// <summary>
		/// <see cref=""/>
		/// </summary>
		/// <param name="users">
		///divisor:
		/// each person to get a share of the total quota as the individual quota
		/// </param>
		/// <param name="resource">
		/// dividend: 
		/// the total quota
		/// </param>
		/// <returns>
		///
		/// </returns>
		static public double Quota(double users, double resource) {
			return resource / users;
		}
	}

}
