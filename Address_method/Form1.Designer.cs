namespace Address_method
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAddressResult = new System.Windows.Forms.TextBox();
            this.txtNoLines = new System.Windows.Forms.TextBox();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(436, 176);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Test";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(13, 62);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(403, 111);
            this.txtAddress.TabIndex = 2;
            // 
            // txtAddressResult
            // 
            this.txtAddressResult.Location = new System.Drawing.Point(436, 62);
            this.txtAddressResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressResult.Multiline = true;
            this.txtAddressResult.Name = "txtAddressResult";
            this.txtAddressResult.Size = new System.Drawing.Size(403, 111);
            this.txtAddressResult.TabIndex = 2;
            // 
            // txtNoLines
            // 
            this.txtNoLines.Location = new System.Drawing.Point(740, 179);
            this.txtNoLines.Name = "txtNoLines";
            this.txtNoLines.Size = new System.Drawing.Size(100, 22);
            this.txtNoLines.TabIndex = 3;
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(165, 179);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.Size = new System.Drawing.Size(251, 22);
            this.txtDirect.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory Address";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 17);
            this.lblText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 217);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirect);
            this.Controls.Add(this.txtNoLines);
            this.Controls.Add(this.txtAddressResult);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Address Method Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAddressResult;
        private System.Windows.Forms.TextBox txtNoLines;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblText;
    }
}

