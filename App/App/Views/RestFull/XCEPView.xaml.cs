using App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views.RestFull
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XCEPView : ContentPage
  {
    public XCEPView()
    {
      InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
      if (txtCEP.Text != null && txtCEP.Text.Length == 8)
      {
        var cep = XServiceCEP.BuscaCEP(txtCEP.Text);
        txtResultado.Text = await cep;
        txtResultado.TextColor = Color.Black;
      }
      else
      {
        txtResultado.Text = "CEP inválido.";
        txtResultado.TextColor = Color.Red;
      }
    }
  }
}