namespace Projex
{
    partial class Gorev
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.RadioButton radioButton4;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorev));
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            radioButton4 = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            radioButton4.Cursor = System.Windows.Forms.Cursors.Default;
            radioButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            radioButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            radioButton4.Location = new System.Drawing.Point(66, 213);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(97, 18);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "KAĞAN DEPO";
            radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            radioButton4.UseCompatibleTextRendering = true;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.Location = new System.Drawing.Point(43, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(756, 48);
            label1.TabIndex = 6;
            label1.Text = "GÖREVLENDİRMEK İSTEDİĞİNİZ ÇALIŞANIZ SEÇİNİZ \r\nARDINDAN VERDİĞİNİZ GÖREVİ İLGİLİ " +
    "ALANA YAZARAK BUTONA TIKLAYINIZ";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(532, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "GÖREV VER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(362, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(356, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(66, 352);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "YAHYA TEMİZLİK";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 280);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "KAHRAMAN DEPO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(66, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "YASİN ÇAYCI";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngwing.com.png");
            // 
            // Gorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Name = "Gorev";
            this.Text = "Gorev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ImageList ımageList1;
    }
}