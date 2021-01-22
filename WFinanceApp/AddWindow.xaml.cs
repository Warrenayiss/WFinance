using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WFinanceApp.Classes;

namespace WFinanceApp
{
	/// <summary>
	/// Logique d'interaction pour AddWindow.xaml
	/// </summary>
	public partial class AddWindow : Window
	{
		public AddWindow()
		{
			InitializeComponent();
		}

		private void Save_Click(object sender, RoutedEventArgs e)
		{
			string amount = amountInput.Text;
			float fAmount = float.Parse(amount, CultureInfo.InvariantCulture.NumberFormat);
			string RadioType = "Expense";

			if ((bool)incomeRadio.IsChecked)
			{
				RadioType = "Income";
			}

				//TODO: Implement Adding the information of the form in the database
				Transaction trasaction = new Transaction()
			{
				Amount = fAmount,
				Description = descriptionInput.Text,
				Type = RadioType
			};
			Console.WriteLine(trasaction);
			Close();
		}
	}
}
