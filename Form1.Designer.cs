
namespace WindowsFormsContacts
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.infotext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CIDtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReadAllContactInfo = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "ReadAllContacts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 377);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 132);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(502, 459);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 36);
            this.listBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "DeleteContact";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(405, 309);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(59, 22);
            this.IDtext.TabIndex = 4;
            this.IDtext.Text = "ID";
            this.IDtext.TextChanged += new System.EventHandler(this.IDtext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "CreateContactInfo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // infotext
            // 
            this.infotext.Location = new System.Drawing.Point(159, 49);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(168, 22);
            this.infotext.TabIndex = 8;
            this.infotext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "AddressPhone";
            // 
            // CIDtext
            // 
            this.CIDtext.Location = new System.Drawing.Point(384, 49);
            this.CIDtext.Name = "CIDtext";
            this.CIDtext.Size = new System.Drawing.Size(71, 22);
            this.CIDtext.TabIndex = 10;
            this.CIDtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "n contact";
            // 
            // ReadAllContactInfo
            // 
            this.ReadAllContactInfo.Location = new System.Drawing.Point(646, 37);
            this.ReadAllContactInfo.Name = "ReadAllContactInfo";
            this.ReadAllContactInfo.Size = new System.Drawing.Size(159, 47);
            this.ReadAllContactInfo.TabIndex = 12;
            this.ReadAllContactInfo.Text = "ReadAllContactInfo";
            this.ReadAllContactInfo.UseVisualStyleBackColor = true;
            this.ReadAllContactInfo.Click += new System.EventHandler(this.ReadAllContactInfo_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(502, 113);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(337, 164);
            this.listBox3.TabIndex = 13;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 516);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.ReadAllContactInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CIDtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infotext);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox infotext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CIDtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReadAllContactInfo;
        private System.Windows.Forms.ListBox listBox3;
    }
}

