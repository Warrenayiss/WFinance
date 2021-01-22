using System;
using System.Collections.Generic;
using System.Text;

namespace WFinanceApp.Classes
{
	class Transaction
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public float Amount { get; set; }
		public string Date { get; set; }

		public override string ToString()
		{
			return $"{Description}  - {Amount}  - {Date} -  {Type}";
		}
	}
}
