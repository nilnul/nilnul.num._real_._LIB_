using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn.src.be_
{
	/// <summary>
	/// if it's both <see cref="_contin.semi_.ILeftContinuous"/> and <see cref="_contin.semi_.IRightContinuous"/>
	/// </summary>
    public interface IContinuous
		:
		_contin.semi_.ILeftContinuous
		,
		_contin.semi_.IRightContinuous
		,
		concil_.INonbreak
    {
    }


}
