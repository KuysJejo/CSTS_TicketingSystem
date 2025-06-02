using System.Data.SqlClient;
using System.Windows.Forms;


public static class DatabaseHelper
{
    private static SqlConnection _conn = null;




    public static SqlConnection GetConnection()
    {
        if (_conn == null)
        {
            string url = @"Data Source=(LocalDB)\MSSQLLocalDB;
                            AttachDbFilename=C:\Users\KuysJejo\Desktop\TicketingSystem\TicketingSystemDB.mdf;
                            Integrated Security=True";
            _conn = new SqlConnection(url);
        }
        return _conn;
       
    }


    public static void ConnCloseOpen()
    {
        if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
        {
            _conn.Close();
            //MessageBox.Show("Connection Closed");
            _conn.Open();
            //MessageBox.Show("Connection Opened");
        }
        else
        {
            _conn.Open();
            //MessageBox.Show("Connection Opened");
        }
    }

}
