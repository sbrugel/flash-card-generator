
namespace Flash_Card_Maker
{
    partial class ViewWin
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
            this.flashCard = new System.Windows.Forms.Button();
            this.setTitleText = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.cardsLeftText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flashCard
            // 
            this.flashCard.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flashCard.Location = new System.Drawing.Point(12, 57);
            this.flashCard.Name = "flashCard";
            this.flashCard.Size = new System.Drawing.Size(491, 285);
            this.flashCard.TabIndex = 0;
            this.flashCard.Text = "Front";
            this.flashCard.UseVisualStyleBackColor = true;
            this.flashCard.Click += new System.EventHandler(this.flashCard_Click);
            // 
            // setTitleText
            // 
            this.setTitleText.AutoSize = true;
            this.setTitleText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setTitleText.Location = new System.Drawing.Point(12, 9);
            this.setTitleText.Name = "setTitleText";
            this.setTitleText.Size = new System.Drawing.Size(110, 45);
            this.setTitleText.TabIndex = 1;
            this.setTitleText.Text = "label1";
            this.setTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 348);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(428, 348);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(223, 348);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 4;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // cardsLeftText
            // 
            this.cardsLeftText.AutoSize = true;
            this.cardsLeftText.Location = new System.Drawing.Point(465, 39);
            this.cardsLeftText.Name = "cardsLeftText";
            this.cardsLeftText.Size = new System.Drawing.Size(38, 15);
            this.cardsLeftText.TabIndex = 5;
            this.cardsLeftText.Text = "label1";
            this.cardsLeftText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ViewWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 385);
            this.Controls.Add(this.cardsLeftText);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.setTitleText);
            this.Controls.Add(this.flashCard);
            this.Name = "ViewWin";
            this.Text = "View Flash Card Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flashCard;
        private System.Windows.Forms.Label setTitleText;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Label cardsLeftText;
    }
}