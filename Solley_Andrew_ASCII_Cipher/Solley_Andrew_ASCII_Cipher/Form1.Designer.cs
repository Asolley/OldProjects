namespace Solley_Andrew_ASCII_Cipher
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
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(122, 34);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "Encode =>";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // txtDecoded
            // 
            this.txtDecoded.Location = new System.Drawing.Point(12, 37);
            this.txtDecoded.MaximumSize = new System.Drawing.Size(100, 50);
            this.txtDecoded.MinimumSize = new System.Drawing.Size(100, 50);
            this.txtDecoded.Multiline = true;
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(100, 50);
            this.txtDecoded.TabIndex = 1;
            this.txtDecoded.TabStop = false;
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(203, 37);
            this.txtEncoded.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtEncoded.MinimumSize = new System.Drawing.Size(100, 50);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(100, 50);
            this.txtEncoded.TabIndex = 2;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(122, 63);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "<=Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Decoded Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encoded Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.txtDecoded);
            this.Controls.Add(this.btnEncode);
            this.Name = "Form1";
            this.Text = "ASCII Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

