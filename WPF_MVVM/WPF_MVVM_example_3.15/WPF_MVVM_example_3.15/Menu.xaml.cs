﻿using System;
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

namespace WPF_MVVM_example_3._15
{
	/// <summary>
	/// Menu.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class Menu : Page
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Email_Support_Click(object sender, RoutedEventArgs e)
		{
			// Email Supprot Button Click 시 Contact.xaml 페이지로 이동
			NavigationService.Navigate(
				new Uri("/Contact.xaml", UriKind.Relative)
				);
		}

		private void Live_Support_Click(object sender, RoutedEventArgs e)
		{
			// Live Supprot Button Click 시 Discussion.xaml 페이지로 이동
			NavigationService.Navigate(
				new Uri("/Discussion.xaml", UriKind.Relative)
				);
		}
	}
}
