namespace Assignment_3
{
    partial class MainForm
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
            txtName = new TextBox();
            label1 = new Label();
            lblHeight = new Label();
            txtInc = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            groupBox1 = new GroupBox();
            rbtnimperial = new RadioButton();
            rbtnMetric = new RadioButton();
            btnOK = new Button();
            grpResults = new GroupBox();
            lblNormalBMI = new Label();
            lblWeightCat = new Label();
            lblBMI = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCmFt = new TextBox();
            groupBox1.SuspendLayout();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 31);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "Your Name";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 85);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(65, 25);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height";
            // 
            // txtInc
            // 
            txtInc.Location = new Point(217, 85);
            txtInc.Name = "txtInc";
            txtInc.Size = new Size(77, 31);
            txtInc.TabIndex = 3;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(12, 131);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(68, 25);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(131, 131);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(77, 31);
            txtWeight.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(rbtnimperial);
            groupBox1.Controls.Add(rbtnMetric);
            groupBox1.Location = new Point(539, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 136);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unit";
            // 
            // rbtnimperial
            // 
            rbtnimperial.AutoSize = true;
            rbtnimperial.Location = new Point(6, 76);
            rbtnimperial.Name = "rbtnimperial";
            rbtnimperial.Size = new Size(177, 29);
            rbtnimperial.TabIndex = 1;
            rbtnimperial.TabStop = true;
            rbtnimperial.Text = "US Unit (foot, lbs)";
            rbtnimperial.UseVisualStyleBackColor = true;
            rbtnimperial.CheckedChanged += rbtnimperial_CheckedChanged;
            // 
            // rbtnMetric
            // 
            rbtnMetric.AutoSize = true;
            rbtnMetric.Location = new Point(6, 30);
            rbtnMetric.Name = "rbtnMetric";
            rbtnMetric.Size = new Size(191, 29);
            rbtnMetric.TabIndex = 0;
            rbtnMetric.TabStop = true;
            rbtnMetric.Text = "Metric Unit (kg, cm)";
            rbtnMetric.UseVisualStyleBackColor = true;
            rbtnMetric.CheckedChanged += rbtnMetric_CheckedChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(257, 245);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(300, 47);
            btnOK.TabIndex = 7;
            btnOK.Text = "Calculate";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // grpResults
            // 
            grpResults.BackColor = SystemColors.ControlLight;
            grpResults.Controls.Add(lblNormalBMI);
            grpResults.Controls.Add(lblWeightCat);
            grpResults.Controls.Add(lblBMI);
            grpResults.Controls.Add(label5);
            grpResults.Controls.Add(label4);
            grpResults.Location = new Point(131, 315);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(532, 175);
            grpResults.TabIndex = 8;
            grpResults.TabStop = false;
            grpResults.Text = "Results for";
            // 
            // lblNormalBMI
            // 
            lblNormalBMI.BorderStyle = BorderStyle.FixedSingle;
            lblNormalBMI.Location = new Point(158, 134);
            lblNormalBMI.Name = "lblNormalBMI";
            lblNormalBMI.Size = new Size(342, 38);
            lblNormalBMI.TabIndex = 11;
            lblNormalBMI.Text = "label8";
            lblNormalBMI.Click += label8_Click;
            // 
            // lblWeightCat
            // 
            lblWeightCat.BorderStyle = BorderStyle.FixedSingle;
            lblWeightCat.Location = new Point(158, 82);
            lblWeightCat.Name = "lblWeightCat";
            lblWeightCat.Size = new Size(268, 38);
            lblWeightCat.TabIndex = 9;
            lblWeightCat.Text = "label";
            lblWeightCat.TextAlign = ContentAlignment.MiddleRight;
            lblWeightCat.Click += label7_Click;
            // 
            // lblBMI
            // 
            lblBMI.BorderStyle = BorderStyle.FixedSingle;
            lblBMI.Location = new Point(158, 39);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(169, 38);
            lblBMI.TabIndex = 10;
            lblBMI.Text = "label";
            lblBMI.TextAlign = ContentAlignment.MiddleRight;
            lblBMI.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 89);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 9;
            label5.Text = "Weight Category";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 46);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 9;
            label4.Text = "Your BMI";
            // 
            // txtCmFt
            // 
            txtCmFt.Location = new Point(131, 85);
            txtCmFt.Name = "txtCmFt";
            txtCmFt.Size = new Size(77, 31);
            txtCmFt.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(txtCmFt);
            Controls.Add(grpResults);
            Controls.Add(btnOK);
            Controls.Add(groupBox1);
            Controls.Add(txtWeight);
            Controls.Add(lblWeight);
            Controls.Add(txtInc);
            Controls.Add(lblHeight);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "MainForm";
            Text = "Body Mass Index";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label lblHeight;
        private TextBox txtInc;
        private Label lblWeight;
        private TextBox txtWeight;
        private GroupBox groupBox1;
        private RadioButton rbtnimperial;
        private RadioButton rbtnMetric;
        private Button btnOK;
        private GroupBox grpResults;
        private Label lblBMI;
        private Label label5;
        private Label label4;
        private Label lblWeightCat;
        private Label lblNormalBMI;
        private TextBox txtCmFt;
    }
}
