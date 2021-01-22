using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WFinanceApp.Classes;

namespace WFinanceApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			//TODO: Read the list of transactions in the database 
			//TODO: Sort the list by date
			//TODO: Select element of the list to open the edit window

			//list for testing
			List<Transaction> transactions = new List<Transaction>()
			{
				new Transaction() {Id=0,Description="azerty",Amount=125f,Date="12-10-2020",Type="Expense"},
				new Transaction() {Id=0,Description="azerty",Amount=125f,Date="5-12-2020",Type="Expense"},
				new Transaction() {Id=0,Description="azerty",Amount=125f,Date="21-12-2020",Type="Expense"}
			};

			transactionsList.ItemsSource = transactions;
		}

		private void AddBtn_Click(object sender, RoutedEventArgs e)
		{
			AddWindow window = new AddWindow();
			window.ShowDialog();
		}
	}
}
