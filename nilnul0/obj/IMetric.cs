using System;

namespace nilnul.obj
{
	/// <summary>
	/// such as length, area, unit. a measure on a set is a systematic way to assign a number to each suitable subset of that set, intuitively interpreted as its size. In this sense, a measure is a generalization of the concepts of length, area, and volume
	/// </summary>
	/// <remarks>
	/// <see cref="obj.IMeasure"/>
	/// 
	/// </remarks>
	/// nomenclature:
	///		in metric system, acceleration, displace can be negative
	///
	/// alias:
	///		offset
	///		deviation
	///		magnitude
	///		metric
	///		signed measure
	///		spectr
	///		spectral
	///		stokes
	///		divergence
	///		egress
	///		digression
	///		divergence
	///		indicator
	///		benchmark
	///		veering
	///

	[Obsolete(
		@"For signed measure, see nilnul.collection.family_.ring_.sigma.IDiscern which is difference between two measures in nilnul._collection_;
for comparing only, nilnul.relation_.ITally or nilnul.obj.ITally in prj: nilnul._collection_ shallbe used, as this is used for comparing, not enough yet as a measure; "
)]
	public interface IMetric:measure.ISigned{ }


}
