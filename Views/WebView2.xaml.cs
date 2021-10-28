﻿using Crawler.Model;
using Microsoft.Web.WebView2.Core;
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

namespace Crawler.Views
{
    /// <summary>
    /// WebView2.xaml 的交互逻辑
    /// </summary>
    public partial class WebView2 : Window
    {
        public WebView2Struct _webView2Struct = new WebView2Struct();

        public WebView2()
        {
            InitializeComponent();
            webView.Source = _webView2Struct.Source;
        }

        private async void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            object i = await webView.CoreWebView2.ExecuteScriptAsync("document.getElementsByTagName('img').length");
            int total = int.Parse(i.ToString());
            for (int num = 0; num < total; num++)
            {
                //获取图片链接
                object o = await webView.CoreWebView2.ExecuteScriptAsync($"document.getElementsByTagName(\'img\').item({num}).src");
                HtmlSource.Text += o.ToString() + "\n";
            }


            
        }
    }
}