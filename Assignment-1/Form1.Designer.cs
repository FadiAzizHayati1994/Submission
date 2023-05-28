namespace Assignement
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
            btnCreateControls = new Button();
            comboBox1 = new ComboBox();
            txtNumberOfControls = new TextBox();
            pnlDynamicControls = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCreateControls
            // 
            btnCreateControls.BackColor = Color.White;
            btnCreateControls.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateControls.Location = new Point(140, 325);
            btnCreateControls.Margin = new Padding(4);
            btnCreateControls.Name = "btnCreateControls";
            btnCreateControls.Size = new Size(204, 85);
            btnCreateControls.TabIndex = 0;
            btnCreateControls.Text = "Create Controls";
            btnCreateControls.UseVisualStyleBackColor = false;
            btnCreateControls.Click += btnCreateControls_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Button", "TextBox", "Label" });
            comboBox1.Location = new Point(214, 128);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 35);
            comboBox1.TabIndex = 1;
            // 
            // txtNumberOfControls
            // 
            txtNumberOfControls.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumberOfControls.Location = new Point(214, 206);
            txtNumberOfControls.Margin = new Padding(4);
            txtNumberOfControls.Name = "txtNumberOfControls";
            txtNumberOfControls.Size = new Size(294, 32);
            txtNumberOfControls.TabIndex = 2;
            txtNumberOfControls.TextChanged += txtNumberOfControls_TextChanged;
            // 
            // pnlDynamicControls
            // 
            pnlDynamicControls.BackColor = Color.White;
            pnlDynamicControls.BorderStyle = BorderStyle.FixedSingle;
            pnlDynamicControls.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pnlDynamicControls.Location = new Point(530, 56);
            pnlDynamicControls.Margin = new Padding(4);
            pnlDynamicControls.Name = "pnlDynamicControls";
            pnlDynamicControls.Size = new Size(562, 492);
            pnlDynamicControls.TabIndex = 3;
            pnlDynamicControls.Paint += pnlDynamicControls_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 131);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 27);
            label1.TabIndex = 4;
            label1.Text = "Control Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(4, 205);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 27);
            label2.TabIndex = 5;
            label2.Text = "Number of controls";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1192, 604);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlDynamicControls);
            Controls.Add(txtNumberOfControls);
            Controls.Add(comboBox1);
            Controls.Add(btnCreateControls);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateControls;
        private ComboBox comboBox1;
        private TextBox txtNumberOfControls;
        private Panel pnlDynamicControls;
        private Label label1;
        private Label label2;
    }
}