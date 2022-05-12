namespace KarolinaDbaj_Kosmetyki
{
    partial class AkcesoriaKosmetyczneFormatka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkcesoriaKosmetyczneFormatka));
            this.button1 = new System.Windows.Forms.Button();
            this.lblAkcesoria = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRabat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(23, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 82);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wczytaj wartości pól i utwórz obiekt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAkcesoria
            // 
            this.lblAkcesoria.FormattingEnabled = true;
            this.lblAkcesoria.ItemHeight = 16;
            this.lblAkcesoria.Location = new System.Drawing.Point(23, 150);
            this.lblAkcesoria.Name = "lblAkcesoria";
            this.lblAkcesoria.ScrollAlwaysVisible = true;
            this.lblAkcesoria.Size = new System.Drawing.Size(296, 324);
            this.lblAkcesoria.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(337, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Oblicz rabat!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRabat2
            // 
            this.lblRabat2.AutoSize = true;
            this.lblRabat2.BackColor = System.Drawing.Color.Transparent;
            this.lblRabat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRabat2.Location = new System.Drawing.Point(331, 12);
            this.lblRabat2.Name = "lblRabat2";
            this.lblRabat2.Size = new System.Drawing.Size(23, 36);
            this.lblRabat2.TabIndex = 7;
            this.lblRabat2.Text = ".";
            // 
            // AkcesoriaKosmetyczneFormatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(968, 586);
            this.Controls.Add(this.lblRabat2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAkcesoria);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AkcesoriaKosmetyczneFormatka";
            this.Text = "Akcesoria do makijażu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AkcesoriaKosmetyczneFormatka_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lblAkcesoria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRabat2;
    }
}