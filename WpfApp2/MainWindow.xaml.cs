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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void showArray(int[] arr)
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++)
                result += arr[i].ToString() + " ";
            MessageBox.Show(result);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IMyCollection test = new MyArray();
            test = new SortArrayDESC(test);
            int[] buffer = test.ReturnArray();
            showArray(buffer);
        }
    }
}
