namespace CallCenter1
{
    partial class Form2
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
            this.but_Agent = new System.Windows.Forms.RadioButton();
            this.but_Call = new System.Windows.Forms.RadioButton();
            this.but_calllog = new System.Windows.Forms.RadioButton();
            this.but_oper = new System.Windows.Forms.RadioButton();
            this.but_HR = new System.Windows.Forms.RadioButton();
            this.but_customer = new System.Windows.Forms.RadioButton();
            this.but_leads = new System.Windows.Forms.RadioButton();
            this.but_it = new System.Windows.Forms.RadioButton();
            this.but_dept = new System.Windows.Forms.RadioButton();
            this.but_cust_exp = new System.Windows.Forms.RadioButton();
            this.but_cust_service = new System.Windows.Forms.RadioButton();
            this.but_interviews = new System.Windows.Forms.RadioButton();
            this.but_sales = new System.Windows.Forms.RadioButton();
            this.but_returns = new System.Windows.Forms.RadioButton();
            this.but_QA = new System.Windows.Forms.RadioButton();
            this.but_order = new System.Windows.Forms.RadioButton();
            this.but_training = new System.Windows.Forms.RadioButton();
            this.but_technical = new System.Windows.Forms.RadioButton();
            this.but_sales_sup = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_Agent
            // 
            this.but_Agent.AutoSize = true;
            this.but_Agent.Location = new System.Drawing.Point(31, 42);
            this.but_Agent.Name = "but_Agent";
            this.but_Agent.Size = new System.Drawing.Size(120, 24);
            this.but_Agent.TabIndex = 0;
            this.but_Agent.TabStop = true;
            this.but_Agent.Text = "Agent Table";
            this.but_Agent.UseVisualStyleBackColor = true;
            this.but_Agent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // but_Call
            // 
            this.but_Call.AutoSize = true;
            this.but_Call.Location = new System.Drawing.Point(31, 89);
            this.but_Call.Name = "but_Call";
            this.but_Call.Size = new System.Drawing.Size(103, 24);
            this.but_Call.TabIndex = 1;
            this.but_Call.TabStop = true;
            this.but_Call.Text = "Call Table";
            this.but_Call.UseVisualStyleBackColor = true;
            this.but_Call.CheckedChanged += new System.EventHandler(this.but_Call_CheckedChanged);
            // 
            // but_calllog
            // 
            this.but_calllog.AutoSize = true;
            this.but_calllog.Location = new System.Drawing.Point(31, 144);
            this.but_calllog.Name = "but_calllog";
            this.but_calllog.Size = new System.Drawing.Size(87, 24);
            this.but_calllog.TabIndex = 2;
            this.but_calllog.TabStop = true;
            this.but_calllog.Text = "CallLog";
            this.but_calllog.UseVisualStyleBackColor = true;
            this.but_calllog.CheckedChanged += new System.EventHandler(this.but_calllog_CheckedChanged);
            // 
            // but_oper
            // 
            this.but_oper.AutoSize = true;
            this.but_oper.Location = new System.Drawing.Point(634, 144);
            this.but_oper.Name = "but_oper";
            this.but_oper.Size = new System.Drawing.Size(201, 24);
            this.but_oper.TabIndex = 3;
            this.but_oper.TabStop = true;
            this.but_oper.Text = "Operations Department";
            this.but_oper.UseVisualStyleBackColor = true;
            this.but_oper.CheckedChanged += new System.EventHandler(this.but_oper_CheckedChanged);
            // 
            // but_HR
            // 
            this.but_HR.AutoSize = true;
            this.but_HR.Location = new System.Drawing.Point(225, 42);
            this.but_HR.Name = "but_HR";
            this.but_HR.Size = new System.Drawing.Size(58, 24);
            this.but_HR.TabIndex = 4;
            this.but_HR.TabStop = true;
            this.but_HR.Text = "HR";
            this.but_HR.UseVisualStyleBackColor = true;
            this.but_HR.CheckedChanged += new System.EventHandler(this.but_HR_CheckedChanged);
            // 
            // but_customer
            // 
            this.but_customer.AutoSize = true;
            this.but_customer.Location = new System.Drawing.Point(31, 193);
            this.but_customer.Name = "but_customer";
            this.but_customer.Size = new System.Drawing.Size(111, 24);
            this.but_customer.TabIndex = 5;
            this.but_customer.TabStop = true;
            this.but_customer.Text = "Customers";
            this.but_customer.UseVisualStyleBackColor = true;
            this.but_customer.CheckedChanged += new System.EventHandler(this.but_customer_CheckedChanged);
            // 
            // but_leads
            // 
            this.but_leads.AutoSize = true;
            this.but_leads.Location = new System.Drawing.Point(225, 193);
            this.but_leads.Name = "but_leads";
            this.but_leads.Size = new System.Drawing.Size(78, 24);
            this.but_leads.TabIndex = 6;
            this.but_leads.TabStop = true;
            this.but_leads.Text = "Leads";
            this.but_leads.UseVisualStyleBackColor = true;
            this.but_leads.CheckedChanged += new System.EventHandler(this.but_leads_CheckedChanged);
            // 
            // but_it
            // 
            this.but_it.AutoSize = true;
            this.but_it.Location = new System.Drawing.Point(634, 193);
            this.but_it.Name = "but_it";
            this.but_it.Size = new System.Drawing.Size(137, 24);
            this.but_it.TabIndex = 7;
            this.but_it.TabStop = true;
            this.but_it.Text = "IT Department";
            this.but_it.UseVisualStyleBackColor = true;
            this.but_it.CheckedChanged += new System.EventHandler(this.but_it_CheckedChanged);
            // 
            // but_dept
            // 
            this.but_dept.AutoSize = true;
            this.but_dept.Location = new System.Drawing.Point(225, 89);
            this.but_dept.Name = "but_dept";
            this.but_dept.Size = new System.Drawing.Size(140, 24);
            this.but_dept.TabIndex = 8;
            this.but_dept.TabStop = true;
            this.but_dept.Text = "All Department";
            this.but_dept.UseVisualStyleBackColor = true;
            this.but_dept.CheckedChanged += new System.EventHandler(this.but_dept_CheckedChanged);
            // 
            // but_cust_exp
            // 
            this.but_cust_exp.AutoSize = true;
            this.but_cust_exp.Location = new System.Drawing.Point(389, 243);
            this.but_cust_exp.Name = "but_cust_exp";
            this.but_cust_exp.Size = new System.Drawing.Size(186, 24);
            this.but_cust_exp.TabIndex = 9;
            this.but_cust_exp.TabStop = true;
            this.but_cust_exp.Text = "Customer Experience";
            this.but_cust_exp.UseVisualStyleBackColor = true;
            this.but_cust_exp.CheckedChanged += new System.EventHandler(this.but_cust_exp_CheckedChanged);
            // 
            // but_cust_service
            // 
            this.but_cust_service.AutoSize = true;
            this.but_cust_service.Location = new System.Drawing.Point(31, 243);
            this.but_cust_service.Name = "but_cust_service";
            this.but_cust_service.Size = new System.Drawing.Size(159, 24);
            this.but_cust_service.TabIndex = 10;
            this.but_cust_service.TabStop = true;
            this.but_cust_service.Text = "Customer Service";
            this.but_cust_service.UseVisualStyleBackColor = true;
            this.but_cust_service.CheckedChanged += new System.EventHandler(this.but_cust_service_CheckedChanged);
            // 
            // but_interviews
            // 
            this.but_interviews.AutoSize = true;
            this.but_interviews.Location = new System.Drawing.Point(225, 144);
            this.but_interviews.Name = "but_interviews";
            this.but_interviews.Size = new System.Drawing.Size(105, 24);
            this.but_interviews.TabIndex = 11;
            this.but_interviews.TabStop = true;
            this.but_interviews.Text = "Interviews";
            this.but_interviews.UseVisualStyleBackColor = true;
            this.but_interviews.CheckedChanged += new System.EventHandler(this.but_interviews_CheckedChanged);
            // 
            // but_sales
            // 
            this.but_sales.AutoSize = true;
            this.but_sales.Location = new System.Drawing.Point(225, 243);
            this.but_sales.Name = "but_sales";
            this.but_sales.Size = new System.Drawing.Size(74, 24);
            this.but_sales.TabIndex = 12;
            this.but_sales.TabStop = true;
            this.but_sales.Text = "Sales";
            this.but_sales.UseVisualStyleBackColor = true;
            this.but_sales.CheckedChanged += new System.EventHandler(this.but_sales_CheckedChanged);
            // 
            // but_returns
            // 
            this.but_returns.AutoSize = true;
            this.but_returns.Location = new System.Drawing.Point(634, 42);
            this.but_returns.Name = "but_returns";
            this.but_returns.Size = new System.Drawing.Size(170, 24);
            this.but_returns.TabIndex = 13;
            this.but_returns.TabStop = true;
            this.but_returns.Text = "Returns & Exchange";
            this.but_returns.UseVisualStyleBackColor = true;
            this.but_returns.CheckedChanged += new System.EventHandler(this.but_returns_CheckedChanged);
            // 
            // but_QA
            // 
            this.but_QA.AutoSize = true;
            this.but_QA.Location = new System.Drawing.Point(634, 89);
            this.but_QA.Name = "but_QA";
            this.but_QA.Size = new System.Drawing.Size(162, 24);
            this.but_QA.TabIndex = 14;
            this.but_QA.TabStop = true;
            this.but_QA.Text = "Quality Assurance";
            this.but_QA.UseVisualStyleBackColor = true;
            this.but_QA.CheckedChanged += new System.EventHandler(this.but_QA_CheckedChanged);
            // 
            // but_order
            // 
            this.but_order.AutoSize = true;
            this.but_order.Location = new System.Drawing.Point(389, 42);
            this.but_order.Name = "but_order";
            this.but_order.Size = new System.Drawing.Size(156, 24);
            this.but_order.TabIndex = 15;
            this.but_order.TabStop = true;
            this.but_order.Text = "Order Processing";
            this.but_order.UseVisualStyleBackColor = true;
            this.but_order.CheckedChanged += new System.EventHandler(this.but_order_CheckedChanged);
            // 
            // but_training
            // 
            this.but_training.AutoSize = true;
            this.but_training.Location = new System.Drawing.Point(389, 193);
            this.but_training.Name = "but_training";
            this.but_training.Size = new System.Drawing.Size(90, 24);
            this.but_training.TabIndex = 16;
            this.but_training.TabStop = true;
            this.but_training.Text = "Training";
            this.but_training.UseVisualStyleBackColor = true;
            this.but_training.CheckedChanged += new System.EventHandler(this.but_training_CheckedChanged);
            // 
            // but_technical
            // 
            this.but_technical.AutoSize = true;
            this.but_technical.Location = new System.Drawing.Point(389, 144);
            this.but_technical.Name = "but_technical";
            this.but_technical.Size = new System.Drawing.Size(162, 24);
            this.but_technical.TabIndex = 17;
            this.but_technical.TabStop = true;
            this.but_technical.Text = "Technical Support";
            this.but_technical.UseVisualStyleBackColor = true;
            this.but_technical.CheckedChanged += new System.EventHandler(this.but_technical_CheckedChanged);
            // 
            // but_sales_sup
            // 
            this.but_sales_sup.AutoSize = true;
            this.but_sales_sup.Location = new System.Drawing.Point(389, 89);
            this.but_sales_sup.Name = "but_sales_sup";
            this.but_sales_sup.Size = new System.Drawing.Size(135, 24);
            this.but_sales_sup.TabIndex = 18;
            this.but_sales_sup.TabStop = true;
            this.but_sales_sup.Text = "Sales Support";
            this.but_sales_sup.UseVisualStyleBackColor = true;
            this.but_sales_sup.CheckedChanged += new System.EventHandler(this.but_sales_sup_CheckedChanged);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(328, 316);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(223, 35);
            this.View.TabIndex = 19;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.View);
            this.Controls.Add(this.but_sales_sup);
            this.Controls.Add(this.but_technical);
            this.Controls.Add(this.but_training);
            this.Controls.Add(this.but_order);
            this.Controls.Add(this.but_QA);
            this.Controls.Add(this.but_returns);
            this.Controls.Add(this.but_sales);
            this.Controls.Add(this.but_interviews);
            this.Controls.Add(this.but_cust_service);
            this.Controls.Add(this.but_cust_exp);
            this.Controls.Add(this.but_dept);
            this.Controls.Add(this.but_it);
            this.Controls.Add(this.but_leads);
            this.Controls.Add(this.but_customer);
            this.Controls.Add(this.but_HR);
            this.Controls.Add(this.but_oper);
            this.Controls.Add(this.but_calllog);
            this.Controls.Add(this.but_Call);
            this.Controls.Add(this.but_Agent);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton but_Agent;
        private System.Windows.Forms.RadioButton but_Call;
        private System.Windows.Forms.RadioButton but_calllog;
        private System.Windows.Forms.RadioButton but_oper;
        private System.Windows.Forms.RadioButton but_HR;
        private System.Windows.Forms.RadioButton but_customer;
        private System.Windows.Forms.RadioButton but_leads;
        private System.Windows.Forms.RadioButton but_it;
        private System.Windows.Forms.RadioButton but_dept;
        private System.Windows.Forms.RadioButton but_cust_exp;
        private System.Windows.Forms.RadioButton but_cust_service;
        private System.Windows.Forms.RadioButton but_interviews;
        private System.Windows.Forms.RadioButton but_sales;
        private System.Windows.Forms.RadioButton but_returns;
        private System.Windows.Forms.RadioButton but_QA;
        private System.Windows.Forms.RadioButton but_order;
        private System.Windows.Forms.RadioButton but_training;
        private System.Windows.Forms.RadioButton but_technical;
        private System.Windows.Forms.RadioButton but_sales_sup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button View;
    }
}