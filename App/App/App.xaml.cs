
using App.Views;
using App.Views.NavigationPage;
using App.Views.Notification;
using App.Views.PaginaCarousel;
using App.Views.PaginaEmAbas;
using App.Views.PaginaMaster;
using App.Views.RestFull;
using Xamarin.Forms;

namespace App
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      MainPage = new NavigationPage(new XNotificationView());
      //MainPage = new XCarouselPage(); Pagina em carousel
      //MainPage = new XAba01View(); Pagina em abas
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
