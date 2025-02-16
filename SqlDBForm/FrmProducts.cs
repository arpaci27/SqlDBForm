using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlDBForm
{
    public partial class sd : Form
    {
        public sd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connString = new SqlConnection(@"Data Source=DESKTOP-UT8GOU6;Initial Catalog=SalesDB;Integrated Security=True");
        private void Ürünler_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From TBLCategory",connString );
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
//Data Source=DESKTOP-UT8GOU6;Initial Catalog=SalesDB;Integrated Security=True;Trust Server Certificate=True    