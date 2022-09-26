using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.sortie
{
	static public class _FindX
	{
		static public (int?, int?) _IndexRange(List<double> _list_sortie, double el) {
			var index=_list_sortie.BinarySearch(el);
			if (index>=0)
			{
				return(
					 index,index
				);
			}

			var largerIndex = ~index;

			if (largerIndex >= _list_sortie.Count)
			{
				return (_list_sortie.Count-1 , null);
			}
			if (largerIndex ==0)
			{
				return (null, 0);
			}
			return (largerIndex - 1, largerIndex);
		}

		static public (int?, int?) _IndexRange(IEnumerable<double> _list_sortie, double el) {
			
			return nilnul.obj.sortie._FindX._IndexRange(_list_sortie,el, nilnul.num.real.ComparerDbl.Singleton);
		}

	}
}
