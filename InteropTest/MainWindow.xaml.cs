using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
using InteropTest.Adapter;

namespace InteropTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var ptr = MyAdapter.GetMyVersionPtr();
            var convertedString = Marshal.PtrToStringAnsi(ptr);

            // This crashes in x64 build
            var directString = MyAdapter.GetMyVersionString();
            
            VersionTextBlock.Text = convertedString;
        }
    }
}
