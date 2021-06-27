
namespace EmployeeManager
{
    partial class CreateUpdateEmployeeForm
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(49, 53);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Location = new System.Drawing.Point(90, 46);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(302, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Email.Location = new System.Drawing.Point(90, 74);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(302, 20);
            this.tb_Email.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(49, 81);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            // 
            // tb_Status
            // 
            this.tb_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Status.Location = new System.Drawing.Point(90, 126);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(302, 20);
            this.tb_Status.TabIndex = 5;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(49, 129);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = "Status";
            // 
            // tb_Gender
            // 
            this.tb_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Gender.Location = new System.Drawing.Point(90, 100);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.Size = new System.Drawing.Size(302, 20);
            this.tb_Gender.TabIndex = 7;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(49, 107);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "Gender";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(460, 74);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 46);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(460, 74);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 46);
            this.btn_Create.TabIndex = 9;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // CreateUpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 201);
            this.Controls.Add(this.tb_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Create);
            this.Name = "CreateUpdateEmployeeForm";
            this.Text = "CreateUpdateEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox tb_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Create;
    }
}