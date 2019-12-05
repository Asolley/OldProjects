namespace Solley_Andrew_DataTypes
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
            this.dataType = new System.Windows.Forms.Label();
            this.dataValue = new System.Windows.Forms.Label();
            this.btnInt = new System.Windows.Forms.Button();
            this.btndouble = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnBool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataType
            // 
            this.dataType.AutoSize = true;
            this.dataType.Location = new System.Drawing.Point(165, 12);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(52, 13);
            this.dataType.TabIndex = 0;
            this.dataType.Text = "dataType";
            // 
            // dataValue
            // 
            this.dataValue.AutoSize = true;
            this.dataValue.Location = new System.Drawing.Point(162, 128);
            this.dataValue.Name = "dataValue";
            this.dataValue.Size = new System.Drawing.Size(55, 13);
            this.dataValue.TabIndex = 2;
            this.dataValue.Text = "dataValue";
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(12, 12);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(75, 23);
            this.btnInt.TabIndex = 3;
            this.btnInt.Text = "myInt";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndouble
            // 
            this.btndouble.Location = new System.Drawing.Point(12, 70);
            this.btndouble.Name = "btndouble";
            this.btndouble.Size = new System.Drawing.Size(75, 23);
            this.btndouble.TabIndex = 4;
            this.btndouble.Text = "btndouble";
            this.btndouble.UseVisualStyleBackColor = true;
            this.btndouble.Click += new System.EventHandler(this.btndouble_Click);
            // 
            // btnChar
            // 
            this.btnChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChar.Location = new System.Drawing.Point(12, 41);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(75, 23);
            this.btnChar.TabIndex = 5;
            this.btnChar.Text = "btnChar";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(12, 99);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 6;
            this.btnString.Text = "btnString";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnBool
            // 
            this.btnBool.Location = new System.Drawing.Point(12, 128);
            this.btnBool.Name = "btnBool";
            this.btnBool.Size = new System.Drawing.Size(75, 23);
            this.btnBool.TabIndex = 7;
            this.btnBool.Text = "btnBool";
            this.btnBool.UseVisualStyleBackColor = true;
            this.btnBool.Click += new System.EventHandler(this.btnBool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 197);
            this.Controls.Add(this.btnBool);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btndouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.dataValue);
            this.Controls.Add(this.dataType);
            this.Name = "Form1";
            this.Text = "Data Types and Variables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataType;
        private System.Windows.Forms.Label dataValue;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btndouble;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnBool;
    }
}

