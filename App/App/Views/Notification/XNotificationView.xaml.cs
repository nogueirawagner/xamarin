using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views.Notification
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XNotificationView : ContentPage
	{
		public XNotificationView ()
		{
			InitializeComponent ();
		}

    private async void Button_Clicked(object sender, EventArgs e)
    {
      var resposta = await DisplayAlert("Alerta", "Oi vc está doido", "Aceita", "Cancela");
      if (resposta)
        await DisplayAlert("Ta bom", "Voce é doido", "X");
      else
        await DisplayAlert("Ta bom", "Voce não é doido", "X");

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
      var resultado = await DisplayActionSheet("Qual sua linguagem prefereida", "Cancelar", "X", "c#", "c", "node");
      lblResultado.Text = resultado;
    }
  }
}