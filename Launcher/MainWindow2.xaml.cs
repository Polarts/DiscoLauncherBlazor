using Microsoft.AspNetCore.Components.WebView;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
using System.Windows.Shapes;

namespace Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorWebViewDeveloperTools();
            Resources.Add("services", serviceCollection.BuildServiceProvider());

            MainWebView.BlazorWebViewInitialized += WebViewInitialzed;
        }

        private void WebViewInitialzed(object? sender, BlazorWebViewInitializedEventArgs e)
        {
            e.WebView.DefaultBackgroundColor = System.Drawing.Color.Transparent;
        }
    }
}
