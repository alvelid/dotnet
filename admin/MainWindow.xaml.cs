using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace admin {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
            
		}

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command ;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;

            connetionString = "Data Source=130.237.226.220;Initial Catalog=starwars;User ID=charizard;Password=polka123";
            sql = "SELECT * from Anvandare where anvID=" + textBox1.GetLineText(0) + "and password = " + textBox2.GetLineText(0) + ";";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "SQL Temp Table");
                adapter.Dispose();
                command.Dispose();
                connection.Close();


                foreach (DataTable tables in ds.Tables)
                {
                    MessageBox.Show (tables.TableName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }
        
	}
}
