namespace QueuingCashier
{
    partial class CustomerView
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
            this.pos = new System.Windows.Forms.Label();
            this.lblServe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.Location = new System.Drawing.Point(24, 18);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(115, 20);
            this.pos.TabIndex = 4;
            this.pos.Text = "*Now Serving";
            // 
            // lblServe
            // 
            this.lblServe.AutoSize = true;
            this.lblServe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServe.Location = new System.Drawing.Point(12, 47);
            this.lblServe.Name = "lblServe";
            this.lblServe.Size = new System.Drawing.Size(174, 39);
            this.lblServe.TabIndex = 5;
            this.lblServe.Text = "P - 10007";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 121);
            this.Controls.Add(this.lblServe);
            this.Controls.Add(this.pos);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pos;
        public System.Windows.Forms.Label lblServe;
    }
}