using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.eg_
{
	/// <summary>
	/// per probability, days in year is an irrational number:
	///		365.24....
	/// </summary>
	/// <remarks>
	///	; But we cannot let a single day span in two years;
	///	So it's written in a series:
	///		365 + 1/4 - 1/100 + 1/400 - ...
	///		,hence we have 1 leap year (29 days, not 28 days in February) every four years, but not at a year that is a multiplier of 100, but every 400 years we readd that day back again, and for the remained case, we only encounter that in thousands of years, hence it's not problem today, and will be deferred .
	///
	/// </remarks>
    class DaysInYear
    {
    }
}
