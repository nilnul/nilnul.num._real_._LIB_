using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._metric_
{
	/// <summary>
	/// such as length, area, unit. a measure on a set is a systematic way to assign a number to each suitable subset of that set, intuitively interpreted as its size. In this sense, a measure is a generalization of the concepts of length, area, and volume
	/// </summary>
	public interface Quantity4dblI
	{
		double quantity { get; }
	}
}
