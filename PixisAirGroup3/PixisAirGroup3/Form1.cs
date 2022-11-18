using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PixisAirGroup3
{
    public partial class FormDev1 : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public FormDev1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=v2studentpoc;Initial Catalog=PixisAir;Persist Security Info=True;User ID=Student;Password=ichooseGateway";
            SQL = "Select * FROM dbo.Employee";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void btnReshist_Click(object sender, EventArgs e)
        {
            SQL = "SELECT * FROM dbo.RESHist ";
            try
            {
                listBox1.Items.Clear();
                dataSet = new DataSet();
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2] + ", " + dataRow[3] + ", " + dataRow[4] + ", " + dataRow[5] + ", " + dataRow[6]);
                connection.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SQL = "INSERT INTO dbo.Cars2(Make,Model,DoorCount,ID,Color) VALUES('"+txtMake.Text+"','"+txtModel.Text+"',"+ txtDoor.Text +
                "," + txtId.Text + ",'" + txtColor.Text + "')";
            try
            {
                listBox1.Items.Clear();
                dataSet = new DataSet();
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                MessageBox.Show("Record has been inserted");
                connection.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            SQL = "SELECT * FROM dbo.Cars2 ";
            try
            {
                listBox1.Items.Clear();
                dataSet = new DataSet();
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2] + ", " + dataRow[3] + ", " + dataRow[4]);
                connection.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            FormDev1 fd1 = new FormDev1();
            fd1.Hide();
            fm.Show();
        }
       
    }
}
