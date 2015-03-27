using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using OriginX;
using NDExpressWPF_Beta_1._0._1.SystemManager;

namespace NDExpressWPF_Beta_1._0._1
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private async void revnuedetails_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("System Error  ", " Please Contact System Administrator for more details");
            new Login().Show();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ProgressDialogController ProgressDialogController = await this.ShowProgressAsync("Please wait...", "Progress message");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
        }

        private void GridSplitter_DragDelta(object sender, DragDeltaEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                var newdelivery = new deliverylinqDataContext();
                newdelivery.insertdelivery(delfrom.Text, deladd1.Text, deladd2.Text, deladd3.Text, delcity.Text,
                    delmob.Text, delto.Text, toadd1.Text, toadd2.Text, toadd3.Text, tocity.Text, tomob.Text,
                    deldescript.Text);
                await
                    this.ShowMessageAsync("Successful",
                        "Successfull added new delivery to the system, you can view current details from stock manager window.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                delfrom.Text = "";
                deladd1.Text = "";
                deladd2.Text = "";
                deladd3.Text = "";
                delcity.Text = "";
                delmob.Text = "";
                delto.Text = "";
                toadd1.Text = "";
                toadd2.Text = "";
                toadd3.Text = "";
                tocity.Text = "";
                tomob.Text = "";
                deldescript.Text = "";
            }
        }

        private void cleardelivery(object sender, RoutedEventArgs e)
        {
            var samployee = new deliverylinqDataContext();
            samployee.emap(deladd2.Text, deladd3.Text, deladd1.Text);
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                var addemployee = new deliverylinqDataContext();
                addemployee.addemployees(empname.Text, empnic.Text, empmob.Text, empaddress.Text, empbasicsalary.Text,
                    empposition.Text);
                await
                    this.ShowMessageAsync("Congratulations !",
                        "Successfull recruit new employee to the company, you can view current details from the panel.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                empname.Text = "";
                empnic.Text = "";
                empmob.Text = "";
                empaddress.Text = "";
                empbasicsalary.Text = "";
                empposition.Text = "";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            new NewClient().Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            new ViewClients().Show();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
        }

        private void loadempdata_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}