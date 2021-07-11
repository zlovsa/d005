using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d005_ex00
{
	class Customer {
		public int BasketSize { get; protected set; } = 0;
		public string Name { get; protected set; }
		public int Num { get; protected set; }
		public Customer(string Name, int Num) {
			this.Name = Name;
			this.Num = Num;
		}

		public override string ToString() => $"Name={Name}, Num={Num}";

		public override bool Equals(object obj) => obj is Customer customer && this == customer;

		public static bool operator ==(Customer l, Customer r) => l.Name == r.Name && l.Num == r.Num;

		public static bool operator !=(Customer l, Customer r) => !(l == r);

		public override int GetHashCode() => Tuple.Create(Name, Num).GetHashCode();

		public void FillCart(int MaxBasketCapacity) {
			var rand = new Random();
			BasketSize = rand.Next(MaxBasketCapacity) + 1;
		}

	}
}
