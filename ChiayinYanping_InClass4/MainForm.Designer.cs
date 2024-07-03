namespace ChiayinYanping_InClass4
{
    partial class MainForm
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
            this.lblAnimals = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.labmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnimals
            // 
            this.lblAnimals.AutoSize = true;
            this.lblAnimals.Location = new System.Drawing.Point(55, 50);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(106, 24);
            this.lblAnimals.TabIndex = 0;
            this.lblAnimals.Text = "Animals:";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(398, 86);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(121, 48);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Speak!";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 37;
            this.listBoxAnimals.Location = new System.Drawing.Point(60, 86);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(292, 189);
            this.listBoxAnimals.TabIndex = 2;
            // 
            // labmessage
            // 
            this.labmessage.AutoSize = true;
            this.labmessage.Location = new System.Drawing.Point(59, 318);
            this.labmessage.Name = "labmessage";
            this.labmessage.Size = new System.Drawing.Size(0, 24);
            this.labmessage.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 400);
            this.Controls.Add(this.labmessage);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.lblAnimals);
            this.Name = "MainForm";
            this.Text = "A few animals";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimals;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Label labmessage;
    }
}

