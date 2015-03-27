using System.Windows.Input;
using MahApps.Metro.Controls;

namespace NDExpressWPF_Beta_1._0._1.SystemManager
{
    /// <summary>
    ///     Interaction logic for NewClient.xaml
    /// </summary>
    public partial class NewClient : MetroWindow
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void Image_TouchEnter(object sender, TouchEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}