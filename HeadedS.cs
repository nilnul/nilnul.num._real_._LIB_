using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class HeadedS_ofDouble:nilnul.collection.HeadedS<double>
	{

		public HeadedS_ofDouble(double head, IEnumerable<double> tail)
			:base(head,tail)
		{

		}

	}
}
