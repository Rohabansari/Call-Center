namespace CallCenter2
{
    partial class DeleteBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBilling));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillingIDToDelete = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 52);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter Billing ID to be \r\ndeleted";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBillingIDToDelete
            // 
            this.txtBillingIDToDelete.Location = new System.Drawing.Point(47, 167);
            this.txtBillingIDToDelete.Name = "txtBillingIDToDelete";
            this.txtBillingIDToDelete.Size = new System.Drawing.Size(188, 26);
            this.txtBillingIDToDelete.TabIndex = 24;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Snow;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Back.Location = new System.Drawing.Point(12, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(134, 43);
            this.Back.TabIndex = 25;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Snow;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Delete.Location = new System.Drawing.Point(106, 220);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 38);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(288, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 286);
            this.panel1.TabIndex = 27;
            // 
            // DeleteBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(573, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.txtBillingIDToDelete);
            this.Controls.Add(this.label1);
            this.Name = "DeleteBilling";
            this.Text = "DeleteBilling";
            this.Load += new System.EventHandler(this.DeleteBilling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillingIDToDelete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel panel1;
    }
}