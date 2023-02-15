namespace ConsumerSurveySystem
{
    partial class frmNewQuestion
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
            this.panelQType = new System.Windows.Forms.Panel();
            this.panelQuestionAndAnswer = new System.Windows.Forms.Panel();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbQAnswers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuestion2 = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.rbtnRatingScale = new System.Windows.Forms.RadioButton();
            this.rbtnDropdown = new System.Windows.Forms.RadioButton();
            this.rbtnYesOrNo = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQType.SuspendLayout();
            this.panelQuestionAndAnswer.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQType
            // 
            this.panelQType.BackColor = System.Drawing.Color.OldLace;
            this.panelQType.Controls.Add(this.panelQuestionAndAnswer);
            this.panelQType.Controls.Add(this.panelQuestion);
            this.panelQType.Controls.Add(this.btnNext);
            this.panelQType.Controls.Add(this.panel);
            this.panelQType.Controls.Add(this.rbtnRatingScale);
            this.panelQType.Controls.Add(this.rbtnDropdown);
            this.panelQType.Controls.Add(this.rbtnYesOrNo);
            this.panelQType.Controls.Add(this.btnPreview);
            this.panelQType.Controls.Add(this.label1);
            this.panelQType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQType.Location = new System.Drawing.Point(0, 0);
            this.panelQType.Name = "panelQType";
            this.panelQType.Size = new System.Drawing.Size(668, 345);
            this.panelQType.TabIndex = 0;
            // 
            // panelQuestionAndAnswer
            // 
            this.panelQuestionAndAnswer.Controls.Add(this.txtAnswer);
            this.panelQuestionAndAnswer.Controls.Add(this.btnAdd);
            this.panelQuestionAndAnswer.Controls.Add(this.cmbQAnswers);
            this.panelQuestionAndAnswer.Controls.Add(this.label5);
            this.panelQuestionAndAnswer.Controls.Add(this.label4);
            this.panelQuestionAndAnswer.Controls.Add(this.label3);
            this.panelQuestionAndAnswer.Controls.Add(this.txtQuestion2);
            this.panelQuestionAndAnswer.Controls.Add(this.btnSave2);
            this.panelQuestionAndAnswer.Controls.Add(this.btnBack2);
            this.panelQuestionAndAnswer.Location = new System.Drawing.Point(0, 0);
            this.panelQuestionAndAnswer.Name = "panelQuestionAndAnswer";
            this.panelQuestionAndAnswer.Size = new System.Drawing.Size(665, 345);
            this.panelQuestionAndAnswer.TabIndex = 5;
            this.panelQuestionAndAnswer.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(47, 192);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(183, 22);
            this.txtAnswer.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(256, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmbQAnswers
            // 
            this.cmbQAnswers.FormattingEnabled = true;
            this.cmbQAnswers.Location = new System.Drawing.Point(383, 192);
            this.cmbQAnswers.Name = "cmbQAnswers";
            this.cmbQAnswers.Size = new System.Drawing.Size(223, 24);
            this.cmbQAnswers.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Answers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Please enter your answer here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Please enter your question here";
            // 
            // txtQuestion2
            // 
            this.txtQuestion2.Location = new System.Drawing.Point(47, 63);
            this.txtQuestion2.Multiline = true;
            this.txtQuestion2.Name = "txtQuestion2";
            this.txtQuestion2.Size = new System.Drawing.Size(559, 79);
            this.txtQuestion2.TabIndex = 16;
            // 
            // btnSave2
            // 
            this.btnSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(542, 272);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(113, 38);
            this.btnSave2.TabIndex = 15;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.BtnSave2_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(10, 272);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(113, 38);
            this.btnBack2.TabIndex = 14;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.BtnBack2_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.label2);
            this.panelQuestion.Controls.Add(this.txtQuestion1);
            this.panelQuestion.Controls.Add(this.btnSave1);
            this.panelQuestion.Controls.Add(this.btnBack1);
            this.panelQuestion.Location = new System.Drawing.Point(0, 3);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(668, 342);
            this.panelQuestion.TabIndex = 20;
            this.panelQuestion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter your question here";
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Location = new System.Drawing.Point(45, 112);
            this.txtQuestion1.Multiline = true;
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.Size = new System.Drawing.Size(559, 79);
            this.txtQuestion1.TabIndex = 3;
            // 
            // btnSave1
            // 
            this.btnSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Location = new System.Drawing.Point(543, 294);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(113, 38);
            this.btnSave1.TabIndex = 2;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.BtnSave1_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(11, 294);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(113, 38);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.BtnBack1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(18, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 41);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(140, 33);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(516, 278);
            this.panel.TabIndex = 18;
            // 
            // rbtnRatingScale
            // 
            this.rbtnRatingScale.AutoSize = true;
            this.rbtnRatingScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRatingScale.Location = new System.Drawing.Point(18, 186);
            this.rbtnRatingScale.Name = "rbtnRatingScale";
            this.rbtnRatingScale.Size = new System.Drawing.Size(130, 28);
            this.rbtnRatingScale.TabIndex = 17;
            this.rbtnRatingScale.TabStop = true;
            this.rbtnRatingScale.Text = "RadioButton";
            this.rbtnRatingScale.UseVisualStyleBackColor = true;
            // 
            // rbtnDropdown
            // 
            this.rbtnDropdown.AutoSize = true;
            this.rbtnDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDropdown.Location = new System.Drawing.Point(18, 148);
            this.rbtnDropdown.Name = "rbtnDropdown";
            this.rbtnDropdown.Size = new System.Drawing.Size(116, 28);
            this.rbtnDropdown.TabIndex = 16;
            this.rbtnDropdown.TabStop = true;
            this.rbtnDropdown.Text = "Dropdown";
            this.rbtnDropdown.UseVisualStyleBackColor = true;
            // 
            // rbtnYesOrNo
            // 
            this.rbtnYesOrNo.AutoSize = true;
            this.rbtnYesOrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYesOrNo.Location = new System.Drawing.Point(18, 107);
            this.rbtnYesOrNo.Name = "rbtnYesOrNo";
            this.rbtnYesOrNo.Size = new System.Drawing.Size(112, 28);
            this.rbtnYesOrNo.TabIndex = 15;
            this.rbtnYesOrNo.TabStop = true;
            this.rbtnYesOrNo.Text = "Yes or No";
            this.rbtnYesOrNo.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(18, 235);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(106, 41);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Question Type";
            // 
            // frmNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 345);
            this.Controls.Add(this.panelQType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewQuestion";
            this.Load += new System.EventHandler(this.FrmNewQuestion_Load);
            this.panelQType.ResumeLayout(false);
            this.panelQType.PerformLayout();
            this.panelQuestionAndAnswer.ResumeLayout(false);
            this.panelQuestionAndAnswer.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQType;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton rbtnRatingScale;
        private System.Windows.Forms.RadioButton rbtnDropdown;
        private System.Windows.Forms.RadioButton rbtnYesOrNo;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuestion1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Panel panelQuestionAndAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbQAnswers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuestion2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnBack2;
    }
}