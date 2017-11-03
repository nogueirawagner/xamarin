using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XWebView : ContentPage
  {
    public XWebView()
    {
      InitializeComponent();

      var paginaHtml = new HtmlWebViewSource();
      paginaHtml.Html = @"
          <html>
            <body>
              <span>Está é uma web view local</span>
            </body>
          </html>";
      
      var paginaWeb = new UrlWebViewSource();
      paginaWeb.Url = "https://www.xamarin.com/";

      webView.Source = paginaWeb;
    }
  }
}