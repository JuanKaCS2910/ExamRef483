using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace WPF70483
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient
                .GetStringAsync("https://www.microsoft.com")
                .ConfigureAwait(false);
            var r = 1;
            //Ouput.Content = content;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient
                .GetStringAsync("https://www.microsoft.com")
                .ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream("temp.html",FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length).ConfigureAwait(false);
            }
        }
    }
}
