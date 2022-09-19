
namespace Flash_Card_Maker
{
    partial class MultipleChoice
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
            this.questionBox = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.setTitleText = new System.Windows.Forms.Label();
            this.cardsLeftText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionBox.Location = new System.Drawing.Point(13, 42);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(516, 240);
            this.questionBox.TabIndex = 0;
            this.questionBox.Text = "Content goes here";
            this.questionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(13, 289);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(516, 23);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "button1";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(13, 318);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(516, 23);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "button2";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(13, 347);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(516, 23);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "button3";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(12, 376);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(516, 23);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "button4";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // setTitleText
            // 
            this.setTitleText.AutoSize = true;
            this.setTitleText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setTitleText.Location = new System.Drawing.Point(13, 9);
            this.setTitleText.Name = "setTitleText";
            this.setTitleText.Size = new System.Drawing.Size(72, 30);
            this.setTitleText.TabIndex = 5;
            this.setTitleText.Text = "label1";
            this.setTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsLeftText
            // 
            this.cardsLeftText.AutoSize = true;
            this.cardsLeftText.Location = new System.Drawing.Point(490, 21);
            this.cardsLeftText.Name = "cardsLeftText";
            this.cardsLeftText.Size = new System.Drawing.Size(38, 15);
            this.cardsLeftText.TabIndex = 6;
            this.cardsLeftText.Text = "label1";
            this.cardsLeftText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 421);
            this.Controls.Add(this.cardsLeftText);
            this.Controls.Add(this.setTitleText);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.questionBox);
            this.Name = "MultipleChoice";
            this.Text = "MultipleChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label setTitleText;
        private System.Windows.Forms.Label cardsLeftText;
    }
}