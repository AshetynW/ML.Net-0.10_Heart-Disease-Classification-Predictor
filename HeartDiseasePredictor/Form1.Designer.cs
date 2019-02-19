namespace HeartDiseasePredictor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SeverityLabel = new System.Windows.Forms.Label();
            this.PredictionLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ThalCmbo = new System.Windows.Forms.ComboBox();
            this.NoOfVesselsColouredCmbo = new System.Windows.Forms.ComboBox();
            this.SlopeCmbo = new System.Windows.Forms.ComboBox();
            this.STDepressionTxt = new System.Windows.Forms.TextBox();
            this.ExerciseInducedAnginaCmbo = new System.Windows.Forms.ComboBox();
            this.MaxHRTxt = new System.Windows.Forms.TextBox();
            this.RestECGCmbo = new System.Windows.Forms.ComboBox();
            this.FBSCmbo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SerumCholTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RestBPTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CPTCmbo = new System.Windows.Forms.ComboBox();
            this.SexCmbo = new System.Windows.Forms.ComboBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ThinkingLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SeverityLabel);
            this.groupBox2.Controls.Add(this.PredictionLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(3, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 141);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angiographic Disease Status Prediction";
            // 
            // SeverityLabel
            // 
            this.SeverityLabel.AutoSize = true;
            this.SeverityLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeverityLabel.Location = new System.Drawing.Point(275, 51);
            this.SeverityLabel.Name = "SeverityLabel";
            this.SeverityLabel.Size = new System.Drawing.Size(53, 18);
            this.SeverityLabel.TabIndex = 3;
            this.SeverityLabel.Text = "Blank";
            // 
            // PredictionLabel
            // 
            this.PredictionLabel.AutoSize = true;
            this.PredictionLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredictionLabel.Location = new System.Drawing.Point(22, 51);
            this.PredictionLabel.Name = "PredictionLabel";
            this.PredictionLabel.Size = new System.Drawing.Size(53, 18);
            this.PredictionLabel.TabIndex = 2;
            this.PredictionLabel.Text = "Blank";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 14);
            this.label14.TabIndex = 1;
            this.label14.Text = "Severity: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "Prediction: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.SubmitBtn);
            this.groupBox1.Controls.Add(this.ThalCmbo);
            this.groupBox1.Controls.Add(this.NoOfVesselsColouredCmbo);
            this.groupBox1.Controls.Add(this.SlopeCmbo);
            this.groupBox1.Controls.Add(this.STDepressionTxt);
            this.groupBox1.Controls.Add(this.ExerciseInducedAnginaCmbo);
            this.groupBox1.Controls.Add(this.MaxHRTxt);
            this.groupBox1.Controls.Add(this.RestECGCmbo);
            this.groupBox1.Controls.Add(this.FBSCmbo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.SerumCholTxt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.RestBPTxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CPTCmbo);
            this.groupBox1.Controls.Add(this.SexCmbo);
            this.groupBox1.Controls.Add(this.AgeTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 328);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(401, 299);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(320, 299);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 30;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ThalCmbo
            // 
            this.ThalCmbo.FormattingEnabled = true;
            this.ThalCmbo.Location = new System.Drawing.Point(267, 263);
            this.ThalCmbo.Name = "ThalCmbo";
            this.ThalCmbo.Size = new System.Drawing.Size(100, 22);
            this.ThalCmbo.TabIndex = 29;
            // 
            // NoOfVesselsColouredCmbo
            // 
            this.NoOfVesselsColouredCmbo.FormattingEnabled = true;
            this.NoOfVesselsColouredCmbo.Location = new System.Drawing.Point(267, 223);
            this.NoOfVesselsColouredCmbo.Name = "NoOfVesselsColouredCmbo";
            this.NoOfVesselsColouredCmbo.Size = new System.Drawing.Size(100, 22);
            this.NoOfVesselsColouredCmbo.TabIndex = 28;
            // 
            // SlopeCmbo
            // 
            this.SlopeCmbo.FormattingEnabled = true;
            this.SlopeCmbo.Location = new System.Drawing.Point(267, 168);
            this.SlopeCmbo.Name = "SlopeCmbo";
            this.SlopeCmbo.Size = new System.Drawing.Size(135, 22);
            this.SlopeCmbo.TabIndex = 27;
            // 
            // STDepressionTxt
            // 
            this.STDepressionTxt.Location = new System.Drawing.Point(267, 127);
            this.STDepressionTxt.Name = "STDepressionTxt";
            this.STDepressionTxt.Size = new System.Drawing.Size(100, 20);
            this.STDepressionTxt.TabIndex = 26;
            // 
            // ExerciseInducedAnginaCmbo
            // 
            this.ExerciseInducedAnginaCmbo.FormattingEnabled = true;
            this.ExerciseInducedAnginaCmbo.Location = new System.Drawing.Point(267, 87);
            this.ExerciseInducedAnginaCmbo.Name = "ExerciseInducedAnginaCmbo";
            this.ExerciseInducedAnginaCmbo.Size = new System.Drawing.Size(100, 22);
            this.ExerciseInducedAnginaCmbo.TabIndex = 25;
            // 
            // MaxHRTxt
            // 
            this.MaxHRTxt.Location = new System.Drawing.Point(267, 48);
            this.MaxHRTxt.Name = "MaxHRTxt";
            this.MaxHRTxt.Size = new System.Drawing.Size(100, 20);
            this.MaxHRTxt.TabIndex = 24;
            // 
            // RestECGCmbo
            // 
            this.RestECGCmbo.FormattingEnabled = true;
            this.RestECGCmbo.Location = new System.Drawing.Point(9, 290);
            this.RestECGCmbo.Name = "RestECGCmbo";
            this.RestECGCmbo.Size = new System.Drawing.Size(166, 22);
            this.RestECGCmbo.TabIndex = 23;
            // 
            // FBSCmbo
            // 
            this.FBSCmbo.FormattingEnabled = true;
            this.FBSCmbo.Location = new System.Drawing.Point(9, 246);
            this.FBSCmbo.Name = "FBSCmbo";
            this.FBSCmbo.Size = new System.Drawing.Size(100, 22);
            this.FBSCmbo.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Exercise Induced Angina: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(117, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 14);
            this.label17.TabIndex = 21;
            this.label17.Text = "mg/dl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "ST Depression Induced By Exercise: ";
            // 
            // SerumCholTxt
            // 
            this.SerumCholTxt.Location = new System.Drawing.Point(9, 207);
            this.SerumCholTxt.Name = "SerumCholTxt";
            this.SerumCholTxt.Size = new System.Drawing.Size(100, 20);
            this.SerumCholTxt.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 14);
            this.label12.TabIndex = 11;
            this.label12.Text = "Thal: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(115, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 14);
            this.label16.TabIndex = 19;
            this.label16.Text = "mm HG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "Slope of peak exercise ST Segment: ";
            // 
            // RestBPTxt
            // 
            this.RestBPTxt.Location = new System.Drawing.Point(9, 168);
            this.RestBPTxt.Name = "RestBPTxt";
            this.RestBPTxt.Size = new System.Drawing.Size(100, 20);
            this.RestBPTxt.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "No. of major vessels colored by \r\nFlourosopy: ";
            // 
            // CPTCmbo
            // 
            this.CPTCmbo.FormattingEnabled = true;
            this.CPTCmbo.Location = new System.Drawing.Point(9, 128);
            this.CPTCmbo.Name = "CPTCmbo";
            this.CPTCmbo.Size = new System.Drawing.Size(142, 22);
            this.CPTCmbo.TabIndex = 17;
            // 
            // SexCmbo
            // 
            this.SexCmbo.FormattingEnabled = true;
            this.SexCmbo.Location = new System.Drawing.Point(9, 88);
            this.SexCmbo.Name = "SexCmbo";
            this.SexCmbo.Size = new System.Drawing.Size(100, 22);
            this.SexCmbo.TabIndex = 16;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(9, 48);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(100, 20);
            this.AgeTxt.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 14);
            this.label15.TabIndex = 14;
            this.label15.Text = "Resting Blood Pressure:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max Heart Rate Achieved: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resting ECG Result: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fasting Blood Sugar > 120 mg/dl: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serum Cholestoral: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chest Pain Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age: ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 507);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ThinkingLabel
            // 
            this.ThinkingLabel.AutoSize = true;
            this.ThinkingLabel.Font = new System.Drawing.Font("Palace Script MT", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThinkingLabel.Location = new System.Drawing.Point(14, 6);
            this.ThinkingLabel.Name = "ThinkingLabel";
            this.ThinkingLabel.Size = new System.Drawing.Size(111, 31);
            this.ThinkingLabel.TabIndex = 19;
            this.ThinkingLabel.Text = "Thinking...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 480);
            this.Controls.Add(this.ThinkingLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Patient Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ComboBox ThalCmbo;
        private System.Windows.Forms.ComboBox NoOfVesselsColouredCmbo;
        private System.Windows.Forms.ComboBox SlopeCmbo;
        private System.Windows.Forms.TextBox STDepressionTxt;
        private System.Windows.Forms.ComboBox ExerciseInducedAnginaCmbo;
        private System.Windows.Forms.TextBox MaxHRTxt;
        private System.Windows.Forms.ComboBox RestECGCmbo;
        private System.Windows.Forms.ComboBox FBSCmbo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SerumCholTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RestBPTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CPTCmbo;
        private System.Windows.Forms.ComboBox SexCmbo;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ThinkingLabel;
        private System.Windows.Forms.Label SeverityLabel;
        private System.Windows.Forms.Label PredictionLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

