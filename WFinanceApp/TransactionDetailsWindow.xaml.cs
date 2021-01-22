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

		}

		private void DeleteBtn_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
