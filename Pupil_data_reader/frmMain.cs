using System.Data;
using Microsoft.Data.SqlClient;

namespace Pupil_data_reader
{
    public partial class frmMain : Form
    {
        public string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student_tracker;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private DataTable dataTable = new DataTable();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


           loadSubjects();
            //sqlConnection.Columns.Clear();
            //sqlConnection.DataSource = SBind;
            if (tvSubjects.Nodes.Count == 0)
            {
                tvSubjects.BeginUpdate();
                TreeNode tn = new TreeNode("Business");
               
                tvSubjects.Nodes.Add(tn);
                tvSubjects.Nodes.Add(new TreeNode("Computer Science"));
                tvSubjects.Nodes[1].Nodes.Add("13C-Sped Eds");
                tvSubjects.Nodes[0].Nodes.Add("13C-Bus");
                tvSubjects.EndUpdate();
            }

        }
        private void tvSubjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            MessageBox.Show(e.Node.Text);

            

        }

        private void dgvPupilData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadPupils()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;// "Data Source=(localdb)\\ProjectModels;Initial Catalog=student_tracker;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }
            if (sqlConnection is null) MessageBox.Show("not connected");

            string sql_select = "SELECT [SetList].PupilId FROM Subject " +
                "INNER JOIN [Set] " +
                "ON Subject.Id = [Set].[SubjectId] " +
                "INNER JOIN [SetList] " +
                "ON [Set].Id = [SetList].[SetId]" +
                "WHERE Subject.Code = 'COM'";
            MessageBox.Show(sql_select);
            SqlCommand selectcommand = new SqlCommand(sql_select, sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(selectcommand);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            sqlConnection.Close();
            da.Dispose();
            dgvPupilData.DataSource = dataTable;
        }


        private void loadSubjects()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;

            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }
            if (sqlConnection is null) MessageBox.Show("not connected");

            string sql_select = "SELECT * FROM Subject " +
                "INNER JOIN [Set] " +
                "ON Subject.Id = [Set].[SubjectId] ";
            //MessageBox.Show(sql_select);
            SqlCommand selectcommand = new SqlCommand(sql_select, sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(selectcommand);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            sqlConnection.Close();
            da.Dispose();
            dgvPupilData.DataSource = dataTable;
        }
    }
}
