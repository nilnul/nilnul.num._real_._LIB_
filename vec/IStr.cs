using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec
{
	/// in using and processing matrix, we find it's better to keep this from matrix, as a matrix can be taken colwisely as a <see cref="IStr"/>, or rowwisely as another.
	/// <summary>
	/// matrix
	/// </summary>
	///
	//[Obsolete("place here lest any developer is tempted to do such; Dont use this-use:" +
	//	"nameof(real.IMatrix))"
	//	)
	//]  //due to the consufion, and after second thought, let make this not obsolete.
	public interface IStr
		:
		nilnul.obj.IStr<IVec>
		//nilnul.obj.vec.StrI
	{
	}
}
