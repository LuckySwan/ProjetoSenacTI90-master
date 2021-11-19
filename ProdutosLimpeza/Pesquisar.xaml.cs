using System;
using System.Collections.Generic;
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
    /// Lógica interna para Pesquisar.xaml
    /// </summary>
    public partial class Pesquisar : Window
    {
        private const string connectionString =
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}

        }

        private void pesquisar_Click(object sender, RoutedEventArgs e)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"INSET INTO PRODUTO (codigo) VALUE ({CodigoProduto.Text})";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var result = sqlCommand.ExecuteNonQuery();

                if(result > 0)
                {
                    sqlConnection.Open();
                    var cmy = $"SELECT INTO PRODUTO (nome, preço) VALUE ({nomeProduto.Text}, {precoproduto.Text})";
                    var sqlCommando = new SqlCommand(cmd, sqlConnection);
                    var de = new SqlDataAdapter(sqlCommando);
                    var resulto = sqlCommando.ExecuteNonQuery();

                }
            }
        }

        private void cadastrar_Click(object sender, RoutedEventArgs e)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"INSET INTO PRODUTO (nome, preco, codigo) VALUE ({nomeProduto.Text}, {precoproduto.Text},{CodigoProduto.Text})";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var result = sqlCommand.ExecuteNonQuery();

               
            }
        }
    }
}
