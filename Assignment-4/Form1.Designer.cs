namespace Assignment_4
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkbxUiUx = new System.Windows.Forms.CheckBox();
            this.chkbxWebDesign = new System.Windows.Forms.CheckBox();
            this.chkbxProgramming = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.coCountry = new System.Windows.Forms.ComboBox();
            this.coCity = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Birth:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(228, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(388, 37);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(211, 578);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(284, 72);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Register Employee";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "employee form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "National Number:";
            // 
            // txtNN
            // 
            this.txtNN.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNN.Location = new System.Drawing.Point(228, 78);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(334, 37);
            this.txtNN.TabIndex = 8;
            this.txtNN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNN_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(381, 37);
            this.dateTimePicker1.TabIndex = 7;
            
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(17, 42);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(80, 29);
            this.rbtnMale.TabIndex = 9;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 29);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Location = new System.Drawing.Point(26, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbxUiUx);
            this.groupBox2.Controls.Add(this.chkbxWebDesign);
            this.groupBox2.Controls.Add(this.chkbxProgramming);
            this.groupBox2.Location = new System.Drawing.Point(26, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 141);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills:";
            // 
            // chkbxUiUx
            // 
            this.chkbxUiUx.AutoSize = true;
            this.chkbxUiUx.Location = new System.Drawing.Point(17, 101);
            this.chkbxUiUx.Name = "chkbxUiUx";
            this.chkbxUiUx.Size = new System.Drawing.Size(91, 29);
            this.chkbxUiUx.TabIndex = 2;
            this.chkbxUiUx.Text = "UI/UX";
            this.chkbxUiUx.UseVisualStyleBackColor = true;
            // 
            // chkbxWebDesign
            // 
            this.chkbxWebDesign.AutoSize = true;
            this.chkbxWebDesign.Location = new System.Drawing.Point(17, 66);
            this.chkbxWebDesign.Name = "chkbxWebDesign";
            this.chkbxWebDesign.Size = new System.Drawing.Size(146, 29);
            this.chkbxWebDesign.TabIndex = 1;
            this.chkbxWebDesign.Text = "Web Design";
            this.chkbxWebDesign.UseVisualStyleBackColor = true;
            // 
            // chkbxProgramming
            // 
            this.chkbxProgramming.AutoSize = true;
            this.chkbxProgramming.Location = new System.Drawing.Point(17, 30);
            this.chkbxProgramming.Name = "chkbxProgramming";
            this.chkbxProgramming.Size = new System.Drawing.Size(152, 29);
            this.chkbxProgramming.TabIndex = 0;
            this.chkbxProgramming.Text = "programming";
            this.chkbxProgramming.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.coCity);
            this.groupBox3.Controls.Add(this.coCountry);
            this.groupBox3.Location = new System.Drawing.Point(313, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 252);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Country/City of residency :";
            // 
            // coCountry
            // 
            this.coCountry.FormattingEnabled = true;
            this.coCountry.Items.AddRange(new object[] {
            "Jordan",
            "United Arab Emirates"});
            this.coCountry.Location = new System.Drawing.Point(26, 73);
            this.coCountry.Name = "coCountry";
            this.coCountry.Size = new System.Drawing.Size(277, 33);
            this.coCountry.TabIndex = 0;
            this.coCountry.Text = " Select a Country";
            this.coCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // coCity
            // 
            this.coCity.FormattingEnabled = true;
            this.coCity.Location = new System.Drawing.Point(26, 158);
            this.coCity.Name = "coCity";
            this.coCity.Size = new System.Drawing.Size(277, 33);
            this.coCity.TabIndex = 1;
            this.coCity.Text = " Select a City ";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(684, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNN);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbxUiUx;
        private System.Windows.Forms.CheckBox chkbxWebDesign;
        private System.Windows.Forms.CheckBox chkbxProgramming;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox coCity;
        private System.Windows.Forms.ComboBox coCountry;
    }
}

