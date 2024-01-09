using Microsoft.Win32;
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

namespace WPF_HW_251023
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Login_Click(object sender, RoutedEventArgs e)
		{
			string username = tbUsername.Text;
			string password = tbPassword.Password;

			if (username == "admin" && password == "password") {
				MessageBox.Show("Login successful!", "Authentication", MessageBoxButton.OK, MessageBoxImage.Information);
			} else {
				MessageBox.Show("Login failed!", "Authentication", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}