using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary_.fractile.converse.cascader
{

	/// <summary>
	/// eg for 1,2,3,4
	///		we would first reverse it to: 4,3,2,1
	///		
	///		we would get
	///			1/4+3
	///
	///			1
	///			------  +2
	///			1/4 +3
	///
	///			1
	///			--------------------- +1
	///			1
	///			------  +2
	///			1/4 +3
	///		
	///				
	/// </summary>
	public class Reverse1st
		:
		//num.real.str_.started.to_.Scala4dblI
		//,
		obj.str_.started._cascade_._AssumeStartedI<double>
	{

	

		static public Cascader Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Cascader>.Unison;
			}
		}

		public double _cascade_0started(IEnumerable<double> started)
		{
			return fractile.converse.Cascader.Unison._cascade_0started(started.Reverse());
		}
	}
}
