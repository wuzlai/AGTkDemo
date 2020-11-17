using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CefNet.Avalonia;
using System.Collections.Generic;

namespace AGTkDemo.Views
{
    public class MainWindow : Window
    {
        WebView webView;
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("btnFileOpen").Click += delegate
            {
                new OpenFileDialog()
                {
                    Title = "Open file"
                }.ShowAsync(GetWindow());
            };
        }

        Window GetWindow() => (Window)this.VisualRoot;
   
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            webView = this.FindControl<WebView>("webView");
            webView.InitialUrl = "https://cn.bing.com/?FORM=BEHPTB&ensearch=1" ;
        }
    }
}
