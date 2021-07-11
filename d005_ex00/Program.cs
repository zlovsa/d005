using d005_ex00;
using System;
using System.Collections.Generic;
using System.Linq;

var customer1 = new Customer("Andrew", 1);
var customer2 = new Customer("Andrew", 1);

Console.WriteLine($"customer1: {customer1}");
Console.WriteLine($"customer2: {customer2}");
Console.WriteLine($"customer1 == customer2 : {customer1 == customer2}");
Console.WriteLine();

void Show(bool custs) {
	var names = "John,Jim,Tom,Tim,Alice,Bob,Jack,Alice,Anna,Maria".Split(',');
	Store store = new(40, 3);
	int custIdx = 0;
	Console.WriteLine(store.IsOpen());
	while (store.IsOpen() && custIdx < names.Length) {
		var cust = new Customer(names[custIdx], custIdx + 1);
		store.storage.FillCart(cust, 7);
		var cashreg = custs ? store.CashRegisters.MinCustomers() : store.CashRegisters.MinTotalGoods();
		cashreg.Customers.Enqueue(cust);
		Console.WriteLine($"{cust}, goods in basket: {cust.BasketSize}, cash register: {cashreg}"
			+ $", customers count: {cashreg.Customers.Count}"
			+ $", total goods count: {cashreg.Customers.Sum(cust => cust.BasketSize)}");
		custIdx++;
	}
}

Console.WriteLine("Min Customers:");
Show(true);
Console.WriteLine();

Console.WriteLine("Min Total Goods:");
Show(false);
