namespace Solley_Andrew_GettingLoopy
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
            this.ForBtn = new System.Windows.Forms.Button();
            this.WhileBtn = new System.Windows.Forms.Button();
            this.DoWhileBtn = new System.Windows.Forms.Button();
            this.ForEachBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ForBtn
            // 
            this.ForBtn.Location = new System.Drawing.Point(12, 12);
            this.ForBtn.Name = "ForBtn";
            this.ForBtn.Size = new System.Drawing.Size(75, 23);
            this.ForBtn.TabIndex = 0;
            this.ForBtn.Text = "For Loop";
            this.ForBtn.UseVisualStyleBackColor = true;
            this.ForBtn.Click += new System.EventHandler(this.ForBtn_Click);
            // 
            // WhileBtn
            // 
            this.WhileBtn.Location = new System.Drawing.Point(12, 41);
            this.WhileBtn.Name = "WhileBtn";
            this.WhileBtn.Size = new System.Drawing.Size(75, 23);
            this.WhileBtn.TabIndex = 1;
            this.WhileBtn.Text = "While Loop";
            this.WhileBtn.UseVisualStyleBackColor = true;
            this.WhileBtn.Click += new System.EventHandler(this.WhileBtn_Click);
            // 
            // DoWhileBtn
            // 
            this.DoWhileBtn.Location = new System.Drawing.Point(12, 70);
            this.DoWhileBtn.Name = "DoWhileBtn";
            this.DoWhileBtn.Size = new System.Drawing.Size(75, 23);
            this.DoWhileBtn.TabIndex = 2;
            this.DoWhileBtn.Text = "Do-While Loop";
            this.DoWhileBtn.UseVisualStyleBackColor = true;
            this.DoWhileBtn.Click += new System.EventHandler(this.DoWhileBtn_Click);
            // 
            // ForEachBtn
            // 
            this.ForEachBtn.Location = new System.Drawing.Point(12, 99);
            this.ForEachBtn.Name = "ForEachBtn";
            this.ForEachBtn.Size = new System.Drawing.Size(75, 23);
            this.ForEachBtn.TabIndex = 3;
            this.ForEachBtn.Text = "For Each Loop";
            this.ForEachBtn.UseVisualStyleBackColor = true;
            this.ForEachBtn.Click += new System.EventHandler(this.ForEachBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ForEachBtn);
            this.Controls.Add(this.DoWhileBtn);
            this.Controls.Add(this.WhileBtn);
            this.Controls.Add(this.ForBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ForBtn;
        private System.Windows.Forms.Button WhileBtn;
        private System.Windows.Forms.Button DoWhileBtn;
        private System.Windows.Forms.Button ForEachBtn;
    }
}

