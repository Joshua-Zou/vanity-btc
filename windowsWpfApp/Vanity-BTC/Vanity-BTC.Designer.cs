
namespace Vanity_BTC
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

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exampleText = new System.Windows.Forms.Label();
            this.caseSensitive = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.suffix = new System.Windows.Forms.RadioButton();
            this.anywhere = new System.Windows.Forms.RadioButton();
            this.threadCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.difficultyIndic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProbabilityIndic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.generatedIndic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.speedIndic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusIndic = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.probabilityIndicNum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.addressIndic = new System.Windows.Forms.TextBox();
            this.secretIndic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(29, 68);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(205, 20);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.updateExample);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "eg.";
            // 
            // exampleText
            // 
            this.exampleText.AutoSize = true;
            this.exampleText.Font = new System.Drawing.Font("SimHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleText.Location = new System.Drawing.Point(386, 70);
            this.exampleText.Name = "exampleText";
            this.exampleText.Size = new System.Drawing.Size(245, 14);
            this.exampleText.TabIndex = 3;
            this.exampleText.Text = "34xp4vRoCGJym3xR7yCVPFHoCNxv4Twseo";
            // 
            // caseSensitive
            // 
            this.caseSensitive.AutoSize = true;
            this.caseSensitive.Location = new System.Drawing.Point(29, 113);
            this.caseSensitive.Name = "caseSensitive";
            this.caseSensitive.Size = new System.Drawing.Size(96, 17);
            this.caseSensitive.TabIndex = 4;
            this.caseSensitive.Text = "Case-Sensitive";
            this.caseSensitive.UseVisualStyleBackColor = true;
            this.caseSensitive.CheckedChanged += new System.EventHandler(this.updateExample);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 153);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Prefix";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.updateExample);
            // 
            // suffix
            // 
            this.suffix.AutoSize = true;
            this.suffix.Location = new System.Drawing.Point(98, 153);
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(51, 17);
            this.suffix.TabIndex = 7;
            this.suffix.Text = "Suffix";
            this.suffix.UseVisualStyleBackColor = true;
            this.suffix.CheckedChanged += new System.EventHandler(this.updateExample);
            // 
            // anywhere
            // 
            this.anywhere.AutoSize = true;
            this.anywhere.Location = new System.Drawing.Point(169, 153);
            this.anywhere.Name = "anywhere";
            this.anywhere.Size = new System.Drawing.Size(72, 17);
            this.anywhere.TabIndex = 8;
            this.anywhere.Text = "Anywhere";
            this.anywhere.UseVisualStyleBackColor = true;
            this.anywhere.CheckedChanged += new System.EventHandler(this.updateExample);
            // 
            // threadCount
            // 
            this.threadCount.Location = new System.Drawing.Point(29, 211);
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(120, 20);
            this.threadCount.TabIndex = 9;
            this.threadCount.ValueChanged += new System.EventHandler(this.threadCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thread Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Difficulty";
            // 
            // difficultyIndic
            // 
            this.difficultyIndic.Location = new System.Drawing.Point(361, 133);
            this.difficultyIndic.Name = "difficultyIndic";
            this.difficultyIndic.ReadOnly = true;
            this.difficultyIndic.Size = new System.Drawing.Size(100, 20);
            this.difficultyIndic.TabIndex = 12;
            this.difficultyIndic.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "50% probability";
            // 
            // ProbabilityIndic
            // 
            this.ProbabilityIndic.Location = new System.Drawing.Point(361, 195);
            this.ProbabilityIndic.Name = "ProbabilityIndic";
            this.ProbabilityIndic.ReadOnly = true;
            this.ProbabilityIndic.Size = new System.Drawing.Size(100, 20);
            this.ProbabilityIndic.TabIndex = 14;
            this.ProbabilityIndic.Text = "1 addresses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Generated";
            // 
            // generatedIndic
            // 
            this.generatedIndic.Location = new System.Drawing.Point(486, 133);
            this.generatedIndic.Name = "generatedIndic";
            this.generatedIndic.ReadOnly = true;
            this.generatedIndic.Size = new System.Drawing.Size(100, 20);
            this.generatedIndic.TabIndex = 16;
            this.generatedIndic.Text = "0 addresses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Speed";
            // 
            // speedIndic
            // 
            this.speedIndic.Location = new System.Drawing.Point(486, 195);
            this.speedIndic.Name = "speedIndic";
            this.speedIndic.ReadOnly = true;
            this.speedIndic.Size = new System.Drawing.Size(100, 20);
            this.speedIndic.TabIndex = 18;
            this.speedIndic.Text = "0 addr/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Status";
            // 
            // statusIndic
            // 
            this.statusIndic.Location = new System.Drawing.Point(486, 256);
            this.statusIndic.Name = "statusIndic";
            this.statusIndic.ReadOnly = true;
            this.statusIndic.Size = new System.Drawing.Size(100, 20);
            this.statusIndic.TabIndex = 20;
            this.statusIndic.Text = "Waiting";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(247, 328);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(293, 23);
            this.progressBar.TabIndex = 21;
            // 
            // probabilityIndicNum
            // 
            this.probabilityIndicNum.AutoSize = true;
            this.probabilityIndicNum.Location = new System.Drawing.Point(546, 325);
            this.probabilityIndicNum.Name = "probabilityIndicNum";
            this.probabilityIndicNum.Size = new System.Drawing.Size(21, 13);
            this.probabilityIndicNum.TabIndex = 22;
            this.probabilityIndicNum.Text = "0%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "probability";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.secretIndic);
            this.groupBox1.Controls.Add(this.addressIndic);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(29, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 93);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Private key:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Address: ";
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(33, 91);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(201, 13);
            this.errorMsg.TabIndex = 25;
            this.errorMsg.Text = "No spaces or special characters allowed!";
            this.errorMsg.Visible = false;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(188)))));
            this.GenerateBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.Location = new System.Drawing.Point(29, 256);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(107, 34);
            this.GenerateBtn.TabIndex = 26;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.startGeneration);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(211)))), ((int)(((byte)(188)))));
            this.stopBtn.Enabled = false;
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(169, 256);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(107, 34);
            this.stopBtn.TabIndex = 27;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopThreads);
            // 
            // addressIndic
            // 
            this.addressIndic.BackColor = System.Drawing.SystemColors.Window;
            this.addressIndic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressIndic.Location = new System.Drawing.Point(113, 27);
            this.addressIndic.Name = "addressIndic";
            this.addressIndic.ReadOnly = true;
            this.addressIndic.Size = new System.Drawing.Size(430, 13);
            this.addressIndic.TabIndex = 2;
            // 
            // secretIndic
            // 
            this.secretIndic.BackColor = System.Drawing.SystemColors.Window;
            this.secretIndic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secretIndic.Location = new System.Drawing.Point(127, 58);
            this.secretIndic.Name = "secretIndic";
            this.secretIndic.ReadOnly = true;
            this.secretIndic.Size = new System.Drawing.Size(430, 13);
            this.secretIndic.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 665);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.probabilityIndicNum);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusIndic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.speedIndic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generatedIndic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProbabilityIndic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.difficultyIndic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.threadCount);
            this.Controls.Add(this.anywhere);
            this.Controls.Add(this.suffix);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.caseSensitive);
            this.Controls.Add(this.exampleText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vanity BTC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //#endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exampleText;
        private System.Windows.Forms.CheckBox caseSensitive;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton suffix;
        private System.Windows.Forms.RadioButton anywhere;
        private System.Windows.Forms.NumericUpDown threadCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox difficultyIndic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProbabilityIndic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox generatedIndic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox speedIndic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox statusIndic;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label probabilityIndicNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox addressIndic;
        private System.Windows.Forms.TextBox secretIndic;
    }
}

