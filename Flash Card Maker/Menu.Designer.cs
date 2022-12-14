
namespace Flash_Card_Maker
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.importCSV = new System.Windows.Forms.Button();
            this.mcButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.versionNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(3, 28);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(166, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 57);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(166, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.viewButton);
            this.panel2.Location = new System.Drawing.Point(12, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 66);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Viewer";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(3, 28);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(166, 23);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "Open";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.importCSV);
            this.panel3.Controls.Add(this.mcButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.exportCSVButton);
            this.panel3.Location = new System.Drawing.Point(12, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 123);
            this.panel3.TabIndex = 5;
            // 
            // importCSV
            // 
            this.importCSV.Location = new System.Drawing.Point(3, 57);
            this.importCSV.Name = "importCSV";
            this.importCSV.Size = new System.Drawing.Size(166, 23);
            this.importCSV.TabIndex = 4;
            this.importCSV.Text = "Import from CSV";
            this.importCSV.UseVisualStyleBackColor = true;
            this.importCSV.Click += new System.EventHandler(this.importCSVButton_Click);
            // 
            // mcButton
            // 
            this.mcButton.Location = new System.Drawing.Point(3, 86);
            this.mcButton.Name = "mcButton";
            this.mcButton.Size = new System.Drawing.Size(166, 23);
            this.mcButton.TabIndex = 3;
            this.mcButton.Text = "Multiple Choice";
            this.mcButton.UseVisualStyleBackColor = true;
            this.mcButton.Click += new System.EventHandler(this.mcButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tools";
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.Location = new System.Drawing.Point(3, 28);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(166, 23);
            this.exportCSVButton.TabIndex = 2;
            this.exportCSVButton.Text = "Export to CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click);
            // 
            // versionNumber
            // 
            this.versionNumber.AutoSize = true;
            this.versionNumber.Location = new System.Drawing.Point(12, 13);
            this.versionNumber.Name = "versionNumber";
            this.versionNumber.Size = new System.Drawing.Size(31, 15);
            this.versionNumber.TabIndex = 6;
            this.versionNumber.Text = "1.0.1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 344);
            this.Controls.Add(this.versionNumber);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportCSVButton;
        private System.Windows.Forms.Label versionNumber;
        private System.Windows.Forms.Button mcButton;
        private System.Windows.Forms.Button importCSV;
    }
}