using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection_
{
	/// <summary>
	/// a collection of objectS that has the same cardinality as the collection of numbers.
	/// </summary>
	public interface ContinuumI<T,TEq>
		:nilnul.obj._collection_.ContainI<T>
	{
		// bool contains(T obj);

		/// <summary>
		/// if contains.
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		T this[nilnul.num.RealI real] { get; }

		/// <summary>
		/// if contains
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		nilnul.num.RealI indexOf(T obj);
	}


}
