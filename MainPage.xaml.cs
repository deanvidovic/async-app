using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace async_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }



        private void equal_btn_Click(object sender, RoutedEventArgs e)
        {
            int first_number = Int16.Parse(first_num.Text);
            int second_number = Int16.Parse(second_num.Text);
            int sum = 0;

            sum = first_number + second_number;

            equal_text.Text = sum.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            faktorijela_no_async.Text = (Suma()).ToString();
        }


        private long Suma() 
        {
            long n = 1000000000;
            long[] polje = new long[n];

            for (int i = 1; i < n; i++)
                polje[i] = i;

            long s = 0;
            for (int i = 0; i < n; i++)
            {
                s += polje[i];
            }

            return s;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            faktorijela_async.Text = (await Task.Run(() => Suma())).ToString();
        }
    }
}
