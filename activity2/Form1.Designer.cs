namespace activity2
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
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(239, 113);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(239, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 26);
            this.email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "email";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(239, 64);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(100, 26);
            this.filename.TabIndex = 4;
            this.filename.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filename";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(239, 221);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(89, 37);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
    }
}

