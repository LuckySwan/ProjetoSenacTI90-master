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
    public class Pedido
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Pagamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class Pedidos : Window
    {
        string connectionString = "Data Source=sqllimpeza.database.windows.net;Initial Catalog=Limpeza;User ID=limpeza;Password=@senacGHL;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



        public Pedidos()
        {
            InitializeComponent();
        }

        public int Id { get; private set; }



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        sqlConnection.Open();
        //        var cmd = $"INSET INTO PEDIDO (codigo) VALUE ({CodigoItem1.Text})";
        //        var sqlCommand = new SqlCommand(cmd, sqlConnection);
        //        var da = new SqlDataAdapter(sqlCommand);
        //        var result = sqlCommand.ExecuteNonQuery();
        //    }
        // }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        sqlConnection.Open();
        //        var cmd = $"INSET INTO PEDIDO (codigo) VALUE ({CodigoItem2.Text})";
        //        var sqlCommand = new SqlCommand(cmd, sqlConnection);
        //        var da = new SqlDataAdapter(sqlCommand);
        //        var result = sqlCommand.ExecuteNonQuery();
        //    }
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        sqlConnection.Open();
        //        var cmd = $"INSET INTO PEDIDO (codigo) VALUE ({CodigoItem3.Text})";
        //        var sqlCommand = new SqlCommand(cmd, sqlConnection);
        //        var da = new SqlDataAdapter(sqlCommand);
        //        var result = sqlCommand.ExecuteNonQuery();
        //    }
        //}


       

        private void pedidoCombo_Loaded(object sender, RoutedEventArgs e)
        {
            var pedidosList = new List<Pedido>();

            var conn = new SqlConnection(connectionString);
            conn.Open();
            var cmd = "SELECT Id, Nome FROM Produto";
            var SqlCommand = new SqlCommand(cmd, conn);
            var dataReader = SqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var pedido = new Pedido();

                pedido.Id = dataReader.GetInt32(0);
                pedido.Name = dataReader.GetString(1);

                pedidosList.Add(pedido);
            }
            pedidoCombo.ItemsSource = pedidosList;
        }

        private void pagamentoCombo_Loaded(object sender, RoutedEventArgs e)
        {
            var pagamentosList = new List<Pagamento>();

            var conn = new SqlConnection(connectionString);
            conn.Open();
            var cmd = "SELECT Id, Nome FROM Pagamento";
            var SqlCommand = new SqlCommand(cmd, conn);
            var dataReader = SqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var pagamento = new Pagamento();

                pagamento.Id = dataReader.GetInt32(0);
                pagamento.Name = dataReader.GetString(1);

                pagamentosList.Add(pagamento);
            }
            pagamentoCombo.ItemsSource = pagamentosList;
        }
    }
}
