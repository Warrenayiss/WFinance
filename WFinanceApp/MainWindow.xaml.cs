using SQLite;
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
			ReadDatabase();
			
		}

		void ReadDatabase()
		{
			//require: connection to database
			//modify: attribute a Source to the listView
			//Effect: connect the Transaction Table to the listView
			using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
			{
				connection.CreateTable<Transaction>();
				var transaction = connection.Table<Transaction>().ToList();

				if (transaction != null)
				{
					transaction = transaction.OrderByDescending(o => o.Date).ToList(); //UNDONE: hide the hours and minutes part of Date
					transactionsList.ItemsSource = transaction;
				}
			}
		}

		private void AddBtn_Click(object sender, RoutedEventArgs e)
		{
			//require: click on button
			//modify: create AddWindow
			//effect: show AddWindow
			AddWindow window = new AddWindow();
			window.ShowDialog();
			ReadDatabase();
		}

		private void transactionsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//Require: click on listView element
			//modify: create TransactionDetailsWindow
			//effect: show TransactionDetailsWindow with selected element sent
			Transaction selectedTransaction = (Transaction)transactionsList.SelectedItem;
			if (selectedTransaction != null)
			{
				TransactionDetailsWindow window = new TransactionDetailsWindow(selectedTransaction);
				window.ShowDialog();
			}
			ReadDatabase();
		}
	}
}
