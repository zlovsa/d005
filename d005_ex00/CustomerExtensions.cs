using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d005_ex00
{
	static class CustomerExtensions
	{
		public static CashRegister MinCustomers(this List<CashRegister> cashRegisters) {
			var sorted = cashRegisters.OrderBy(cashreg => cashreg.Customers.Count);
			if (sorted.Any())
				return sorted.ElementAt(0);
			else
				return null;
		}

		public static CashRegister MinTotalGoods(this List<CashRegister> cashRegisters) {
			var sorted = cashRegisters.OrderBy(cashreg => cashreg.Customers.Sum(cust => cust.BasketSize));
			if (sorted.Any())
				return sorted.ElementAt(0);
			else
				return null;
		}

	}
}
