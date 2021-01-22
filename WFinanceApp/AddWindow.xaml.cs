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

		private void save_Click(object sender, RoutedEventArgs e)
		{
			//TODO: Implement Adding the information of the form in the database
			Close();
		}
	}
}
