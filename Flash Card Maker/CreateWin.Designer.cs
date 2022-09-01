
namespace Flash_Card_Maker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flash Card Maker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of Set";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Front";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 23);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Back";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(348, 226);
            this.dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}

