namespace ConsumerSurveySystem
{
    partial class UserControlRadioButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAgree = new System.Windows.Forms.RadioButton();
            this.rbtnNeutral = new System.Windows.Forms.RadioButton();
            this.rbtnDisagree = new System.Windows.Forms.RadioButton();
            this.rbtnSDisagree = new System.Windows.Forms.RadioButton();
            this.rbtnStronglyAgree = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.White;
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(3, 3);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(425, 50);
            this.txtQuestion.TabIndex = 14;
            this.txtQuestion.Text = "Have you ever used avast antivirus?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtnAgree);
            this.panel1.Controls.Add(this.rbtnNeutral);
            this.panel1.Controls.Add(this.rbtnDisagree);
            this.panel1.Controls.Add(this.rbtnSDisagree);
            this.panel1.Controls.Add(this.rbtnStronglyAgree);
            this.panel1.Location = new System.Drawing.Point(18, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 100);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Strongly\r\nAgree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Neutral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disagree";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Strongly \r\nDisagree";
            // 
            // rbtnAgree
            // 
            this.rbtnAgree.AutoSize = true;
            this.rbtnAgree.Location = new System.Drawing.Point(172, 62);
            this.rbtnAgree.Name = "rbtnAgree";
            this.rbtnAgree.Size = new System.Drawing.Size(14, 13);
            this.rbtnAgree.TabIndex = 4;
            this.rbtnAgree.TabStop = true;
            this.rbtnAgree.UseVisualStyleBackColor = true;
            this.rbtnAgree.CheckedChanged += new System.EventHandler(this.RbtnAgree_CheckedChanged);
            // 
            // rbtnNeutral
            // 
            this.rbtnNeutral.AutoSize = true;
            this.rbtnNeutral.Location = new System.Drawing.Point(128, 62);
            this.rbtnNeutral.Name = "rbtnNeutral";
            this.rbtnNeutral.Size = new System.Drawing.Size(14, 13);
            this.rbtnNeutral.TabIndex = 3;
            this.rbtnNeutral.TabStop = true;
            this.rbtnNeutral.UseVisualStyleBackColor = true;
            this.rbtnNeutral.CheckedChanged += new System.EventHandler(this.RbtnNeutral_CheckedChanged);
            // 
            // rbtnDisagree
            // 
            this.rbtnDisagree.AutoSize = true;
            this.rbtnDisagree.Location = new System.Drawing.Point(78, 62);
            this.rbtnDisagree.Name = "rbtnDisagree";
            this.rbtnDisagree.Size = new System.Drawing.Size(14, 13);
            this.rbtnDisagree.TabIndex = 2;
            this.rbtnDisagree.TabStop = true;
            this.rbtnDisagree.UseVisualStyleBackColor = true;
            this.rbtnDisagree.CheckedChanged += new System.EventHandler(this.RbtnDisagree_CheckedChanged);
            // 
            // rbtnSDisagree
            // 
            this.rbtnSDisagree.AutoSize = true;
            this.rbtnSDisagree.Location = new System.Drawing.Point(24, 62);
            this.rbtnSDisagree.Name = "rbtnSDisagree";
            this.rbtnSDisagree.Size = new System.Drawing.Size(14, 13);
            this.rbtnSDisagree.TabIndex = 1;
            this.rbtnSDisagree.TabStop = true;
            this.rbtnSDisagree.UseVisualStyleBackColor = true;
            this.rbtnSDisagree.CheckedChanged += new System.EventHandler(this.RbtnSDisagree_CheckedChanged);
            // 
            // rbtnStronglyAgree
            // 
            this.rbtnStronglyAgree.AutoSize = true;
            this.rbtnStronglyAgree.Location = new System.Drawing.Point(213, 62);
            this.rbtnStronglyAgree.Name = "rbtnStronglyAgree";
            this.rbtnStronglyAgree.Size = new System.Drawing.Size(14, 13);
            this.rbtnStronglyAgree.TabIndex = 0;
            this.rbtnStronglyAgree.TabStop = true;
            this.rbtnStronglyAgree.UseVisualStyleBackColor = true;
            this.rbtnStronglyAgree.CheckedChanged += new System.EventHandler(this.RbtnStronglyAgree_CheckedChanged);
            // 
            // UserControlRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "UserControlRadioButton";
            this.Size = new System.Drawing.Size(435, 217);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnAgree;
        private System.Windows.Forms.RadioButton rbtnNeutral;
        private System.Windows.Forms.RadioButton rbtnDisagree;
        private System.Windows.Forms.RadioButton rbtnSDisagree;
        private System.Windows.Forms.RadioButton rbtnStronglyAgree;
    }
}
