using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._metric
{
	public interface IMark1
	{
	}
	/// <summary>
	/// in difference with _measure.Unit,
	///		the unit in metric may not share the same origin. For example, 0celsiu is not 0fahrenheit.
	///		the unit in metric may be disproportionate. for example, dolby sound intensification, or cancleLight of lucency.
	///	so the conversion is totally cusom
	/// 
	/// </summary>
	public interface MarkI1 :
		IMark1
	{
	}

	
}
