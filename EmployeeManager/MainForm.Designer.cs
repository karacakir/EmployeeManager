
namespace EmployeeManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.EmployeesGrid = new System.Windows.Forms.DataGridView();
            this.EmployeesGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteEmployeesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CreateNewEmployee = new System.Windows.Forms.Button();
            this.lbl_Employees = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Page = new System.Windows.Forms.ComboBox();
            this.lbl_Page = new System.Windows.Forms.Label();
            this.lbl_Loading = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).BeginInit();
            this.EmployeesGridContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.AllowUserToAddRows = false;
            this.EmployeesGrid.AllowUserToDeleteRows = false;
            this.EmployeesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGrid.ContextMenuStrip = this.EmployeesGridContextMenuStrip;
            this.EmployeesGrid.Location = new System.Drawing.Point(12, 38);
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.ReadOnly = true;
            this.EmployeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesGrid.Size = new System.Drawing.Size(776, 408);
            this.EmployeesGrid.TabIndex = 0;
            this.EmployeesGrid.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.EmployeesGrid_RowContextMenuStripNeeded);
            // 
            // EmployeesGridContextMenuStrip
            // 
            this.EmployeesGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteEmployeesStripMenuItem,
            this.updateItemStripMenuItem});
            this.EmployeesGridContextMenuStrip.Name = "EmployeesGridContextMenuStrip";
            this.EmployeesGridContextMenuStrip.Size = new System.Drawing.Size(176, 48);
            // 
            // deleteEmployeesStripMenuItem
            // 
            this.deleteEmployeesStripMenuItem.Name = "deleteEmployeesStripMenuItem";
            this.deleteEmployeesStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteEmployeesStripMenuItem.Text = "Delete Employee(s)";
            this.deleteEmployeesStripMenuItem.Click += new System.EventHandler(this.deleteEmployeesStripMenuItem_Click);
            // 
            // updateItemStripMenuItem
            // 
            this.updateItemStripMenuItem.Name = "updateItemStripMenuItem";
            this.updateItemStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateItemStripMenuItem.Text = "Update Item";
            this.updateItemStripMenuItem.Click += new System.EventHandler(this.updateItemStripMenuItem_Click);
            // 
            // btn_CreateNewEmployee
            // 
            this.btn_CreateNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateNewEmployee.Location = new System.Drawing.Point(649, 452);
            this.btn_CreateNewEmployee.Name = "btn_CreateNewEmployee";
            this.btn_CreateNewEmployee.Size = new System.Drawing.Size(139, 23);
            this.btn_CreateNewEmployee.TabIndex = 1;
            this.btn_CreateNewEmployee.Text = "Create New Employee";
            this.btn_CreateNewEmployee.UseVisualStyleBackColor = true;
            this.btn_CreateNewEmployee.Click += new System.EventHandler(this.btn_CreateNewEmployee_Click);
            // 
            // lbl_Employees
            // 
            this.lbl_Employees.AutoSize = true;
            this.lbl_Employees.Location = new System.Drawing.Point(13, 13);
            this.lbl_Employees.Name = "lbl_Employees";
            this.lbl_Employees.Size = new System.Drawing.Size(58, 13);
            this.lbl_Employees.TabIndex = 2;
            this.lbl_Employees.Text = "Employees";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.Location = new System.Drawing.Point(649, 8);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(53, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Page
            // 
            this.cmb_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Page.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Page.FormattingEnabled = true;
            this.cmb_Page.Location = new System.Drawing.Point(51, 454);
            this.cmb_Page.Name = "cmb_Page";
            this.cmb_Page.Size = new System.Drawing.Size(67, 21);
            this.cmb_Page.TabIndex = 4;
            this.cmb_Page.SelectedIndexChanged += new System.EventHandler(this.cmb_Page_SelectedIndexChanged);
            // 
            // lbl_Page
            // 
            this.lbl_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Page.AutoSize = true;
            this.lbl_Page.Location = new System.Drawing.Point(13, 457);
            this.lbl_Page.Name = "lbl_Page";
            this.lbl_Page.Size = new System.Drawing.Size(32, 13);
            this.lbl_Page.TabIndex = 5;
            this.lbl_Page.Text = "Page";
            // 
            // lbl_Loading
            // 
            this.lbl_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Loading.Location = new System.Drawing.Point(12, 197);
            this.lbl_Loading.Name = "lbl_Loading";
            this.lbl_Loading.Size = new System.Drawing.Size(776, 93);
            this.lbl_Loading.TabIndex = 6;
            this.lbl_Loading.Text = "LOADING...";
            this.lbl_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Location = new System.Drawing.Point(713, 8);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.lbl_Loading);
            this.Controls.Add(this.lbl_Page);
            this.Controls.Add(this.cmb_Page);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Employees);
            this.Controls.Add(this.btn_CreateNewEmployee);
            this.Controls.Add(this.EmployeesGrid);
            this.Name = "MainForm";
            this.Text = "Employee Manager";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).EndInit();
            this.EmployeesGridContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesGrid;
        private System.Windows.Forms.ContextMenuStrip EmployeesGridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemStripMenuItem;
        private System.Windows.Forms.Button btn_CreateNewEmployee;
        private System.Windows.Forms.Label lbl_Employees;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Page;
        private System.Windows.Forms.Label lbl_Page;
        private System.Windows.Forms.Label lbl_Loading;
        private System.Windows.Forms.Button btn_Export;
    }
}

