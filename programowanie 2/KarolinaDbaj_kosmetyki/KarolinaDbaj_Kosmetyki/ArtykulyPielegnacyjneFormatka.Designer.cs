namespace KarolinaDbaj_Kosmetyki
{
    partial class ArtykulyPielegnacyjneFormatka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtykulyPielegnacyjneFormatka));
            this.button1 = new System.Windows.Forms.Button();
            this.lblPielegnacja = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRabat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(23, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wczytaj wartości pól i utwórz obiekt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPielegnacja
            // 
            this.lblPielegnacja.FormattingEnabled = true;
            this.lblPielegnacja.ItemHeight = 16;
            this.lblPielegnacja.Location = new System.Drawing.Point(23, 15);
            this.lblPielegnacja.Name = "lblPielegnacja";
            this.lblPielegnacja.Size = new System.Drawing.Size(277, 292);
            this.lblPielegnacja.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(330, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(425, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Oblicz rabat!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRabat
            // 
            this.lblRabat.AutoSize = true;
            this.lblRabat.BackColor = System.Drawing.Color.Transparent;
            this.lblRabat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRabat.Location = new System.Drawing.Point(324, 71);
            this.lblRabat.Name = "lblRabat";
            this.lblRabat.Size = new System.Drawing.Size(23, 36);
            this.lblRabat.TabIndex = 3;
            this.lblRabat.Text = ".";
            // 
            // ArtykulyPielegnacyjneFormatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRabat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblPielegnacja);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtykulyPielegnacyjneFormatka";
            this.Text = "Artykuły pielęgnacyjne";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArtykulyPielegnacyjneFormatka_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lblPielegnacja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRabat;
    }
}