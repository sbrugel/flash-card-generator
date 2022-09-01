
namespace Flash_Card_Maker
{
    partial class CreateWin
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
            this.setNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardFrontText = new System.Windows.Forms.TextBox();
            this.cardBackText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addCardButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveSetButton = new System.Windows.Forms.Button();
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
            // setNameText
            // 
            this.setNameText.Location = new System.Drawing.Point(13, 64);
            this.setNameText.Name = "setNameText";
            this.setNameText.Size = new System.Drawing.Size(349, 23);
            this.setNameText.TabIndex = 2;
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
            // cardFrontText
            // 
            this.cardFrontText.Location = new System.Drawing.Point(55, 118);
            this.cardFrontText.Name = "cardFrontText";
            this.cardFrontText.Size = new System.Drawing.Size(307, 23);
            this.cardFrontText.TabIndex = 5;
            // 
            // cardBackText
            // 
            this.cardBackText.Location = new System.Drawing.Point(55, 147);
            this.cardBackText.Name = "cardBackText";
            this.cardBackText.Size = new System.Drawing.Size(307, 23);
            this.cardBackText.TabIndex = 7;
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
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(316, 176);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(46, 23);
            this.addCardButton.TabIndex = 8;
            this.addCardButton.Text = "Add";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
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
            // saveSetButton
            // 
            this.saveSetButton.Location = new System.Drawing.Point(14, 437);
            this.saveSetButton.Name = "saveSetButton";
            this.saveSetButton.Size = new System.Drawing.Size(346, 23);
            this.saveSetButton.TabIndex = 10;
            this.saveSetButton.Text = "Save Set";
            this.saveSetButton.UseVisualStyleBackColor = true;
            this.saveSetButton.Click += new System.EventHandler(this.saveSetButton_Click);
            // 
            // CreateWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 466);
            this.Controls.Add(this.saveSetButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.cardBackText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cardFrontText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateWin";
            this.Text = "Create Set";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardFrontText;
        private System.Windows.Forms.TextBox cardBackText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveSetButton;
    }
}

