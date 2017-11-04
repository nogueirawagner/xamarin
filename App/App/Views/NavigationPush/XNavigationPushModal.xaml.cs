using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views.NavigationPush
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XNavigationPushModal : ContentPage
  {
    public XNavigationPushModal()
    {
      InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new XPage01View());
    }

    private void Button_Modal(object sender, EventArgs e)
    {
      Navigation.PushModalAsync(new XPage01View());
    }
  }
}