﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace admin {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow a = new AdminWindow();
            a.Show();
            this.Close();
        }
	}
}
