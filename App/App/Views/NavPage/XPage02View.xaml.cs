using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views.NavPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XPage02View : ContentPage
	{
		public XPage02View ()
		{
			InitializeComponent ();
		}

    private void Button_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new XPage01View());

    }
  }
}