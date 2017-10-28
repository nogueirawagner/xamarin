using SQLite;
using System;

namespace App.Models
{
  public class Tarefa
  {
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public String Nome { get; set; }
    public Boolean Concluido { get; set; }
  }
}
