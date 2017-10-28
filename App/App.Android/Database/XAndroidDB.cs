
using App.Droid.Database;
using App.MapeamentoRelacional;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(XAndroidDB))]
namespace App.Droid.Database
{
  public class XAndroidDB : XIDatabase
  {
    public SQLiteConnection GetConnection()
    {
      var nomedb = "app.db3";
      var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      var path = Path.Combine(folder, nomedb);

      return new SQLiteConnection(path);
    }
  }
}