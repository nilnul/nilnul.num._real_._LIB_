using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// bounded stream
	/// </summary>
	public interface IBounded
	{
	}
	public interface BoundedI
		:IBounded
		,
		real.StreamI
		,
		_bounded_.BoundI

	{

	}
}
