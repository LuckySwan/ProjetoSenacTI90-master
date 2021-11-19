using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProdutosLimpeza
{
    
    /// <summary>
    /// Lógica interna para addCustumerWindow.xaml
    /// </summary>
    public partial class addCustumerWindow : Window
    {
        string connectionString = "Data Source=sqllimpeza.database.windows.net;Initial Catalog=Limpeza;User ID=limpeza;Password=@senacGHL;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public addCustumerWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = $"INSERT INTO Endereco (Cidade, Bairro, Rua, Numero, Complemento) VALUES ( '{customerCidadeTextBox.Text}', '{customerBairroTextBox.Text}', '{customerRuaTextBox.Text}', '{int.Parse(customerNumeroTextBox.Text)}', '{customerComplementoTextBox.Text}')";
                var sqlCommand = new SqlCommand(cmd, conn);
                var result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Dados Inseridos com Sucesso");
                }
            }

        }
    }
}
