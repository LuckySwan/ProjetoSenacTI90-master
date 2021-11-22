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

        List<Pedido> pedidosList;

        public Pedidos()
        {
            InitializeComponent();
            pedidosList = new List<Pedido>();
        }

        public int Id { get; private set; }



        


       

        private void pedidoCombo_Loaded(object sender, RoutedEventArgs e)
        {
            

            //var conn = new SqlConnection(connectionString);
            //conn.Open();
            //var cmd = "SELECT Id, Nome FROM Produto";
            //var SqlCommand = new SqlCommand(cmd, conn);
            //var dataReader = SqlCommand.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    var pedido = new Pedido();

            //    pedido.Id = dataReader.GetInt32(0);
            //    pedido.Name = dataReader.GetString(1);

            //    pedidosList.Add(pedido);
            //}
            //pedidoCombo.ItemsSource = pedidosList;
        }

        private void pagamentoCombo_Loaded(object sender, RoutedEventArgs e)
        {
            //var pagamentosList = new List<Pagamento>();

            //var conn = new SqlConnection(connectionString);
            //conn.Open();
            //var cmd = "SELECT Id, Nome FROM Pagamento";
            //var SqlCommand = new SqlCommand(cmd, conn);
            //var dataReader = SqlCommand.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    var pagamento = new Pagamento();

            //    pagamento.Id = dataReader.GetInt32(0);
            //    pagamento.Name = dataReader.GetString(1);

            //    pagamentosList.Add(pagamento);
            //}
            //pagamentoCombo.ItemsSource = pagamentosList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           var conn = new SqlConnection(connectionString);
            conn.Open();
            string cmd = $"INSERT INTO ProdutoFaturado (Id, Produto, Quantidade, ForPag) VALUES (0, '{nomeProdutoCombo.Text}', '{int.Parse(quantidade.Text)}', '{pagamentoCombo}')";
            var sqlCommand = new SqlCommand(cmd, conn);
            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Pedido Efetuado com Sucesso");
            }
        }
    }
}
