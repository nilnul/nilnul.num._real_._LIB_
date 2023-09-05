namespace nilnul.num.real.of_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _StdX
	{
		static public double _Standize_0anchor_1vessel(
			double anchor
			,
			double nonnilAsVessel
			,
			double x
		) {
			return _NormalizeX._Normalize_0nonnilAsVessel(
				nonnilAsVessel
				,
				_NeutralizeX._Drift_0anchor(anchor, x)
			);
		}
	}
}
