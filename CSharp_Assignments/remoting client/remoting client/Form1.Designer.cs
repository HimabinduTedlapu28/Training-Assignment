
namespace remoting_client
{
    partial class Form1
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnlowest = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(65, 71);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(78, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Enter Number1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(65, 204);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(78, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Enter Number2";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(255, 204);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(255, 71);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHighest
            // 
            this.btnHighest.Location = new System.Drawing.Point(372, 296);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(135, 23);
            this.btnHighest.TabIndex = 5;
            this.btnHighest.Text = "Highest Number";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlowest
            // 
            this.btnlowest.Location = new System.Drawing.Point(601, 296);
            this.btnlowest.Name = "btnlowest";
            this.btnlowest.Size = new System.Drawing.Size(136, 23);
            this.btnlowest.TabIndex = 6;
            this.btnlowest.Text = "Lowest Number";
            this.btnlowest.UseVisualStyleBackColor = true;
            this.btnlowest.Click += new System.EventHandler(this.btnlowest_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(534, 120);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(136, 20);
            this.txtresult.TabIndex = 7;
            this.txtresult.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnlowest);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Highest Number";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnlowest;
        private System.Windows.Forms.TextBox txtresult;
    }
}

