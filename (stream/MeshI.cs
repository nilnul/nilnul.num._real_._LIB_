using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// stream of streams
	/// </summary>
	public interface MeshI:nilnul.obj.StreamI1<
		nilnul.num.real.StreamI
	>
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public interface MeshI1
	{
		num.RealI this[nilnul.Num1 row, nilnul.Num1 col] { get; }	///row major. as write line by line, and the first line is the first seq from left to right.
	}

}
