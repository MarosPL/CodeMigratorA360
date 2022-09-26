
namespace CodeMigrator
{
    partial class MainPage
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
            this.checkTEST = new System.Windows.Forms.CheckBox();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkQA = new System.Windows.Forms.CheckBox();
            this.checkPROD = new System.Windows.Forms.CheckBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.botList = new System.Windows.Forms.ListView();
            this.checkIncludePackages = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkTEST
            // 
            this.checkTEST.AutoSize = true;
            this.checkTEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkTEST.Location = new System.Drawing.Point(107, 219);
            this.checkTEST.Name = "checkTEST";
            this.checkTEST.Size = new System.Drawing.Size(58, 17);
            this.checkTEST.TabIndex = 2;
            this.checkTEST.Text = "TEST";
            this.checkTEST.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkTEST.UseVisualStyleBackColor = true;
            // 
            // btnMigrate
            // 
            this.btnMigrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMigrate.Location = new System.Drawing.Point(13, 242);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(502, 38);
            this.btnMigrate.TabIndex = 3;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Migrate to:";
            // 
            // checkQA
            // 
            this.checkQA.AutoSize = true;
            this.checkQA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkQA.Location = new System.Drawing.Point(181, 219);
            this.checkQA.Name = "checkQA";
            this.checkQA.Size = new System.Drawing.Size(43, 17);
            this.checkQA.TabIndex = 5;
            this.checkQA.Text = "QA";
            this.checkQA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkQA.UseVisualStyleBackColor = true;
            // 
            // checkPROD
            // 
            this.checkPROD.AutoSize = true;
            this.checkPROD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkPROD.Location = new System.Drawing.Point(244, 219);
            this.checkPROD.Name = "checkPROD";
            this.checkPROD.Size = new System.Drawing.Size(61, 17);
            this.checkPROD.TabIndex = 6;
            this.checkPROD.Text = "PROD";
            this.checkPROD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkPROD.UseVisualStyleBackColor = true;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(13, 297);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ShortcutsEnabled = false;
            this.statusTextBox.Size = new System.Drawing.Size(502, 20);
            this.statusTextBox.TabIndex = 7;
            // 
            // botList
            // 
            this.botList.FullRowSelect = true;
            this.botList.GridLines = true;
            this.botList.HideSelection = false;
            this.botList.Location = new System.Drawing.Point(13, 12);
            this.botList.Name = "botList";
            this.botList.Size = new System.Drawing.Size(502, 194);
            this.botList.TabIndex = 8;
            this.botList.UseCompatibleStateImageBehavior = false;
            this.botList.View = System.Windows.Forms.View.List;
            // 
            // checkIncludePackages
            // 
            this.checkIncludePackages.AutoSize = true;
            this.checkIncludePackages.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkIncludePackages.Location = new System.Drawing.Point(403, 219);
            this.checkIncludePackages.Name = "checkIncludePackages";
            this.checkIncludePackages.Size = new System.Drawing.Size(112, 17);
            this.checkIncludePackages.TabIndex = 9;
            this.checkIncludePackages.Text = "Include Packages";
            this.checkIncludePackages.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 329);
            this.Controls.Add(this.checkIncludePackages);
            this.Controls.Add(this.botList);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.checkPROD);
            this.Controls.Add(this.checkQA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMigrate);
            this.Controls.Add(this.checkTEST);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Migrator for A360";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkTEST;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkQA;
        private System.Windows.Forms.CheckBox checkPROD;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ListView botList;
        private System.Windows.Forms.CheckBox checkIncludePackages;
    }
}