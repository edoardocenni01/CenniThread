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

namespace thread
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart1_Click(object sender, RoutedEventArgs e)
        {
            Conta();
        }

        private void Conta()
        {
            for (int i = 0; i < 1000; i++)
            {
                AggiornaUI();

            }
        }

        private void AggiornaUI()
        {
            lblCount.Content = "Sto contando";
        }
    }
}
