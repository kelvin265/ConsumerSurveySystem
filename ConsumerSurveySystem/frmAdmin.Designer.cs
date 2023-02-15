namespace ConsumerSurveySystem
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.surveyTabPage = new System.Windows.Forms.TabPage();
            this.dataGridViewSurvey = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.surveyTabOptions = new System.Windows.Forms.Panel();
            this.btnRefreshSurvey = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDeleteSurvey = new System.Windows.Forms.Button();
            this.btnUpdateSurvey = new System.Windows.Forms.Button();
            this.btnAddNewSurvey = new System.Windows.Forms.Button();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.surveyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurvey)).BeginInit();
            this.surveyTabOptions.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.adminTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.adminTabControl.Controls.Add(this.surveyTabPage);
            this.adminTabControl.Controls.Add(this.tabPageUser);
            this.adminTabControl.Controls.Add(this.tabPageProduct);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.ItemSize = new System.Drawing.Size(110, 40);
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Multiline = true;
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.Padding = new System.Drawing.Point(12, 6);
            this.adminTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1351, 603);
            this.adminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.adminTabControl.TabIndex = 0;
            // 
            // surveyTabPage
            // 
            this.surveyTabPage.BackColor = System.Drawing.Color.OldLace;
            this.surveyTabPage.Controls.Add(this.dataGridViewSurvey);
            this.surveyTabPage.Controls.Add(this.label1);
            this.surveyTabPage.Controls.Add(this.surveyTabOptions);
            this.surveyTabPage.Location = new System.Drawing.Point(340, 4);
            this.surveyTabPage.Name = "surveyTabPage";
            this.surveyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.surveyTabPage.Size = new System.Drawing.Size(1007, 595);
            this.surveyTabPage.TabIndex = 1;
            this.surveyTabPage.Text = "Surveys";
            // 
            // dataGridViewSurvey
            // 
            this.dataGridViewSurvey.AllowUserToAddRows = false;
            this.dataGridViewSurvey.AllowUserToDeleteRows = false;
            this.dataGridViewSurvey.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSurvey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSurvey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Username,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column11});
            this.dataGridViewSurvey.Location = new System.Drawing.Point(0, 148);
            this.dataGridViewSurvey.Name = "dataGridViewSurvey";
            this.dataGridViewSurvey.Size = new System.Drawing.Size(995, 343);
            this.dataGridViewSurvey.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "survey Id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Product";
            this.Column10.Name = "Column10";
            this.Column10.Width = 140;
            // 
            // Username
            // 
            this.Username.HeaderText = "Title";
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Open Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Close Date";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Description";
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "select";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Survey List";
            // 
            // surveyTabOptions
            // 
            this.surveyTabOptions.BackColor = System.Drawing.Color.White;
            this.surveyTabOptions.Controls.Add(this.btnRefreshSurvey);
            this.surveyTabOptions.Controls.Add(this.btnOpen);
            this.surveyTabOptions.Controls.Add(this.btnDeleteSurvey);
            this.surveyTabOptions.Controls.Add(this.btnUpdateSurvey);
            this.surveyTabOptions.Controls.Add(this.btnAddNewSurvey);
            this.surveyTabOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.surveyTabOptions.Location = new System.Drawing.Point(3, 3);
            this.surveyTabOptions.Name = "surveyTabOptions";
            this.surveyTabOptions.Size = new System.Drawing.Size(1001, 55);
            this.surveyTabOptions.TabIndex = 2;
            // 
            // btnRefreshSurvey
            // 
            this.btnRefreshSurvey.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSurvey.Location = new System.Drawing.Point(772, 8);
            this.btnRefreshSurvey.Name = "btnRefreshSurvey";
            this.btnRefreshSurvey.Size = new System.Drawing.Size(173, 44);
            this.btnRefreshSurvey.TabIndex = 9;
            this.btnRefreshSurvey.Text = "Refresh";
            this.btnRefreshSurvey.UseVisualStyleBackColor = true;
            this.btnRefreshSurvey.Click += new System.EventHandler(this.BtnRefreshSurvey_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(182, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(173, 44);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnDeleteSurvey
            // 
            this.btnDeleteSurvey.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSurvey.Location = new System.Drawing.Point(575, 8);
            this.btnDeleteSurvey.Name = "btnDeleteSurvey";
            this.btnDeleteSurvey.Size = new System.Drawing.Size(173, 44);
            this.btnDeleteSurvey.TabIndex = 7;
            this.btnDeleteSurvey.Text = "Delete";
            this.btnDeleteSurvey.UseVisualStyleBackColor = true;
            this.btnDeleteSurvey.Click += new System.EventHandler(this.BtnDeleteSurvey_Click);
            // 
            // btnUpdateSurvey
            // 
            this.btnUpdateSurvey.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSurvey.Location = new System.Drawing.Point(378, 8);
            this.btnUpdateSurvey.Name = "btnUpdateSurvey";
            this.btnUpdateSurvey.Size = new System.Drawing.Size(175, 44);
            this.btnUpdateSurvey.TabIndex = 6;
            this.btnUpdateSurvey.Text = "Update";
            this.btnUpdateSurvey.UseVisualStyleBackColor = true;
            this.btnUpdateSurvey.Click += new System.EventHandler(this.BtnUpdateSurvey_Click);
            // 
            // btnAddNewSurvey
            // 
            this.btnAddNewSurvey.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSurvey.Location = new System.Drawing.Point(3, 8);
            this.btnAddNewSurvey.Name = "btnAddNewSurvey";
            this.btnAddNewSurvey.Size = new System.Drawing.Size(161, 44);
            this.btnAddNewSurvey.TabIndex = 5;
            this.btnAddNewSurvey.Text = "Add New";
            this.btnAddNewSurvey.UseVisualStyleBackColor = true;
            this.btnAddNewSurvey.Click += new System.EventHandler(this.BtnAddNewSurvey_Click);
            // 
            // tabPageUser
            // 
            this.tabPageUser.BackColor = System.Drawing.Color.OldLace;
            this.tabPageUser.Controls.Add(this.btnRefresh);
            this.tabPageUser.Controls.Add(this.label2);
            this.tabPageUser.Controls.Add(this.dataGridViewUser);
            this.tabPageUser.Controls.Add(this.panel1);
            this.tabPageUser.Location = new System.Drawing.Point(340, 4);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(1007, 595);
            this.tabPageUser.TabIndex = 2;
            this.tabPageUser.Text = "Users";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(861, 146);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 44);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "User List";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 146);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(794, 343);
            this.dataGridViewUser.TabIndex = 6;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "User Id";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Username";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Password";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Type";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "select";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 55);
            this.panel1.TabIndex = 5;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(389, 8);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(173, 44);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(190, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(5, 8);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(161, 44);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Add New";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.BtnAddNewUser_Click);
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.BackColor = System.Drawing.Color.OldLace;
            this.tabPageProduct.Controls.Add(this.btnRefreshProduct);
            this.tabPageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageProduct.Controls.Add(this.label3);
            this.tabPageProduct.Controls.Add(this.panel2);
            this.tabPageProduct.Location = new System.Drawing.Point(340, 4);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(1007, 595);
            this.tabPageProduct.TabIndex = 4;
            this.tabPageProduct.Text = "Products";
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProduct.Location = new System.Drawing.Point(860, 157);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(99, 44);
            this.btnRefreshProduct.TabIndex = 9;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = true;
            this.btnRefreshProduct.Click += new System.EventHandler(this.BtnRefreshProduct_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.Column12,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridViewProduct.Location = new System.Drawing.Point(2, 157);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(795, 343);
            this.dataGridViewProduct.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Type";
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDeleteProduct);
            this.panel2.Controls.Add(this.btnUpdateProduct);
            this.panel2.Controls.Add(this.btnAddNewProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 55);
            this.panel2.TabIndex = 6;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(389, 8);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(173, 44);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(190, 8);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(175, 44);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(5, 8);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(161, 44);
            this.btnAddNewProduct.TabIndex = 0;
            this.btnAddNewProduct.Text = "Add New";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.BtnAddNewProduct_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 603);
            this.Controls.Add(this.adminTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.adminTabControl.ResumeLayout(false);
            this.surveyTabPage.ResumeLayout(false);
            this.surveyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurvey)).EndInit();
            this.surveyTabOptions.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage surveyTabPage;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Panel surveyTabOptions;
        private System.Windows.Forms.DataGridView dataGridViewSurvey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDeleteSurvey;
        private System.Windows.Forms.Button btnUpdateSurvey;
        private System.Windows.Forms.Button btnAddNewSurvey;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnRefreshSurvey;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
    }
}