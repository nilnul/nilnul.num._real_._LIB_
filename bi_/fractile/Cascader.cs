using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary_.fractile
{

	/// <summary>
	/// eg for 1,2,3,4
	///		we would get
	///			2+1/1
	///			
	///			3+	1
	///				__________
	///				2+1/1
	///				
	///			4+	1
	///				----------
	///				3 + 1
	///					------
	///					2+1/1
	/// </summary>
	public class Cascader
		:
		num.real.of_.binary.cascader_.Op8default4dbl<Fractile>

	{

	

		static public Cascader Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Cascader>.Unison;
			}
		}

	}
}
