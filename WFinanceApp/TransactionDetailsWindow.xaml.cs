using System;
using System.Collections.Generic;
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
		}

		private void UpdateBtn_Click(object sender, RoutedEventArgs e)
		{
			//TODO: Implement the update function
			//Require: click on update button
			//Modify: Close the window
			//Effect: Change the values of the selected transaction in the database
		}

		private void DeleteBtn_Click(object sender, RoutedEventArgs e)
		{
			//TODO: Implement the delete function
			//Require: click on delete button
			//Modify: Close the window
			//Effect: Delete element of the database
		}
	}
}
