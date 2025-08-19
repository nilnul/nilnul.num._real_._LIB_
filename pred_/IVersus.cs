namespace nilnul.num.real.pred_
{
	/// <summary>
	/// =, !=, gt, ge, lt, le.
	/// that is:
	///		the sign of (x-y): {-1,0,1}, which is then transformed to powset { {0:eq}, {-1: lt}, {1: gt}, {-1,0: le}, {-1,1: ne}, {0,1: ge}, {-1,0,1: trivia}, {:paradox}  }
	/// </summary>
	/// alias:
	///		comparison
	///		signature map
	public interface IVersus:real.IPred
    {
    }


}
