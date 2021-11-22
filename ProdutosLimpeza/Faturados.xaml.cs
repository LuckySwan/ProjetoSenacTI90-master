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

    public partial class Pesquisar : Window
    {
        string connectionString = "Data Source=sqllimpeza.database.windows.net;Initial Catalog=Limpeza;User ID=limpeza;Password=@senacGHL;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Pesquisar()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"SELECT f.Id, f.Produto, f.Quantidade, f.ValorTotal FROM ProdutoFaturado f";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridFaturados.ItemsSource = dt.DefaultView;
            }
        }
    }
}


        



    

    //private void cadastrar_Click(object sender, RoutedEventArgs e)
    //{
    //    using (var sqlConnection = new SqlConnection(connectionString))
    //    {
    //        sqlConnection.Open();
    //        var cmd = $"INSET INTO PRODUTO (nome, preco, codigo) VALUE ({nomeProduto.Text}, {precoproduto.Text},{CodigoProduto.Text})";
    //        var sqlCommand = new SqlCommand(cmd, sqlConnection);
    //        var da = new SqlDataAdapter(sqlCommand);
    //        var result = sqlCommand.ExecuteNonQuery();


    //    }
    //}




