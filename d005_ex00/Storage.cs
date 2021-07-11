using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d005_ex00
{
	class Storage
	{
		public int GoodsCount { get; protected set; }
		public Storage(int n) {
			GoodsCount = n;
		}

		public bool IsEmpty() => GoodsCount == 0;
		public void FillCart(Customer cust, int MaxBasketSize) {
			cust.FillCart(Math.Min(GoodsCount, MaxBasketSize));
			GoodsCount -= cust.BasketSize;
		}
	}
}
