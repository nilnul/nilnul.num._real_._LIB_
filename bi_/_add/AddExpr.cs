using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul
{
	public partial class AddExpr
		: BinaryRealOpExprA
		, AddExprI
		
	{

		public AddExpr(ExprI<RealNumberI> a,ExprI<RealNumberI> b)
			:base(a,b)
		{

		}

		

		#region RealI Members

		public ExprI<RealNumberI> simplify()
		{
			ExprI<RealNumberI> l1 = left.Simplify();
			ExprI<RealNumberI> r1 = right.Simplify();



			#region decimal
			if (l1 is Real<decimal>)
			{
				Real<decimal> l2 = (Real<decimal>)l1;

				if (r1 is Real<decimal>)
				{
					Real<decimal> r2 = (Real<decimal>)r1;



					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<long>)
				{


					Real<long> r2 = (Real<long>)r1;


					return (l2.value + r2.value).ToReal();
				}
				else if (r1 is Real<ulong>)
				{
					Real<ulong> r2 = (Real<ulong>)r1;

					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<int>)
				{
					Real<int> r2 = (Real<int>)r1;

					return (l2.value + r2.value).ToReal();


				}

				else if (r1 is Real<uint>)
				{
					Real<uint> r2 = (Real<uint>)r1;
					return (l2.value + r2.value).ToReal();


				}

				else
				{
					return l2.Add(right);
				}

			} 
			#endregion

			#region long
			if (l1 is Real<long>)
			{
				Real<long> l2 = (Real<long>)l1;

				if (r1 is Real<decimal>)
				{
					Real<decimal> r2 = (Real<decimal>)r1;



					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<long>)
				{


					Real<long> r2 = (Real<long>)r1;


					return (l2.value + r2.value).ToReal();
				}
				else if (r1 is Real<ulong>)
				{
					Real<ulong> r2 = (Real<ulong>)r1;


					return r2.Add(
						(ExprI<RealNumberI>)l2
						);
					

				}

				else if (r1 is Real<int>)
				{
					Real<int> r2 = (Real<int>)r1;

					return (l2.value + r2.value).ToReal();


				}

				else if (r1 is Real<uint>)
				{
					Real<uint> r2 = (Real<uint>)r1;
					return (l2.value + r2.value).ToReal();


				}

				else
				{
					return l2.Add(right);
				}

			} 
			#endregion

			#region ulong
			if (l1 is Real<ulong>)
			{
				Real<ulong> l2 = (Real<ulong>)l1;

				if (r1 is Real<decimal>)
				{
					Real<decimal> r2 = (Real<decimal>)r1;



					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<long>)
				{


					Real<long> r2 = (Real<long>)r1;


					return r2.Add(
						(ExprI<RealNumberI>)l2
						);
				}
				else if (r1 is Real<ulong>)
				{
					Real<ulong> r2 = (Real<ulong>)r1;

					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<int>)
				{
					Real<int> r2 = (Real<int>)r1;

					return r2.Add(
						(ExprI<RealNumberI>)l2
						);


				}

				else if (r1 is Real<uint>)
				{
					Real<uint> r2 = (Real<uint>)r1;
					return (l2.value + r2.value).ToReal();


				}

				else
				{
					return l2.Add(right);
				}

			} 
			#endregion

			#region int
			if (l1 is Real<int>)
			{
				Real<int> l2 = (Real<int>)l1;

				if (r1 is Real<decimal>)
				{
					Real<decimal> r2 = (Real<decimal>)r1;



					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<long>)
				{


					Real<long> r2 = (Real<long>)r1;


					return (l2.value + r2.value).ToReal();
				}
				else if (r1 is Real<ulong>)
				{
					Real<ulong> r2 = (Real<ulong>)r1;

					return r2.Add(
						(ExprI<RealNumberI>)l2
						);

				}

				else if (r1 is Real<int>)
				{
					Real<int> r2 = (Real<int>)r1;

					return (l2.value + r2.value).ToReal();


				}

				else if (r1 is Real<uint>)
				{
					Real<uint> r2 = (Real<uint>)r1;
					return (l2.value + r2.value).ToReal();


				}

				else
				{
					return l2.Add(right);
				}

			} 
			#endregion

			#region uint
			if (l1 is Real<uint>)
			{
				Real<uint> l2 = (Real<uint>)l1;

				if (r1 is Real<decimal>)
				{
					Real<decimal> r2 = (Real<decimal>)r1;



					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<long>)
				{


					Real<long> r2 = (Real<long>)r1;


					return (l2.value + r2.value).ToReal();
				}
				else if (r1 is Real<ulong>)
				{
					Real<ulong> r2 = (Real<ulong>)r1;

					return (l2.value + r2.value).ToReal();

				}

				else if (r1 is Real<int>)
				{
					Real<int> r2 = (Real<int>)r1;

					return (l2.value + r2.value).ToReal();


				}

				else if (r1 is Real<uint>)
				{
					Real<uint> r2 = (Real<uint>)r1;
					return (l2.value + r2.value).ToReal();


				}

				else
				{
					return l2.Add(right);
				}

			}	 
			#endregion	


			
			else if (l1 is VariableI<RealNumberI>)
			{

				VariableI<RealNumberI> l2 = (VariableI<RealNumberI>)l1;
				if (r1 is VariableI<RealNumberI>)
				{
					VariableI<RealNumberI> r2=(VariableI<RealNumberI>)r1;

					if (l2.name==r2.name)
					{
						return new BinaryRealOpExpr(Multiply.Instance, (Real)2, r2);
					}
				}
				return this;
				
			}
				
			else
			{
				return l1.Add(r1);
			}
		
		}

		#endregion

		public override BinaryOpI<ExprI<RealNumberI>, ExprI<RealNumberI>, ExprI<RealNumberI>> op
		{
			get
			{
				return Add.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(nilnul.realNumber.ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
