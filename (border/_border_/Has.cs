using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._border_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		fence
	///		guarded
	///		lower0upper
	/// </remarks>
	

	public interface HasDblI:nilnul.obj._collection_.ContainI<double> {
		//bool contain(double x);
	}

	public interface HasI:nilnul.num.real._collection_.ContainI {
		//bool contain(double x);
	}


}
