namespace MovieCatalog.FormApp
{
    partial class Form1
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtCountry = new TextBox();
            txtTitle = new TextBox();
            txtYear = new TextBox();
            btnAddDirector = new Button();
            btnUpdateDirector = new Button();
            btnDelDirector = new Button();
            btnAddMovie = new Button();
            btnUpdateMovie = new Button();
            btnDelMovie = new Button();
            label7 = new Label();
            dgvDirector = new DataGridView();
            dgvMovie = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDirector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(49, 148);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 0;
            label2.Text = "Country:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(49, 104);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(58, 333);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 2;
            label4.Text = "Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(56, 298);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 3;
            label3.Text = "Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(124, 60);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 4;
            label5.Text = "Director";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(124, 253);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 5;
            label6.Text = "Movie";
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 6;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(124, 148);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(134, 23);
            txtCountry.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(109, 298);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(149, 23);
            txtTitle.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(109, 333);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(70, 23);
            txtYear.TabIndex = 9;
            // 
            // btnAddDirector
            // 
            btnAddDirector.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAddDirector.Location = new Point(28, 193);
            btnAddDirector.Name = "btnAddDirector";
            btnAddDirector.Size = new Size(75, 57);
            btnAddDirector.TabIndex = 10;
            btnAddDirector.Text = "Add Director";
            btnAddDirector.UseVisualStyleBackColor = true;
            btnAddDirector.Click += btnAddDirector_Click;
            // 
            // btnUpdateDirector
            // 
            btnUpdateDirector.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnUpdateDirector.Location = new Point(129, 193);
            btnUpdateDirector.Name = "btnUpdateDirector";
            btnUpdateDirector.Size = new Size(91, 57);
            btnUpdateDirector.TabIndex = 11;
            btnUpdateDirector.Text = "Update Director";
            btnUpdateDirector.UseVisualStyleBackColor = true;
            btnUpdateDirector.Click += btnUpdateDirector_Click;
            // 
            // btnDelDirector
            // 
            btnDelDirector.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnDelDirector.Location = new Point(239, 195);
            btnDelDirector.Name = "btnDelDirector";
            btnDelDirector.Size = new Size(98, 55);
            btnDelDirector.TabIndex = 12;
            btnDelDirector.Text = " Delete Director";
            btnDelDirector.UseVisualStyleBackColor = true;
            btnDelDirector.Click += btnDelDirector_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAddMovie.Location = new Point(28, 372);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(75, 54);
            btnAddMovie.TabIndex = 13;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnUpdateMovie.Location = new Point(129, 372);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(91, 54);
            btnUpdateMovie.TabIndex = 14;
            btnUpdateMovie.Text = "Update Movie";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // btnDelMovie
            // 
            btnDelMovie.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnDelMovie.Location = new Point(239, 372);
            btnDelMovie.Name = "btnDelMovie";
            btnDelMovie.Size = new Size(98, 54);
            btnDelMovie.TabIndex = 15;
            btnDelMovie.Text = "Delete Movie";
            btnDelMovie.UseVisualStyleBackColor = true;
            btnDelMovie.Click += btnDelMovie_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(74, 9);
            label7.Name = "label7";
            label7.Size = new Size(196, 30);
            label7.TabIndex = 16;
            label7.Text = "--MOVIE CATALOG--";
            // 
            // dgvDirector
            // 
            dgvDirector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirector.Location = new Point(406, 30);
            dgvDirector.Name = "dgvDirector";
            dgvDirector.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirector.Size = new Size(348, 196);
            dgvDirector.TabIndex = 17;
            dgvDirector.CellClick += dgvDirector_CellClick;
            // 
            // dgvMovie
            // 
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(406, 253);
            dgvMovie.Name = "dgvMovie";
            dgvMovie.Size = new Size(348, 185);
            dgvMovie.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMovie);
            Controls.Add(dgvDirector);
            Controls.Add(label7);
            Controls.Add(btnDelMovie);
            Controls.Add(btnUpdateMovie);
            Controls.Add(btnAddMovie);
            Controls.Add(btnDelDirector);
            Controls.Add(btnUpdateDirector);
            Controls.Add(btnAddDirector);
            Controls.Add(txtYear);
            Controls.Add(txtTitle);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDirector).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtCountry;
        private TextBox txtTitle;
        private TextBox txtYear;
        private Button btnAddDirector;
        private Button btnUpdateDirector;
        private Button btnDelDirector;
        private Button btnAddMovie;
        private Button btnUpdateMovie;
        private Button btnDelMovie;
        private Label label7;
        private DataGridView dgvDirector;
        private DataGridView dgvMovie;
    }
}
