namespace YAZ_CIKART
{
    partial class Form2
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.cikis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Giris = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Anasayfa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Yazili = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Sorubnk = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Soruekle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Sorular = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Hazirblg = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Profil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Oturum = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.AccordionControl.BackColor2 = ((System.Drawing.Color)(resources.GetObject("accordionControl1.Appearance.AccordionControl.BackColor2")));
            this.accordionControl1.Appearance.AccordionControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.AccordionControl.Font = ((System.Drawing.Font)(resources.GetObject("accordionControl1.Appearance.AccordionControl.Font")));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.Group.Normal.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.Hint.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.Item.Normal.Options.UseBackColor = true;
            this.accordionControl1.Appearance.ItemWithContainer.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accordionControl1.Appearance.ItemWithContainer.Normal.Options.UseBackColor = true;
            resources.ApplyResources(this.accordionControl1, "accordionControl1");
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.cikis});
            this.accordionControl1.GroupHeight = 56;
            this.accordionControl1.ItemHeight = 31;
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.StateChanged += new System.EventHandler(this.accordionControl1_StateChanged);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControlElement1.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.gear__1_;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.accordionControlElement1, "accordionControlElement1");
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click_1);
            // 
            // cikis
            // 
            this.cikis.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("cikis.Appearance.Hovered.Font")));
            this.cikis.Appearance.Hovered.Options.UseFont = true;
            this.cikis.Appearance.Normal.BackColor = System.Drawing.Color.DarkRed;
            this.cikis.Appearance.Normal.BackColor2 = ((System.Drawing.Color)(resources.GetObject("cikis.Appearance.Normal.BackColor2")));
            this.cikis.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("cikis.Appearance.Normal.Font")));
            this.cikis.Appearance.Normal.Options.UseBackColor = true;
            this.cikis.Appearance.Normal.Options.UseFont = true;
            this.cikis.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("cikis.Appearance.Pressed.Font")));
            this.cikis.Appearance.Pressed.Options.UseFont = true;
            this.cikis.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Giris,
            this.Anasayfa,
            this.Yazili,
            this.Sorubnk,
            this.Hazirblg,
            this.Profil,
            this.Oturum});
            this.cikis.Expanded = true;
            this.cikis.Height = 60;
            this.cikis.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.cikis.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.off_button;
            this.cikis.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.cikis.Name = "cikis";
            resources.ApplyResources(this.cikis, "cikis");
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Giris
            // 
            this.Giris.Appearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Giris.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Giris.Appearance.Hovered.Font")));
            this.Giris.Appearance.Hovered.Options.UseBackColor = true;
            this.Giris.Appearance.Hovered.Options.UseFont = true;
            this.Giris.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Giris.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Giris.Appearance.Normal.Font")));
            this.Giris.Appearance.Normal.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("Giris.Appearance.Normal.FontStyleDelta")));
            this.Giris.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.Giris.Appearance.Normal.Options.UseBackColor = true;
            this.Giris.Appearance.Normal.Options.UseFont = true;
            this.Giris.Appearance.Normal.Options.UseForeColor = true;
            this.Giris.Appearance.Normal.Options.UseTextOptions = true;
            this.Giris.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Giris.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Giris.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Giris.Appearance.Pressed.Font")));
            this.Giris.Appearance.Pressed.Options.UseFont = true;
            this.Giris.Expanded = true;
            this.Giris.Height = 60;
            this.Giris.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Giris.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.login;
            this.Giris.Name = "Giris";
            this.Giris.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Giris, "Giris");
            this.Giris.Click += new System.EventHandler(this.menugiris_Click);
            // 
            // Anasayfa
            // 
            this.Anasayfa.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Anasayfa.Appearance.Hovered.Font")));
            this.Anasayfa.Appearance.Hovered.Options.UseFont = true;
            this.Anasayfa.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Anasayfa.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Anasayfa.Appearance.Normal.Font")));
            this.Anasayfa.Appearance.Normal.Options.UseBackColor = true;
            this.Anasayfa.Appearance.Normal.Options.UseFont = true;
            this.Anasayfa.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Anasayfa.Appearance.Pressed.Font")));
            this.Anasayfa.Appearance.Pressed.Options.UseFont = true;
            this.Anasayfa.Enabled = false;
            this.Anasayfa.Height = 60;
            this.Anasayfa.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Anasayfa.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.homepage;
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Anasayfa, "Anasayfa");
            this.Anasayfa.Click += new System.EventHandler(this.Anasayfa_Click);
            // 
            // Yazili
            // 
            this.Yazili.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Yazili.Appearance.Hovered.Font")));
            this.Yazili.Appearance.Hovered.Options.UseFont = true;
            this.Yazili.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Yazili.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Yazili.Appearance.Normal.Font")));
            this.Yazili.Appearance.Normal.Options.UseBackColor = true;
            this.Yazili.Appearance.Normal.Options.UseFont = true;
            this.Yazili.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Yazili.Appearance.Pressed.Font")));
            this.Yazili.Appearance.Pressed.Options.UseFont = true;
            this.Yazili.Enabled = false;
            this.Yazili.Height = 60;
            this.Yazili.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Yazili.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.contract;
            this.Yazili.Name = "Yazili";
            this.Yazili.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Yazili, "Yazili");
            this.Yazili.Click += new System.EventHandler(this.Yazili_Click);
            // 
            // Sorubnk
            // 
            this.Sorubnk.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Sorubnk.Appearance.Hovered.Font")));
            this.Sorubnk.Appearance.Hovered.Options.UseFont = true;
            this.Sorubnk.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Sorubnk.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Sorubnk.Appearance.Normal.Font")));
            this.Sorubnk.Appearance.Normal.Options.UseBackColor = true;
            this.Sorubnk.Appearance.Normal.Options.UseFont = true;
            this.Sorubnk.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Sorubnk.Appearance.Pressed.Font")));
            this.Sorubnk.Appearance.Pressed.Options.UseFont = true;
            this.Sorubnk.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Soruekle,
            this.Sorular});
            this.Sorubnk.Enabled = false;
            this.Sorubnk.Height = 60;
            this.Sorubnk.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Sorubnk.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.bookshelf;
            this.Sorubnk.Name = "Sorubnk";
            resources.ApplyResources(this.Sorubnk, "Sorubnk");
            // 
            // Soruekle
            // 
            this.Soruekle.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Soruekle.Appearance.Hovered.Font")));
            this.Soruekle.Appearance.Hovered.Options.UseFont = true;
            this.Soruekle.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Soruekle.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Soruekle.Appearance.Normal.Font")));
            this.Soruekle.Appearance.Normal.Options.UseBackColor = true;
            this.Soruekle.Appearance.Normal.Options.UseFont = true;
            this.Soruekle.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Soruekle.Appearance.Pressed.Font")));
            this.Soruekle.Appearance.Pressed.Options.UseFont = true;
            this.Soruekle.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Soruekle.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.plus;
            this.Soruekle.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.Soruekle.Name = "Soruekle";
            this.Soruekle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Soruekle, "Soruekle");
            this.Soruekle.Click += new System.EventHandler(this.Soruekle_Click);
            // 
            // Sorular
            // 
            this.Sorular.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Sorular.Appearance.Hovered.Font")));
            this.Sorular.Appearance.Hovered.Options.UseFont = true;
            this.Sorular.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sorular.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Sorular.Appearance.Normal.Font")));
            this.Sorular.Appearance.Normal.Options.UseBackColor = true;
            this.Sorular.Appearance.Normal.Options.UseFont = true;
            this.Sorular.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Sorular.Appearance.Pressed.Font")));
            this.Sorular.Appearance.Pressed.Options.UseFont = true;
            this.Sorular.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Sorular.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.storytelling;
            this.Sorular.Name = "Sorular";
            this.Sorular.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Sorular, "Sorular");
            this.Sorular.Click += new System.EventHandler(this.Sorular_Click);
            // 
            // Hazirblg
            // 
            this.Hazirblg.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Hazirblg.Appearance.Hovered.Font")));
            this.Hazirblg.Appearance.Hovered.Options.UseFont = true;
            this.Hazirblg.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Hazirblg.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Hazirblg.Appearance.Normal.Font")));
            this.Hazirblg.Appearance.Normal.Options.UseBackColor = true;
            this.Hazirblg.Appearance.Normal.Options.UseFont = true;
            this.Hazirblg.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Hazirblg.Appearance.Pressed.Font")));
            this.Hazirblg.Appearance.Pressed.Options.UseFont = true;
            this.Hazirblg.Enabled = false;
            this.Hazirblg.Height = 60;
            this.Hazirblg.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Hazirblg.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.paper;
            this.Hazirblg.Name = "Hazirblg";
            this.Hazirblg.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Hazirblg, "Hazirblg");
            this.Hazirblg.Visible = false;
            this.Hazirblg.Click += new System.EventHandler(this.Hazırblg_Click);
            // 
            // Profil
            // 
            this.Profil.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Profil.Appearance.Hovered.Font")));
            this.Profil.Appearance.Hovered.Options.UseFont = true;
            this.Profil.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Profil.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Profil.Appearance.Normal.Font")));
            this.Profil.Appearance.Normal.Options.UseBackColor = true;
            this.Profil.Appearance.Normal.Options.UseFont = true;
            this.Profil.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Profil.Appearance.Pressed.Font")));
            this.Profil.Appearance.Pressed.Options.UseFont = true;
            this.Profil.Enabled = false;
            this.Profil.Height = 60;
            this.Profil.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Profil.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.user;
            this.Profil.Name = "Profil";
            this.Profil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Profil, "Profil");
            this.Profil.Click += new System.EventHandler(this.Profil_Click);
            // 
            // Oturum
            // 
            this.Oturum.Appearance.Disabled.BackColor = System.Drawing.Color.Transparent;
            this.Oturum.Appearance.Disabled.Options.UseBackColor = true;
            this.Oturum.Appearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("Oturum.Appearance.Hovered.Font")));
            this.Oturum.Appearance.Hovered.Options.UseFont = true;
            this.Oturum.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("Oturum.Appearance.Normal.Font")));
            this.Oturum.Appearance.Normal.Options.UseFont = true;
            this.Oturum.Appearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("Oturum.Appearance.Pressed.Font")));
            this.Oturum.Appearance.Pressed.Options.UseFont = true;
            this.Oturum.Enabled = false;
            this.Oturum.Height = 60;
            this.Oturum.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Oturum.ImageOptions.Image = global::YAZ_CIKART.Properties.Resources.log_out;
            this.Oturum.Name = "Oturum";
            this.Oturum.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Oturum, "Oturum");
            this.Oturum.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.Timer6_Tick);
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::YAZ_CIKART.Properties.Resources.icons8_delete_3;
            this.button11.Cursor = System.Windows.Forms.Cursors.Default;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            this.button11.MouseHover += new System.EventHandler(this.Button11_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button11);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::YAZ_CIKART.Properties.Resources.icons8_minus_3;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::YAZ_CIKART.Properties.Resources.icons8_maximize_button;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer5;
        public System.Windows.Forms.Timer timer6;
        public DevExpress.XtraBars.Navigation.AccordionControlElement Giris;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Anasayfa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Yazili;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Sorubnk;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Soruekle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Sorular;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Hazirblg;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Profil;
        public DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        public DevExpress.XtraBars.Navigation.AccordionControlElement cikis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Oturum;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
    }
}