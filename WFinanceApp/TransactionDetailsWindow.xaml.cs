using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
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
	/// Logique d'interaction pour TransactionDetailsWindow.xaml
	/// </summary>
	public partial class TransactionDetailsWindow : Window
	{
		Transaction transaction;
		public TransactionDetailsWindow(Transaction transaction)
		{
			InitializeComponent();

			this.transaction = transaction;
			descriptionInput.Text = transaction.Description;
			amountInput.Text = transaction.Amount.ToString();

		}

		public float AmountTrans(string value)
		{
			return float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);
		}

		private void UpdateBtn_Click(object sender, RoutedEventArgs e)
		{
			//TODO: Implement the update function
			//Require: click on update button
			//Modify: Close the window
			//Effect: Change the values of the selected transaction in the database
			transaction.Description = descriptionInput.Text;
			transaction.Amount = AmountTrans(amountInput.Text);
			transaction.Date = transaction.Date;

			using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasePath))
			{
				connection.CreateTable<Transaction>();
				connection.Update(transaction);
			}
			Close();
		}

		private void DeleteBtn_Click(object sender, RoutedEventArgs e)
		{
			//TODO: Implement the delete function
			//Require: click on delete button
			//Modify: Close the window
			//Effect: Delete element of the database
			using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.databasePath))
			{
				connection.CreateTable<Transaction>();
				connection.Delete(transaction);
			}
			Close();
		}
	}
}
