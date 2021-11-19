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

    public partial class Pesquisar : Window
    {
        string connectionString = "Data Source=sqllimpeza.database.windows.net;Initial Catalog=Limpeza;User ID=limpeza;Password=@senacGHL;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Pesquisar()
        {
            InitializeComponent();
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
 private void Pesquisar_Click(object sender, RoutedEventArgs e)
    {

    }

    private void cadastrar_Click(object sender, RoutedEventArgs e)
    {
        using (var sqlConnection = new SqlConnection(connectionString))
        {
            sqlConnection.Open();
            var cmd = $"INSET INTO PRODUTO (nome, preco, codigo) VALUE ({nomeProduto.Text}, {precoProduto.Text},{CodigoProduto.Text})";
            var sqlCommand = new SqlCommand(cmd, sqlConnection);
            var da = new SqlDataAdapter(sqlCommand);
            var result = sqlCommand.ExecuteNonQuery();


        }
    }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"INSET INTO PRODUTO (codigo) VALUE ({CodigoProduto.Text})";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    sqlConnection.Open();
                    var cmy = $"SELECT INTO PRODUTO (nome, preço) VALUE ({nomeProduto.Text}, {precoProduto.Text})";
                    var sqlCommando = new SqlCommand(cmd, sqlConnection);
                    var de = new SqlDataAdapter(sqlCommando);
                    var resulto = sqlCommando.ExecuteNonQuery();

                }
            }

        }
    }



    private void Pesquisar_Click(object sender, RoutedEventArgs e)
    {

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
}
