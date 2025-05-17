
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
namespace CRUD
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; Initial Catalog = 'crud-sir-homer-db'; username=root; password=''");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_SELECT_IMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }
        public void FillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM products WHERE CONCAT(id, name, description) LIKE @search", connection);
            command.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Data not found or data not in database", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (dataGridView1.Columns.Count > 3)
            {
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[3].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO products(id,name,description,image) VALUES (@id,@name,@desc,@img)", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Inserted successfuly!");
            FillDGV("");
            ClearFields();
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            try
            {
                mcomd.Connection.Open();
                if (mcomd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(myMsg);
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            finally
            {
                if (mcomd.Connection.State == ConnectionState.Open)
                    mcomd.Connection.Close();
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE products SET name=@name, description=@desc, image=@img WHERE id = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Updated successfuly!");
            FillDGV("");
            ClearFields();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM products WHERE id = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;

            ExecMyQuery(command, "Data Deleted successfuly!");
            FillDGV("");
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxDescription.Clear();
            pictureBox1.Image = null;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text);
        }
    }
}
