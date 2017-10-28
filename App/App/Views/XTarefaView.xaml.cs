
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XTarefaView : ContentPage
  {
    public XTarefaView()
    {
      InitializeComponent();
      BindingContext = new XTarefaViewModel();
    }
  }
}