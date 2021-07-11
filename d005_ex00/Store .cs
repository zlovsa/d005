using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d005_ex00
{
	class Store
	{
		public Storage storage { get; }
		public List<CashRegister> CashRegisters { get; protected set; } = new();

		public Store(int StorageCapacity, int CashRegistersCount) {
			storage = new Storage(StorageCapacity);
			for (int i = 1; i <= CashRegistersCount; i++)
				CashRegisters.Add(new CashRegister(i.ToString()));
		}

		public bool IsOpen() => !storage.IsEmpty();
	}
}
