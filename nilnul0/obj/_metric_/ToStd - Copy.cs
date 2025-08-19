using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._metric_
{
	/// <summary>
	/// </summary>
	public interface ToStd4DblI
	{
		/// <summary>
		/// the conversion of different units is totally custom (not same nil but linear, not same proportion for example nonlinear), which is different from measure.
		/// </summary>
		/// <returns></returns>
		double toStd();
	}
}
