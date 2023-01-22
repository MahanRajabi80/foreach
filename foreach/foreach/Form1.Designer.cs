namespace @foreach
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.txtInput4 = new System.Windows.Forms.TextBox();
            this.txtInput5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(334, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(334, 56);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(153, 20);
            this.txtInput1.TabIndex = 0;
            this.txtInput1.Enter += new System.EventHandler(this.txtInput1_Enter);
            this.txtInput1.Leave += new System.EventHandler(this.txtInput1_Leave);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(334, 94);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(153, 20);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.Enter += new System.EventHandler(this.txtInput2_Enter);
            this.txtInput2.Leave += new System.EventHandler(this.txtInput2_Leave);
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(334, 134);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(153, 20);
            this.txtInput3.TabIndex = 2;
            this.txtInput3.Enter += new System.EventHandler(this.txtInput3_Enter);
            this.txtInput3.Leave += new System.EventHandler(this.txtInput3_Leave);
            // 
            // txtInput4
            // 
            this.txtInput4.Location = new System.Drawing.Point(334, 172);
            this.txtInput4.Name = "txtInput4";
            this.txtInput4.Size = new System.Drawing.Size(153, 20);
            this.txtInput4.TabIndex = 3;
            this.txtInput4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtInput4.Enter += new System.EventHandler(this.txtInput4_Enter);
            this.txtInput4.Leave += new System.EventHandler(this.txtInput4_Leave);
            // 
            // txtInput5
            // 
            this.txtInput5.Location = new System.Drawing.Point(334, 209);
            this.txtInput5.Name = "txtInput5";
            this.txtInput5.Size = new System.Drawing.Size(153, 20);
            this.txtInput5.TabIndex = 4;
            this.txtInput5.Enter += new System.EventHandler(this.txtInput5_Enter);
            this.txtInput5.Leave += new System.EventHandler(this.txtInput5_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput5);
            this.Controls.Add(this.txtInput4);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.TextBox txtInput4;
        private System.Windows.Forms.TextBox txtInput5;
    }
}

