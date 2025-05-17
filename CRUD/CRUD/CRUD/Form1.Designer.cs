namespace CRUD
{
    partial class CRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            BTN_SELECT_IMG = new Button();
            BTN_INSERT = new Button();
            BTN_UPDATE = new Button();
            BTN_DELETE = new Button();
            textBoxSearch = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(483, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(716, 544);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Font = new Font("Segoe UI", 15.75F);
            textBoxID.Location = new Point(81, 52);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(233, 35);
            textBoxID.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 15.75F);
            textBoxName.Location = new Point(81, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 35);
            textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 15.75F);
            textBoxDescription.Location = new Point(25, 176);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(289, 128);
            textBoxDescription.TabIndex = 6;
            textBoxDescription.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 141);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(25, 310);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BTN_SELECT_IMG
            // 
            BTN_SELECT_IMG.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_SELECT_IMG.Location = new Point(63, 591);
            BTN_SELECT_IMG.Name = "BTN_SELECT_IMG";
            BTN_SELECT_IMG.Size = new Size(200, 38);
            BTN_SELECT_IMG.TabIndex = 9;
            BTN_SELECT_IMG.Text = "SELECT IMG";
            BTN_SELECT_IMG.UseVisualStyleBackColor = true;
            BTN_SELECT_IMG.Click += BTN_SELECT_IMG_Click;
            // 
            // BTN_INSERT
            // 
            BTN_INSERT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_INSERT.Location = new Point(337, 141);
            BTN_INSERT.Name = "BTN_INSERT";
            BTN_INSERT.Size = new Size(128, 45);
            BTN_INSERT.TabIndex = 10;
            BTN_INSERT.Text = "INSERT";
            BTN_INSERT.UseVisualStyleBackColor = true;
            BTN_INSERT.Click += BTN_INSERT_Click;
            // 
            // BTN_UPDATE
            // 
            BTN_UPDATE.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_UPDATE.Location = new Point(337, 205);
            BTN_UPDATE.Name = "BTN_UPDATE";
            BTN_UPDATE.Size = new Size(128, 45);
            BTN_UPDATE.TabIndex = 11;
            BTN_UPDATE.Text = "UPDATE";
            BTN_UPDATE.UseVisualStyleBackColor = true;
            BTN_UPDATE.Click += BTN_UPDATE_Click;
            // 
            // BTN_DELETE
            // 
            BTN_DELETE.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_DELETE.Location = new Point(337, 268);
            BTN_DELETE.Name = "BTN_DELETE";
            BTN_DELETE.Size = new Size(128, 45);
            BTN_DELETE.TabIndex = 12;
            BTN_DELETE.Text = "DELETE";
            BTN_DELETE.UseVisualStyleBackColor = true;
            BTN_DELETE.Click += BTN_DELETE_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 15.75F);
            textBoxSearch.Location = new Point(610, 28);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(573, 49);
            textBoxSearch.TabIndex = 14;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(524, 39);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 13;
            label4.Text = "SEARCH";
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1211, 650);
            Controls.Add(textBoxSearch);
            Controls.Add(label4);
            Controls.Add(BTN_DELETE);
            Controls.Add(BTN_UPDATE);
            Controls.Add(BTN_INSERT);
            Controls.Add(BTN_SELECT_IMG);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxDescription);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CRUD";
            Text = "CRUD";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label3;
        private PictureBox pictureBox1;
        private Button BTN_SELECT_IMG;
        private Button BTN_INSERT;
        private Button BTN_UPDATE;
        private Button BTN_DELETE;
        private TextBox textBoxSearch;
        private Label label4;
    }
}
