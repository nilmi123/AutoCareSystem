﻿namespace AutoCareSystem
{
    partial class rs_Manage_Customers
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
            this.Tab_Manage_Customer = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.rs_Manage_Customers_sub_manage_cus1 = new AutoCareSystem.rs_Manage_Customers_sub_manage_cus();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.rs_Manage_Customers_sub_view_customer1 = new AutoCareSystem.rs_Manage_Customers_sub_view_customer();
            this.Tab_Manage_Customer.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Manage_Customer
            // 
            this.Tab_Manage_Customer.Controls.Add(this.metroTabPage1);
            this.Tab_Manage_Customer.Controls.Add(this.metroTabPage2);
            this.Tab_Manage_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Manage_Customer.Location = new System.Drawing.Point(0, 0);
            this.Tab_Manage_Customer.Name = "Tab_Manage_Customer";
            this.Tab_Manage_Customer.SelectedIndex = 1;
            this.Tab_Manage_Customer.Size = new System.Drawing.Size(741, 550);
            this.Tab_Manage_Customer.TabIndex = 2;
            this.Tab_Manage_Customer.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.rs_Manage_Customers_sub_manage_cus1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(733, 508);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Manage Customer";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // rs_Manage_Customers_sub_manage_cus1
            // 
            this.rs_Manage_Customers_sub_manage_cus1.BackColor = System.Drawing.Color.White;
            this.rs_Manage_Customers_sub_manage_cus1.Location = new System.Drawing.Point(-4, -3);
            this.rs_Manage_Customers_sub_manage_cus1.Name = "rs_Manage_Customers_sub_manage_cus1";
            this.rs_Manage_Customers_sub_manage_cus1.Size = new System.Drawing.Size(733, 508);
            this.rs_Manage_Customers_sub_manage_cus1.TabIndex = 2;
            this.rs_Manage_Customers_sub_manage_cus1.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.rs_Manage_Customers_sub_view_customer1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(733, 508);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "View Customer Details";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // rs_Manage_Customers_sub_view_customer1
            // 
            this.rs_Manage_Customers_sub_view_customer1.BackColor = System.Drawing.Color.White;
            this.rs_Manage_Customers_sub_view_customer1.Location = new System.Drawing.Point(-4, -3);
            this.rs_Manage_Customers_sub_view_customer1.Name = "rs_Manage_Customers_sub_view_customer1";
            this.rs_Manage_Customers_sub_view_customer1.Size = new System.Drawing.Size(741, 508);
            this.rs_Manage_Customers_sub_view_customer1.TabIndex = 1;
            this.rs_Manage_Customers_sub_view_customer1.TabStop = false;
            // 
            // rs_Manage_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Tab_Manage_Customer);
            this.Name = "rs_Manage_Customers";
            this.Size = new System.Drawing.Size(741, 550);
            this.Tab_Manage_Customer.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab_Manage_Customer;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private rs_Manage_Customers_sub_manage_cus rs_Manage_Customers_sub_manage_cus1;
        private rs_Manage_Customers_sub_view_customer rs_Manage_Customers_sub_view_customer1;
    }
}
