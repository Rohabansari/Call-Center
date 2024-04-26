namespace CallCenter2
{
    partial class DeleteAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAgent));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgentIDToDelete = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent ID to be Deleted";
            // 
            // txtAgentIDToDelete
            // 
            this.txtAgentIDToDelete.Location = new System.Drawing.Point(23, 138);
            this.txtAgentIDToDelete.Multiline = true;
            this.txtAgentIDToDelete.Name = "txtAgentIDToDelete";
            this.txtAgentIDToDelete.Size = new System.Drawing.Size(222, 34);
            this.txtAgentIDToDelete.TabIndex = 1;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Snow;
            this.btn_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_del.Location = new System.Drawing.Point(78, 223);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(142, 37);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Snow;
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.RoyalBlue;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 36);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(275, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 288);
            this.panel1.TabIndex = 4;
            // 
            // DeleteAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(547, 288);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAgentIDToDelete);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAgent";
            this.Text = "DeleteAgent";
            this.Load += new System.EventHandler(this.DeleteAgent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgentIDToDelete;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
    }
}