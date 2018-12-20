using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FeedbackAppV1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            const string connectionString = @"Data Source=mssql2008R2.aspnethosting.co.uk,14330; Initial Catalog=samuelba_feedback; User ID=samuelba_admin; Password=sl71064LS";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
