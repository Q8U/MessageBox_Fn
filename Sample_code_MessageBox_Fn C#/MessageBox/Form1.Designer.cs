namespace MessageBox
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_error = new System.Windows.Forms.Button();
            this.btn_q = new System.Windows.Forms.Button();
            this.btn_warning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(50, 21);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(234, 48);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "پیام تایید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(50, 163);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(234, 48);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "پیام اطلاعی";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(50, 387);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(234, 48);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "پیام ایست";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_error
            // 
            this.btn_error.Location = new System.Drawing.Point(50, 90);
            this.btn_error.Name = "btn_error";
            this.btn_error.Size = new System.Drawing.Size(234, 48);
            this.btn_error.TabIndex = 3;
            this.btn_error.Text = "پیام حذف";
            this.btn_error.UseVisualStyleBackColor = true;
            this.btn_error.Click += new System.EventHandler(this.btn_error_Click);
            // 
            // btn_q
            // 
            this.btn_q.Location = new System.Drawing.Point(50, 238);
            this.btn_q.Name = "btn_q";
            this.btn_q.Size = new System.Drawing.Size(234, 48);
            this.btn_q.TabIndex = 4;
            this.btn_q.Text = "پیام پرسشی";
            this.btn_q.UseVisualStyleBackColor = true;
            this.btn_q.Click += new System.EventHandler(this.btn_q_Click);
            // 
            // btn_warning
            // 
            this.btn_warning.Location = new System.Drawing.Point(50, 315);
            this.btn_warning.Name = "btn_warning";
            this.btn_warning.Size = new System.Drawing.Size(234, 48);
            this.btn_warning.TabIndex = 5;
            this.btn_warning.Text = "پیام اخطار";
            this.btn_warning.UseVisualStyleBackColor = true;
            this.btn_warning.Click += new System.EventHandler(this.btn_warning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 459);
            this.Controls.Add(this.btn_warning);
            this.Controls.Add(this.btn_q);
            this.Controls.Add(this.btn_error);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_error;
        private System.Windows.Forms.Button btn_q;
        private System.Windows.Forms.Button btn_warning;
    }
}

