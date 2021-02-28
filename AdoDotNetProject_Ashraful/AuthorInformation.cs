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
using System.IO;

namespace AdoDotNetProject_Ashraful
{
    public partial class AuthorInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void RefreshData()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Authors", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewAuthorInfo.DataSource = dt;
            }
        }

        public void ClearAllData()
        {
            txtAuthorName.Text = "";
            txtGender.Text = "";
            txtAuthorEmail.Text = "";
            txtAuthorAddress.Text = "";
            txtImageLink.Text = "";
            txtAuthorPhone.Text = "";
            pictureBoxForImage.Image = null;

        }

        InsertAuthor obInsert = new InsertAuthor();

        UpdateAuthor obUpdate = new UpdateAuthor();

        DeleteAuthor obDelete = new DeleteAuthor();

        public AuthorInformation()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*jpg; *jpeg; *gif; *bmp;)|*jpg; *jpeg; *gif; *bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImageLink.Text = open.FileName;
                pictureBoxForImage.Image = new Bitmap(open.FileName);

            }
        }

        private void AuthorInformation_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAuthorAddress.Text != "" && txtAuthorEmail.Text != "" && txtAuthorName.Text != "" && txtAuthorPhone.Text != "" && txtImageLink.Text != "" )
            {
                File.Copy(txtImageLink.Text, Path.Combine(@"C:\Users\DELL\OneDrive\Desktop\Images", Path.GetFileName(txtImageLink.Text)), true);

                obInsert.InsertData("Insert Into Authors Values('" + txtAuthorName.Text + "','" + txtGender.Text + "','" + txtAuthorEmail.Text + "','" + txtAuthorPhone.Text + "','" + txtAuthorAddress.Text + "','" + txtImageLink.Text + "')");
                MessageBox.Show("Data Inserted Successfully");
                RefreshData();
                ClearAllData();
            }
         

                
            
            else
            {
                MessageBox.Show("Please Provide All Information");
            }


        }

        private void dgViewAuthorInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAuthorName.Text = this.dgViewAuthorInfo.CurrentRow.Cells["AuthorName"].Value.ToString();
            txtGender.Text = this.dgViewAuthorInfo.CurrentRow.Cells["Gender"].Value.ToString();
            txtAuthorEmail.Text = this.dgViewAuthorInfo.CurrentRow.Cells["Email"].Value.ToString();
            txtAuthorPhone.Text = this.dgViewAuthorInfo.CurrentRow.Cells["Phone"].Value.ToString();
            txtAuthorAddress.Text = this.dgViewAuthorInfo.CurrentRow.Cells["Address"].Value.ToString();
            txtImageLink.Text = this.dgViewAuthorInfo.CurrentRow.Cells["Image"].Value.ToString();
            lblAid.Text = this.dgViewAuthorInfo.CurrentRow.Cells["AuthorID"].Value.ToString();




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAuthorAddress.Text != "" && txtAuthorEmail.Text != "" && txtAuthorName.Text != "" && txtAuthorPhone.Text != "" && txtImageLink.Text != "")
            {
                File.Copy(txtImageLink.Text, Path.Combine(@"C:\Users\DELL\OneDrive\Desktop\Images", Path.GetFileName(txtImageLink.Text)), true);

                obUpdate.UpdateData("Update Authors Set AuthorName= '" + txtAuthorName.Text + "', Gender= '" + txtGender.Text + "', Email= '" + txtAuthorEmail.Text + "', Phone= '" + txtAuthorPhone.Text + "',Address= '" + txtAuthorAddress.Text + "',Image= '" + txtImageLink.Text + "' Where AuthorID='" + lblAid.Text + "'");

                MessageBox.Show("Data Updated Successfully");
                RefreshData();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Please Fill All Info");
            }
        }

        private void btnCancelOp_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            obDelete.DeleteData("Delete Authors Where AuthorID='" + lblAid.Text + "'");
            MessageBox.Show("Data Deleted Successfully");
            RefreshData();
            ClearAllData();
        }

        private void btnAuthorHome_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
