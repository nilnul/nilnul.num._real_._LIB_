using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co
{
	public interface BandDblI:nilnul.obj.co.BandI<double, nilnul.num.real.CoDbl>
	{
	}

	public abstract class BandDblA:
		nilnul.obj.co.BandOnCombineA<double, CoDbl>
		,
		BandDblI
	{

	}
}
