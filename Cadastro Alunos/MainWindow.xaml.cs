using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Cadastro_Alunos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGridPreview.DataContext = Cadastro.Instance.Alunos;
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome");
                return;
            }
            double nota1 = 0;
            double nota2 = 0;
            double.TryParse(txtNota1.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out nota1);
            double.TryParse(txtNota2.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out nota2);
            int matricula;
            if (int.TryParse(txtMatricula.Text.Trim(), out matricula))
            {
                Cadastro.Instance.Cadastrar(nome, matricula, nota1, nota2);
            }
            else
            {
                Cadastro.Instance.CadastrarAutoMatricula(nome, nota1, nota2);
            }
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
        }

        private void Exibir_Click(object sender, RoutedEventArgs e)
        {
            var ex = new Exibir();
            ex.Owner = this;
            ex.Show();
        }
    }
}
