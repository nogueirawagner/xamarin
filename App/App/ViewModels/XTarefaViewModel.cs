using App.Commands.TarefaCmds;
using App.DAL.TarefaDAL;
using App.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModels
{
  public class XTarefaViewModel : INotifyPropertyChanged
  {
    public XITarefaDAL TarefaDAL { get; set; }

    public Tarefa TarefaAtual { get; set; }
    public ObservableCollection<Tarefa> Tarefas { get; set; }
    public Command SalvarCommand { get; set; }
    public Command EditarCommand { get; set; }
    public ICommand FinalizarCommand { get; set; }
    public Command RemoverCommand { get; set; }

    public XTarefaViewModel()
    {
      TarefaDAL = new XTarefaDAL();

      TarefaAtual = new Tarefa();
      Tarefas = new ObservableCollection<Tarefa>(TarefaDAL.GetTarefas());
      SalvarCommand = new Command(Salvar);
      EditarCommand = new Command<Tarefa>(Editar);
      RemoverCommand = new Command<Tarefa>(Remover);
      FinalizarCommand = new XFinalizarCmd(this);
    }

    private void Remover(Tarefa pTarefa)
    {
      TarefaDAL.Excluir(pTarefa);
      Tarefas.Remove(pTarefa); // Melhor opção, pois não precisa de chamar serviço e recarregar dados.
      //AtualizaListaTarefas();
    }

    private void Salvar()
    {
      if(TarefaAtual.ID == 0)
      {
        TarefaAtual.Concluido = false;
        TarefaDAL.Salvar(TarefaAtual);
        Tarefas.Add(TarefaAtual);
      }
      else
      {
        TarefaDAL.Alterar(TarefaAtual);
        AtualizaListaTarefas();
      }

      TarefaAtual = new Tarefa();
      OnPropertyChanged("TarefaAtual");
    }

    private void Editar(Tarefa pTarefa)
    {
      TarefaAtual = pTarefa;
      OnPropertyChanged("TarefaAtual");
    }

    private void AtualizaListaTarefas()
    {
      Tarefas = new ObservableCollection<Tarefa>(TarefaDAL.GetTarefas());
      OnPropertyChanged("Tarefas");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public virtual void OnPropertyChanged([CallerMemberName] string pPropertyName = null)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null)
        handler(this, new PropertyChangedEventArgs(pPropertyName));
    }
  }
}
