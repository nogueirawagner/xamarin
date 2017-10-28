using SQLite;

namespace App.DAL
{
  public interface XIDatabase
  {
    SQLiteConnection GetConnection();
  }
}
