using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.pred_
{
	/// <summary>
	/// during the solving of this, <see cref="pred_.IUnEquatation"/> might be involved. eg:
	///		x/y =1
	///		, to:
	///			x=y & y!=0, which is <see cref="pred_.ISimulty"/>
	/// So this is better placed under <see cref="real.pred_"/>, not directly under <see cref="num.real"/> as equatation.
	/// </summary>
	/// alias:
	///		equat: equal quantity
	public interface IEquatation:real.IPred
    {
    }



}
