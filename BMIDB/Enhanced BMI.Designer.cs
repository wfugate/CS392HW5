namespace BMIDB
{
    partial class EnhancedBMI
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
            lblHeight = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnCalculate = new Button();
            txtBMI = new TextBox();
            lbxGender = new ListBox();
            lblGender = new Label();
            btnSaveToDB = new Button();
            gbxInput = new GroupBox();
            lblEnhancedBMI = new Label();
            lblWeight = new Label();
            btnAvgBMI = new Button();
            gbxInput.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(8, 42);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(99, 15);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Height in inches: ";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(168, 54);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 6;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(168, 96);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(3, 197);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(110, 50);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate Enhanced BMI";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtBMI
            // 
            txtBMI.Location = new Point(145, 212);
            txtBMI.Name = "txtBMI";
            txtBMI.Size = new Size(100, 23);
            txtBMI.TabIndex = 15;
            // 
            // lbxGender
            // 
            lbxGender.FormattingEnabled = true;
            lbxGender.ItemHeight = 15;
            lbxGender.Items.AddRange(new object[] { "Male", "Female" });
            lbxGender.Location = new Point(168, 135);
            lbxGender.Name = "lbxGender";
            lbxGender.Size = new Size(100, 34);
            lbxGender.TabIndex = 16;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(8, 123);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 17;
            lblGender.Text = "Gender: ";
            // 
            // btnSaveToDB
            // 
            btnSaveToDB.Location = new Point(28, 277);
            btnSaveToDB.Name = "btnSaveToDB";
            btnSaveToDB.Size = new Size(122, 48);
            btnSaveToDB.TabIndex = 18;
            btnSaveToDB.Text = "Save to DB";
            btnSaveToDB.UseVisualStyleBackColor = true;
            // 
            // gbxInput
            // 
            gbxInput.Controls.Add(lblEnhancedBMI);
            gbxInput.Controls.Add(lblWeight);
            gbxInput.Controls.Add(txtBMI);
            gbxInput.Controls.Add(lblGender);
            gbxInput.Controls.Add(btnCalculate);
            gbxInput.Controls.Add(lblHeight);
            gbxInput.Location = new Point(23, 12);
            gbxInput.Name = "gbxInput";
            gbxInput.Size = new Size(288, 259);
            gbxInput.TabIndex = 19;
            gbxInput.TabStop = false;
            // 
            // lblEnhancedBMI
            // 
            lblEnhancedBMI.AutoSize = true;
            lblEnhancedBMI.Location = new Point(145, 184);
            lblEnhancedBMI.Name = "lblEnhancedBMI";
            lblEnhancedBMI.Size = new Size(86, 15);
            lblEnhancedBMI.TabIndex = 22;
            lblEnhancedBMI.Text = "Enhanced BMI ";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(8, 84);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(107, 15);
            lblWeight.TabIndex = 21;
            lblWeight.Text = "Weight in pounds: ";
            // 
            // btnAvgBMI
            // 
            btnAvgBMI.Location = new Point(168, 277);
            btnAvgBMI.Name = "btnAvgBMI";
            btnAvgBMI.Size = new Size(143, 48);
            btnAvgBMI.TabIndex = 20;
            btnAvgBMI.Text = "Display Average BMI";
            btnAvgBMI.UseVisualStyleBackColor = true;
            // 
            // EnhancedBMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 375);
            Controls.Add(btnAvgBMI);
            Controls.Add(btnSaveToDB);
            Controls.Add(lbxGender);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(gbxInput);
            Name = "EnhancedBMI";
            Text = "Enhanced BMI";
            gbxInput.ResumeLayout(false);
            gbxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeight;
        private Label lblInches;
        private TextBox txtHeight;
        private TextBox txtHeight2;
        private TextBox txtWeight;
        private Button btnCalculate;
        private LinkLabel llblMetric;
        private Label lblEnglish;
        private TextBox txtBMI;
        private ListBox lbxGender;
        private Label lblGender;
        private Button btnSaveToDB;
        private GroupBox gbxInput;
        private Button btnAvgBMI;
        private Label lblWeight;
        private Label lblEnhancedBMI;
    }
}
