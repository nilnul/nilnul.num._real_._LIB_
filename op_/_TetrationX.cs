using System;

namespace nilnul.num.real.op_
{
	static public class _TetrationX
	{
		/// <summary>
		/// eg:
		///		(2,0) =1
		///		(2,1) =2
		///		(2,2) =4
		///		(2,3) =16
		///		(2,4) =65536
		/// </summary>
		/// <param name="basis"></param>
		/// <param name="reapply"></param>
		/// <returns></returns>
		static public double _Tetration_1num(double basis, int reapply) {
			if (reapply==0)
			{
				return 1;
				//return Math.Pow(basis, 0);
			}
			return Math.Pow(
				basis
				,
				_Tetration_1num(basis, --reapply)
			);
		}
	}
}
