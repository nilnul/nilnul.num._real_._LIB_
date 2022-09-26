
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.var.str_.sans0Started_
{
	public interface StartedI:real.var.StrI
	{

	}


	public class Started
		:


		nilnul.obj.str_.sans0Started_.Started<nilnul.num.real.VarI,nilnul.num.real.var.str_.Sans0StartedI>
		,
		StartedI
	{

		

		public Started(nilnul.num.real.VarI head, real.var.str_.Sans0StartedI tail):base(head,tail)
		{

		}


		public Started(nilnul.num.real.VarI head):this(head,  Sans.Singleton)
		{

		}

	}



}
