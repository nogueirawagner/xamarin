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
	public partial class XSwitchView : ContentPage
	{
		public XSwitchView ()
		{
			InitializeComponent ();
		}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
      txtSwitch.Text = e.Value.ToString();

    }
  }
}