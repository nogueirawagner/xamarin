using SQLite;

namespace App.MapeamentoRelacional
{
  public interface XIDatabase
  {
    SQLiteConnection GetConnection();
  }
}
