using App.DAL.TarefaDAL;
using App.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace App.ViewModels
{
  public class XTarefaViewModel : INotifyPropertyChanged
  {
    public XITarefaDAL TarefaDAL { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    public Tarefa TarefaAtual { get; set; }
    public List<Tarefa> Tarefas { get; set; }
    public Command SalvarCommand { get; set; }

    public XTarefaViewModel()
    {
      TarefaDAL = new XTarefaDAL();

      TarefaAtual = new Tarefa();
      Tarefas = TarefaDAL.GetTarefas();
      SalvarCommand = new Command(Salvar);
    }

    private void Salvar()
    {
      TarefaAtual.Concluido = false;
      TarefaDAL.Salvar(TarefaAtual);
    }
  }
}
