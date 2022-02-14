
namespace iskolaGUI2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBetölt = new System.Windows.Forms.Button();
            this.btnMnetés = new System.Windows.Forms.Button();
            this.btnTörlés = new System.Windows.Forms.Button();
            this.btnKilép = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 303);
            this.listBox1.TabIndex = 0;
            // 
            // btnBetölt
            // 
            this.btnBetölt.Location = new System.Drawing.Point(12, 326);
            this.btnBetölt.Name = "btnBetölt";
            this.btnBetölt.Size = new System.Drawing.Size(75, 23);
            this.btnBetölt.TabIndex = 1;
            this.btnBetölt.Text = "betölt";
            this.btnBetölt.UseVisualStyleBackColor = true;
            this.btnBetölt.Click += new System.EventHandler(this.btnBetölt_Click);
            // 
            // btnMnetés
            // 
            this.btnMnetés.Location = new System.Drawing.Point(93, 326);
            this.btnMnetés.Name = "btnMnetés";
            this.btnMnetés.Size = new System.Drawing.Size(75, 23);
            this.btnMnetés.TabIndex = 2;
            this.btnMnetés.Text = "mentés";
            this.btnMnetés.UseVisualStyleBackColor = true;
            // 
            // btnTörlés
            // 
            this.btnTörlés.Location = new System.Drawing.Point(12, 355);
            this.btnTörlés.Name = "btnTörlés";
            this.btnTörlés.Size = new System.Drawing.Size(75, 23);
            this.btnTörlés.TabIndex = 3;
            this.btnTörlés.Text = "Törlés";
            this.btnTörlés.UseVisualStyleBackColor = true;
            this.btnTörlés.Click += new System.EventHandler(this.btnTörlés_Click);
            // 
            // btnKilép
            // 
            this.btnKilép.Location = new System.Drawing.Point(93, 355);
            this.btnKilép.Name = "btnKilép";
            this.btnKilép.Size = new System.Drawing.Size(75, 23);
            this.btnKilép.TabIndex = 4;
            this.btnKilép.Text = "kilépés";
            this.btnKilép.UseVisualStyleBackColor = true;
            this.btnKilép.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 450);
            this.Controls.Add(this.btnKilép);
            this.Controls.Add(this.btnTörlés);
            this.Controls.Add(this.btnMnetés);
            this.Controls.Add(this.btnBetölt);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "suliidk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBetölt;
        private System.Windows.Forms.Button btnMnetés;
        private System.Windows.Forms.Button btnTörlés;
        private System.Windows.Forms.Button btnKilép;
    }
}

