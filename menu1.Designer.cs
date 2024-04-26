namespace CallCenter2
{
    partial class menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu1));
            this.AllTables = new System.Windows.Forms.RadioButton();
            this.DeletedData = new System.Windows.Forms.RadioButton();
            this.View = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AllTables
            // 
            this.AllTables.AutoSize = true;
            this.AllTables.BackColor = System.Drawing.Color.White;
            this.AllTables.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTables.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AllTables.Location = new System.Drawing.Point(38, 74);
            this.AllTables.Name = "AllTables";
            this.AllTables.Size = new System.Drawing.Size(157, 36);
            this.AllTables.TabIndex = 0;
            this.AllTables.TabStop = true;
            this.AllTables.Text = "All Tables";
            this.AllTables.UseVisualStyleBackColor = false;
            // 
            // DeletedData
            // 
            this.DeletedData.AutoSize = true;
            this.DeletedData.BackColor = System.Drawing.Color.White;
            this.DeletedData.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletedData.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DeletedData.Location = new System.Drawing.Point(38, 145);
            this.DeletedData.Name = "DeletedData";
            this.DeletedData.Size = new System.Drawing.Size(303, 36);
            this.DeletedData.TabIndex = 1;
            this.DeletedData.TabStop = true;
            this.DeletedData.Text = "Deleted/Updated Data";
            this.DeletedData.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.White;
            this.View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.View.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.RoyalBlue;
            this.View.Location = new System.Drawing.Point(358, 212);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(180, 45);
            this.View.TabIndex = 2;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 169);
            this.panel1.TabIndex = 3;
            // 
            // menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 432);
            this.Controls.Add(this.AllTables);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeletedData);
            this.Controls.Add(this.View);
            this.Name = "menu1";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AllTables;
        private System.Windows.Forms.RadioButton DeletedData;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Panel panel1;
    }
}