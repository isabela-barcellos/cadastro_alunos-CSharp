using System.Windows;

namespace Cadastro_Alunos
{
    public partial class Exibir : Window
    {
        public Exibir()
        {
            InitializeComponent();
            dataGrid.DataContext = Cadastro.Instance.Alunos;
        }
    }
}
