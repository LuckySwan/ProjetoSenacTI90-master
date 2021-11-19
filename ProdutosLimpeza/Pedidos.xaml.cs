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
    /// Lógica interna para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : Window
    {
        string connectionString = "Data Source=sqllimpeza.database.windows.net;Initial Catalog=Limpeza;User ID=limpeza;Password=@senacGHL;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Pedidos()
        {
            InitializeComponent();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"INSET INTO PEDIDO (codigo) VALUE ({CodigoItem1.Text})";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var result = sqlCommand.ExecuteNonQuery();
            }
         }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"INSET INTO PEDIDO (codigo) VALUE ({CodigoItem2.Text})";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var result = sqlCommand.ExecuteNonQuery();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var cmd = $"INSET INTO PEDIDO (codigo) VALUE ({CodigoItem3.Text})";
                var sqlCommand = new SqlCommand(cmd, sqlConnection);
                var da = new SqlDataAdapter(sqlCommand);
                var result = sqlCommand.ExecuteNonQuery();
            }
        }

    //    private void Button_Click_3(object sender, RoutedEventArgs e)
    //    {
    //        using (var sqlConnection = new SqlConnection(connectionString))
    //        {
    //            sqlConnection.Open();
    //            var cmd = $"SELECT INTO PEDIDO (preco) VALUE ({CodItem1.Text})";
    //            var sqlCommand = new SqlCommand(cmd, sqlConnection);
    //            var da = new SqlDataAdapter(sqlCommand);
    //            var result = sqlCommand.ExecuteNonQuery();
    //        }
    //    }
    }
}
