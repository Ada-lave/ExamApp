namespace ExamApp
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            userIdTextBox = new TextBox();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            userAgeTextBox = new TextBox();
            userNameTextBox = new TextBox();
            saveUserButton = new Button();
            loadUsersButton = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(705, 536);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(userIdTextBox);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(userAgeTextBox);
            tabPage1.Controls.Add(userNameTextBox);
            tabPage1.Controls.Add(saveUserButton);
            tabPage1.Controls.Add(loadUsersButton);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(697, 503);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 328);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 9;
            label3.Text = "ID";
            // 
            // userIdTextBox
            // 
            userIdTextBox.Enabled = false;
            userIdTextBox.Location = new Point(569, 325);
            userIdTextBox.Name = "userIdTextBox";
            userIdTextBox.Size = new Size(125, 27);
            userIdTextBox.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(683, 29);
            progressBar1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 415);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Возраст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 371);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // userAgeTextBox
            // 
            userAgeTextBox.Location = new Point(569, 412);
            userAgeTextBox.Name = "userAgeTextBox";
            userAgeTextBox.Size = new Size(125, 27);
            userAgeTextBox.TabIndex = 4;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(569, 368);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(125, 27);
            userNameTextBox.TabIndex = 3;
            // 
            // saveUserButton
            // 
            saveUserButton.Location = new Point(564, 448);
            saveUserButton.Name = "saveUserButton";
            saveUserButton.Size = new Size(125, 29);
            saveUserButton.TabIndex = 2;
            saveUserButton.Text = "Save";
            saveUserButton.UseVisualStyleBackColor = true;
            saveUserButton.Click += saveUserButton_Click;
            // 
            // loadUsersButton
            // 
            loadUsersButton.Location = new Point(8, 314);
            loadUsersButton.Name = "loadUsersButton";
            loadUsersButton.Size = new Size(94, 29);
            loadUsersButton.TabIndex = 1;
            loadUsersButton.Text = "Load";
            loadUsersButton.UseVisualStyleBackColor = true;
            loadUsersButton.Click += loadUsersButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(697, 503);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 536);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button loadUsersButton;
        private Label label2;
        private Label label1;
        private TextBox userAgeTextBox;
        private TextBox userNameTextBox;
        private Button saveUserButton;
        private ProgressBar progressBar1;
        private Label label3;
        private TextBox userIdTextBox;
    }
}
