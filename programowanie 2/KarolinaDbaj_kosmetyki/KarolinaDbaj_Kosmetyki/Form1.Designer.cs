namespace KarolinaDbaj_Kosmetyki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxKosmetyk = new System.Windows.Forms.ListBox();
            this.btnAkcesoria = new System.Windows.Forms.Button();
            this.btnPielegnacja = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblZniżka = new System.Windows.Forms.Label();
            this.btnZniżka = new System.Windows.Forms.Button();
            this.textBoxZniżka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyświetl obiekt i go utwórz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxKosmetyk
            // 
            this.listBoxKosmetyk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxKosmetyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBoxKosmetyk.FormattingEnabled = true;
            this.listBoxKosmetyk.ItemHeight = 29;
            this.listBoxKosmetyk.Location = new System.Drawing.Point(12, 221);
            this.listBoxKosmetyk.Name = "listBoxKosmetyk";
            this.listBoxKosmetyk.ScrollAlwaysVisible = true;
            this.listBoxKosmetyk.Size = new System.Drawing.Size(384, 178);
            this.listBoxKosmetyk.TabIndex = 1;
            // 
            // btnAkcesoria
            // 
            this.btnAkcesoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.btnAkcesoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkcesoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAkcesoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAkcesoria.Location = new System.Drawing.Point(618, 316);
            this.btnAkcesoria.Name = "btnAkcesoria";
            this.btnAkcesoria.Size = new System.Drawing.Size(170, 122);
            this.btnAkcesoria.TabIndex = 2;
            this.btnAkcesoria.Text = "Akcesoria kosmetyczne";
            this.btnAkcesoria.UseVisualStyleBackColor = false;
            this.btnAkcesoria.Click += new System.EventHandler(this.btnAkcesoria_Click);
            // 
            // btnPielegnacja
            // 
            this.btnPielegnacja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.btnPielegnacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPielegnacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPielegnacja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPielegnacja.Location = new System.Drawing.Point(419, 316);
            this.btnPielegnacja.Name = "btnPielegnacja";
            this.btnPielegnacja.Size = new System.Drawing.Size(175, 122);
            this.btnPielegnacja.TabIndex = 3;
            this.btnPielegnacja.Text = "Artykuły do pielęgnacji";
            this.btnPielegnacja.UseVisualStyleBackColor = false;
            this.btnPielegnacja.Click += new System.EventHandler(this.btnPielegnacja_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(401, 30);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 29, 13, 24, 13, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KarolinaDbaj_Kosmetyki.Properties.Resources.modne_kosmetyki_na_jesien_2020_nowosci_kosmetyczne_ktore_beda_hitem_instagrama_2458970;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblZniżka
            // 
            this.lblZniżka.AutoSize = true;
            this.lblZniżka.BackColor = System.Drawing.Color.Transparent;
            this.lblZniżka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZniżka.Location = new System.Drawing.Point(12, 45);
            this.lblZniżka.Name = "lblZniżka";
            this.lblZniżka.Size = new System.Drawing.Size(13, 20);
            this.lblZniżka.TabIndex = 6;
            this.lblZniżka.Text = ".";
            // 
            // btnZniżka
            // 
            this.btnZniżka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.btnZniżka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZniżka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZniżka.Location = new System.Drawing.Point(12, 181);
            this.btnZniżka.Name = "btnZniżka";
            this.btnZniżka.Size = new System.Drawing.Size(384, 34);
            this.btnZniżka.TabIndex = 7;
            this.btnZniżka.Text = "Oblicz rabat!";
            this.btnZniżka.UseVisualStyleBackColor = false;
            this.btnZniżka.Click += new System.EventHandler(this.btnZniżka_Click);
            // 
            // textBoxZniżka
            // 
            this.textBoxZniżka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxZniżka.Location = new System.Drawing.Point(12, 153);
            this.textBoxZniżka.Name = "textBoxZniżka";
            this.textBoxZniżka.Size = new System.Drawing.Size(384, 22);
            this.textBoxZniżka.TabIndex = 8;
            this.textBoxZniżka.TextChanged += new System.EventHandler(this.textBoxZniżka_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxZniżka);
            this.Controls.Add(this.btnZniżka);
            this.Controls.Add(this.lblZniżka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnPielegnacja);
            this.Controls.Add(this.btnAkcesoria);
            this.Controls.Add(this.listBoxKosmetyk);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sklep z artykułami kosmetycznymi";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxKosmetyk;
        private System.Windows.Forms.Button btnAkcesoria;
        private System.Windows.Forms.Button btnPielegnacja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblZniżka;
        private System.Windows.Forms.Button btnZniżka;
        private System.Windows.Forms.TextBox textBoxZniżka;
    }
}

