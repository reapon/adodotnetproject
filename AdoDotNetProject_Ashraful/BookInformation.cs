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
using System.Configuration;


namespace AdoDotNetProject_Ashraful
{
    public partial class BookInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;

        InsertBook obBookInsert = new InsertBook();

        DeleteBookInfo obBookDelete = new DeleteBookInfo();

        UpdateBookInfo obUpdateBook = new UpdateBookInfo();


        public void GetAuthorID()
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Select * From Authors", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select AuthorID--" };
                dt.Rows.InsertAt(dr, 0);

                cmBoxAuthorID.ValueMember = "AuthorID";
                cmBoxAuthorID.DisplayMember = "AuthorName";

                cmBoxAuthorID.DataSource = dt;
                con.Close();

            }
        }

        public BookInformation()
        {
            InitializeComponent();
            RefreshBookInfo();
            GetAuthorID();
        }

        private void BookInformation_Load(object sender, EventArgs e)
        {

        }

        public void RefreshBookInfo()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Books", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewBookInfo.DataSource = dt;
            }
        }

        public void ClearBookInfo()
        {
            txtBookName.Text = "";
            txtBookEdition.Text = "";
            txtBookPrice.Text = "";
            txtBookPublication.Text = "";
            cmBoxAuthorID.SelectedValue = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookEdition.Text != "" && txtBookName.Text != "" && txtBookPrice.Text != "" && txtBookPublication.Text != "")
            {
                obBookInsert.InsertBookData("Insert Into Books Values('" + txtBookName.Text + "','" + txtBookPrice.Text + "','" + txtBookEdition.Text + "','" + txtBookPublication.Text + "','" + cmBoxAuthorID.SelectedValue + "')");
                MessageBox.Show("Data Inserted Successfully");
                RefreshBookInfo();
                ClearBookInfo();
            }
            else
            {
                MessageBox.Show("Please Fill All The Information!!");
            }

        }

        private void dgViewBookInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBid.Text = this.dgViewBookInfo.CurrentRow.Cells["BookID"].Value.ToString();
            txtBookName.Text = this.dgViewBookInfo.CurrentRow.Cells["BookName"].Value.ToString();
            txtBookPrice.Text = this.dgViewBookInfo.CurrentRow.Cells["BookPrice"].Value.ToString();
            txtBookEdition.Text = this.dgViewBookInfo.CurrentRow.Cells["Edition"].Value.ToString();
            txtBookPublication.Text = this.dgViewBookInfo.CurrentRow.Cells["Publication"].Value.ToString();
            cmBoxAuthorID.Text = this.dgViewBookInfo.CurrentRow.Cells["BookAuthorID"].Value.ToString();

        }

        private void btnCancelOp_Click(object sender, EventArgs e)
        {
            ClearBookInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            obBookDelete.DeleteBookData("Delete Books Where BookID='" + lblBid.Text + "'");
            MessageBox.Show("Data Deleted SuccessFully");

            ClearBookInfo();
            RefreshBookInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookEdition.Text != "" && txtBookName.Text != "" && txtBookPrice.Text != "" && txtBookPublication.Text != "")
            {
                obUpdateBook.UpdateBookData("Update Books Set BookName= '" + txtBookName.Text + "', BookPrice= '" + txtBookPrice.Text + "', Edition= '" + txtBookEdition.Text + "', Publication= '" + txtBookPublication.Text + "',BookAuthorID= '" + cmBoxAuthorID.SelectedValue + "' Where BookID='" + lblBid.Text + "'");

                MessageBox.Show("Data Updated SuccessFully");
                ClearBookInfo();

                RefreshBookInfo();
            }
            else
            {
                MessageBox.Show("Please Fill All Information");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
