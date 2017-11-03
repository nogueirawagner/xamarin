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
	public partial class XRangeView : ContentPage
	{
		public XRangeView ()
		{
			InitializeComponent ();
		}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
      txtSlider.Text = e.NewValue.ToString();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
      txtStepper.Text = e.NewValue.ToString();
    }
  }
}