
using System.Data;
using System.Data.OleDb;




namespace myfirst
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\Custommer.accdb");
        public Form1()
        {
            InitializeComponent();
        }
        void dataviewer()
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Custommer";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try { 
            
     
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Custommer  values ('" + texboxid.Text + "','" + texboxname.Text + "','" + texboxaddress.Text + "','" + texboxage.Text + "','" + texboxsex.Text + "','" + texboxdate.Text + "' )";
            cmd.ExecuteNonQuery();
            MessageBox.Show("recode save in database","Connect",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                conn.Close();
                dataviewer();
                

                texboxid.Text = "";
                texboxname.Text = "";
                texboxaddress.Text = "";
                texboxage.Text = "";
                texboxsex.Text = "";
                texboxdate.Text = "";

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Custommer set Name = '"+ texboxname.Text+"',Address = '"+texboxaddress.Text+"' where ID = '"+texboxid.Text+"'" ;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Recode update Successfully", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
               

                texboxid.Text = "";
                texboxname.Text = "";
                texboxaddress.Text = "";
                texboxage.Text = "";
                texboxsex.Text = "";
                texboxdate.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                texboxid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                texboxname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                texboxaddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                texboxage.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                texboxsex.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                texboxdate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete * from Custommer  where ID = '" + texboxid.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Recode Deleted Successfully", "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();

                texboxid.Text = "";
                texboxname.Text = "";
                texboxaddress.Text = "";
                texboxage.Text = "";
                texboxsex.Text = "";
                texboxdate.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
    }
}