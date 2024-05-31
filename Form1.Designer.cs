namespace Assignment_4._1._1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            mobilePhoneTextBox = new TextBox();
            workPhoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            addressTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 549);
            button1.Name = "button1";
            button1.Size = new Size(287, 58);
            button1.TabIndex = 0;
            button1.Text = "Record Entry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 116);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 186);
            label3.Name = "label3";
            label3.Size = new Size(204, 41);
            label3.TabIndex = 3;
            label3.Text = "Mobile Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 261);
            label4.Name = "label4";
            label4.Size = new Size(181, 41);
            label4.TabIndex = 4;
            label4.Text = "Work Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 331);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 406);
            label6.Name = "label6";
            label6.Size = new Size(125, 41);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(303, 39);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(288, 47);
            firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(303, 113);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(288, 47);
            lastNameTextBox.TabIndex = 8;
            // 
            // mobilePhoneTextBox
            // 
            mobilePhoneTextBox.Location = new Point(303, 186);
            mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            mobilePhoneTextBox.Size = new Size(288, 47);
            mobilePhoneTextBox.TabIndex = 9;
            // 
            // workPhoneTextBox
            // 
            workPhoneTextBox.Location = new Point(303, 261);
            workPhoneTextBox.Name = "workPhoneTextBox";
            workPhoneTextBox.Size = new Size(288, 47);
            workPhoneTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(303, 331);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(288, 47);
            emailTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(303, 406);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(288, 47);
            addressTextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(628, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(559, 732);
            dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 824);
            Controls.Add(dataGridView1);
            Controls.Add(addressTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(workPhoneTextBox);
            Controls.Add(mobilePhoneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Contact Book";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox mobilePhoneTextBox;
        private TextBox workPhoneTextBox;
        private TextBox emailTextBox;
        private TextBox addressTextBox;
        private DataGridView dataGridView1;
    }
}
