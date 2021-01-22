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
using SQLite;

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
			//TODO: Implement Adding the information of the form in the database
			//Requie: Click on Save button and inputs on the form
			//Modify: Create a transaction object with form's data
			//Effect: Add a new transaction object to the database

			string amount = amountInput.Text; //getting the string from the textbox
			float fAmount = float.Parse(amount, CultureInfo.InvariantCulture.NumberFormat); //converting the string into float
			string RadioType = "Expense";
			DateTime dateTime;
			if (datePicker.SelectedDate == null)
			{
				datePicker.SelectedDate = DateTime.Now;
				dateTime = (DateTime)datePicker.SelectedDate;
			}
			else
			{
				dateTime = (DateTime)datePicker.SelectedDate;
			}

			if ((bool)incomeRadio.IsChecked) 
			{
				RadioType = "Income";
			}
			Transaction transaction = new Transaction()
			{
				Amount = fAmount,
				Description = descriptionInput.Text,
				Type = RadioType,
				Date = dateTime
			};
			Console.WriteLine(transaction); //verify the proprities of the instance

			

			using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
			{
				connection.CreateTable<Transaction>();
				connection.Insert(transaction);
			}
			//TODO: Adding the transaction instance in a database
			Close();
		}
	}
}
