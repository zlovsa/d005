using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d005_ex00
{
	class CashRegister
	{
		public string Name { get; protected set; }
		public CashRegister(string Name) {
			this.Name = Name;
		}

		public override string ToString() => $"CashRegister {Name}";

		public override bool Equals(object obj) => obj is CashRegister cashregister && this == cashregister;

		public static bool operator ==(CashRegister l, CashRegister r) => l.Name == r.Name;

		public static bool operator !=(CashRegister l, CashRegister r) => !(l == r);

		public override int GetHashCode() => Name.GetHashCode();

		public Queue<Customer> Customers = new();
	}
}
