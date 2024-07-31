namespace YAZ_CIKART
{
    partial class Frmsadi
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Labelsinavadi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Labelkid = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Labelsorusayi = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Labelüst = new System.Windows.Forms.Label();
            this.Labelalt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(116, 219);
            this.richTextBox1.MaxLength = 15;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 28);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // Labelsinavadi
            // 
            this.Labelsinavadi.AutoSize = true;
            this.Labelsinavadi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelsinavadi.Location = new System.Drawing.Point(25, 222);
            this.Labelsinavadi.Name = "Labelsinavadi";
            this.Labelsinavadi.Size = new System.Drawing.Size(73, 20);
            this.Labelsinavadi.TabIndex = 40;
            this.Labelsinavadi.Text = "Sınav Adı:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(213, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 56;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Labelkid
            // 
            this.Labelkid.AutoSize = true;
            this.Labelkid.ForeColor = System.Drawing.Color.Red;
            this.Labelkid.Location = new System.Drawing.Point(13, 275);
            this.Labelkid.Name = "Labelkid";
            this.Labelkid.Size = new System.Drawing.Size(0, 13);
            this.Labelkid.TabIndex = 57;
            this.Labelkid.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(12, 37);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(326, 137);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Labelsorusayi
            // 
            this.Labelsorusayi.AutoSize = true;
            this.Labelsorusayi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelsorusayi.Location = new System.Drawing.Point(25, 256);
            this.Labelsorusayi.Name = "Labelsorusayi";
            this.Labelsorusayi.Size = new System.Drawing.Size(85, 20);
            this.Labelsorusayi.TabIndex = 40;
            this.Labelsorusayi.Text = "Soru Sayısı:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(116, 253);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(33, 38);
            this.maskedTextBox1.TabIndex = 59;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.Leave += new System.EventHandler(this.MaskedTextBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "(MAX. 20)";
            // 
            // Labelüst
            // 
            this.Labelüst.AutoSize = true;
            this.Labelüst.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelüst.Location = new System.Drawing.Point(121, 9);
            this.Labelüst.Name = "Labelüst";
            this.Labelüst.Size = new System.Drawing.Size(95, 25);
            this.Labelüst.TabIndex = 40;
            this.Labelüst.Text = "Sınav Seç";
            // 
            // Labelalt
            // 
            this.Labelalt.AutoSize = true;
            this.Labelalt.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelalt.Location = new System.Drawing.Point(121, 184);
            this.Labelalt.Name = "Labelalt";
            this.Labelalt.Size = new System.Drawing.Size(127, 25);
            this.Labelalt.TabIndex = 40;
            this.Labelalt.Text = "Sınav Oluştur";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 4);
            this.flowLayoutPanel1.TabIndex = 61;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.BackgroundImage = global::YAZ_CIKART.Properties.Resources.close__2_;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button11.Location = new System.Drawing.Point(311, 1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 30);
            this.button11.TabIndex = 38;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Frmsadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Labelkid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Labelsorusayi);
            this.Controls.Add(this.Labelalt);
            this.Controls.Add(this.Labelüst);
            this.Controls.Add(this.Labelsinavadi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button11);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmsadi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsadi";
            this.Load += new System.EventHandler(this.Frmsadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label Labelkid;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Labelsinavadi;
        public System.Windows.Forms.Label Labelsorusayi;
        public System.Windows.Forms.Label Labelüst;
        public System.Windows.Forms.Label Labelalt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}