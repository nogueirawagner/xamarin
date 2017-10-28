using App.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace App.MapeamentoRelacional.TarefaDAL
{
  public class XTarefaDAL : XITarefaDAL
  {
    private SQLiteConnection _db;

    public XTarefaDAL(SQLiteConnection db) 
    {
      _db = DependencyService.Get<XIDatabase>().GetConnection();
      _db.CreateTable<Tarefa>();
    }

    public List<Tarefa> GetTarefas()
    {
      return _db.Table<Tarefa>().ToList();
    }

    public int Salvar(Tarefa pTarefa)
    {
      return _db.Insert(pTarefa);
    }

    public int Alterar(Tarefa pTarefa)
    {
      return _db.Update(pTarefa);
    }

    public int Excluir(Tarefa pTarefa)
    {
      return _db.Delete(pTarefa);
    }

    public Tarefa GetTarefaID(int pID)
    {
      return _db.Table<Tarefa>()
        .Where(s => s.ID == pID).SingleOrDefault();
    }

  }
}
