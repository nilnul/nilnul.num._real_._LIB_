using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach
{
	/// <summary>
	/// create this type from other types that are already established.
	/// </summary>
	public interface ConstructI
	{
	}

	public interface ConstructI<T> : ConstructI {
		nilnul.num._real.ApproachI1 construct(T precedent);
	}
}
