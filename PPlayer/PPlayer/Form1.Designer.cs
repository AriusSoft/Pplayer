namespace PPlayer
{
    partial class Pplayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pplayer));
            this.label_track = new System.Windows.Forms.Label();
            this.label_track_2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Volume_trackbar = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.flat_track_slider = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tray_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Track_label_box = new System.Windows.Forms.Label();
            this.Track_label_box2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_play_menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_playlist_menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.playlist_panel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.percen_bar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.percen_bar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bopen_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnext_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.bplay_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.bprev_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tray_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.playlist_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bopen_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnext_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bplay_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bprev_button)).BeginInit();
            this.SuspendLayout();
            // 
            // label_track
            // 
            this.label_track.AutoSize = true;
            this.label_track.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_track.Location = new System.Drawing.Point(12, 218);
            this.label_track.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_track.Name = "label_track";
            this.label_track.Size = new System.Drawing.Size(49, 13);
            this.label_track.TabIndex = 10;
            this.label_track.Text = "00:00:00";
            this.label_track.Click += new System.EventHandler(this.label_track_Click);
            // 
            // label_track_2
            // 
            this.label_track_2.AutoSize = true;
            this.label_track_2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_track_2.Location = new System.Drawing.Point(479, 218);
            this.label_track_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_track_2.Name = "label_track_2";
            this.label_track_2.Size = new System.Drawing.Size(49, 13);
            this.label_track_2.TabIndex = 11;
            this.label_track_2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Volume_trackbar
            // 
            this.Volume_trackbar.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.Volume_trackbar.BackColor = System.Drawing.Color.Transparent;
            this.Volume_trackbar.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Volume_trackbar.BorderRadius = 0;
            this.Volume_trackbar.IndicatorColor = System.Drawing.SystemColors.Highlight;
            this.Volume_trackbar.Location = new System.Drawing.Point(534, 109);
            this.Volume_trackbar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Volume_trackbar.MaximumValue = 100;
            this.Volume_trackbar.Name = "Volume_trackbar";
            this.Volume_trackbar.Size = new System.Drawing.Size(30, 88);
            this.Volume_trackbar.SliderRadius = 0;
            this.Volume_trackbar.TabIndex = 13;
            this.Volume_trackbar.Value = 100;
            this.Volume_trackbar.ValueChanged += new System.EventHandler(this.Volume_trackbar_ValueChanged);
            // 
            // flat_track_slider
            // 
            this.flat_track_slider.BackColor = System.Drawing.Color.Silver;
            this.flat_track_slider.BorderRadius = 5;
            this.flat_track_slider.Location = new System.Drawing.Point(-2, 3);
            this.flat_track_slider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flat_track_slider.MaximumValue = 100;
            this.flat_track_slider.Name = "flat_track_slider";
            this.flat_track_slider.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.flat_track_slider.Size = new System.Drawing.Size(529, 10);
            this.flat_track_slider.TabIndex = 14;
            this.flat_track_slider.Value = 0;
            this.flat_track_slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flat_track_slider_MouseDown);
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.DarkGray;
            this.Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Playlist.FormattingEnabled = true;
            this.Playlist.HorizontalScrollbar = true;
            this.Playlist.ItemHeight = 22;
            this.Playlist.Location = new System.Drawing.Point(1, 3);
            this.Playlist.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(563, 286);
            this.Playlist.TabIndex = 15;
            this.Playlist.Visible = false;
            this.Playlist.DoubleClick += new System.EventHandler(this.Playlist_DoubleClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tray_button);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 36);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AA Duke", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pplayer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPlayer.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tray_button
            // 
            this.tray_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tray_button.Image = global::PPlayer.Properties.Resources.tray;
            this.tray_button.ImageActive = null;
            this.tray_button.Location = new System.Drawing.Point(563, 4);
            this.tray_button.Name = "tray_button";
            this.tray_button.Size = new System.Drawing.Size(30, 28);
            this.tray_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tray_button.TabIndex = 1;
            this.tray_button.TabStop = false;
            this.tray_button.Zoom = 10;
            this.tray_button.Click += new System.EventHandler(this.tray_button_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Image = global::PPlayer.Properties.Resources.cancel_512;
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(599, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 28);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Zoom = 10;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flat_track_slider);
            this.panel2.Location = new System.Drawing.Point(-1, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 17);
            this.panel2.TabIndex = 21;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Track_label_box
            // 
            this.Track_label_box.AutoSize = true;
            this.Track_label_box.Font = new System.Drawing.Font("Arial Narrow", 30F);
            this.Track_label_box.ForeColor = System.Drawing.Color.White;
            this.Track_label_box.Location = new System.Drawing.Point(140, 109);
            this.Track_label_box.Name = "Track_label_box";
            this.Track_label_box.Size = new System.Drawing.Size(0, 46);
            this.Track_label_box.TabIndex = 26;
            this.Track_label_box.Click += new System.EventHandler(this.Track_label_box_Click);
            // 
            // Track_label_box2
            // 
            this.Track_label_box2.AutoSize = true;
            this.Track_label_box2.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.Track_label_box2.ForeColor = System.Drawing.Color.White;
            this.Track_label_box2.Location = new System.Drawing.Point(143, 168);
            this.Track_label_box2.Name = "Track_label_box2";
            this.Track_label_box2.Size = new System.Drawing.Size(0, 29);
            this.Track_label_box2.TabIndex = 27;
            this.Track_label_box2.Click += new System.EventHandler(this.Track_label_box2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_play_menu);
            this.panel4.Controls.Add(this.button_playlist_menu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(563, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 466);
            this.panel4.TabIndex = 28;
            // 
            // button_play_menu
            // 
            this.button_play_menu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.button_play_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.button_play_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play_menu.BorderRadius = 0;
            this.button_play_menu.ButtonText = "";
            this.button_play_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play_menu.DisabledColor = System.Drawing.Color.Gray;
            this.button_play_menu.Iconcolor = System.Drawing.Color.Transparent;
            this.button_play_menu.Iconimage = global::PPlayer.Properties.Resources.menu_play;
            this.button_play_menu.Iconimage_right = null;
            this.button_play_menu.Iconimage_right_Selected = null;
            this.button_play_menu.Iconimage_Selected = null;
            this.button_play_menu.IconMarginLeft = 0;
            this.button_play_menu.IconMarginRight = 0;
            this.button_play_menu.IconRightVisible = true;
            this.button_play_menu.IconRightZoom = 0D;
            this.button_play_menu.IconVisible = true;
            this.button_play_menu.IconZoom = 90D;
            this.button_play_menu.IsTab = false;
            this.button_play_menu.Location = new System.Drawing.Point(-1, 33);
            this.button_play_menu.Name = "button_play_menu";
            this.button_play_menu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.button_play_menu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.button_play_menu.OnHoverTextColor = System.Drawing.Color.White;
            this.button_play_menu.selected = true;
            this.button_play_menu.Size = new System.Drawing.Size(68, 77);
            this.button_play_menu.TabIndex = 0;
            this.button_play_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_play_menu.Textcolor = System.Drawing.Color.White;
            this.button_play_menu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_play_menu.Click += new System.EventHandler(this.button_play_menu_Click);
            // 
            // button_playlist_menu
            // 
            this.button_playlist_menu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.button_playlist_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_playlist_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_playlist_menu.BorderRadius = 0;
            this.button_playlist_menu.ButtonText = "";
            this.button_playlist_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_playlist_menu.DisabledColor = System.Drawing.Color.Gray;
            this.button_playlist_menu.Iconcolor = System.Drawing.Color.Transparent;
            this.button_playlist_menu.Iconimage = global::PPlayer.Properties.Resources.PMenu;
            this.button_playlist_menu.Iconimage_right = null;
            this.button_playlist_menu.Iconimage_right_Selected = null;
            this.button_playlist_menu.Iconimage_Selected = null;
            this.button_playlist_menu.IconMarginLeft = 0;
            this.button_playlist_menu.IconMarginRight = 0;
            this.button_playlist_menu.IconRightVisible = true;
            this.button_playlist_menu.IconRightZoom = 0D;
            this.button_playlist_menu.IconVisible = true;
            this.button_playlist_menu.IconZoom = 90D;
            this.button_playlist_menu.IsTab = false;
            this.button_playlist_menu.Location = new System.Drawing.Point(-1, 107);
            this.button_playlist_menu.Name = "button_playlist_menu";
            this.button_playlist_menu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_playlist_menu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.button_playlist_menu.OnHoverTextColor = System.Drawing.Color.White;
            this.button_playlist_menu.selected = false;
            this.button_playlist_menu.Size = new System.Drawing.Size(68, 75);
            this.button_playlist_menu.TabIndex = 1;
            this.button_playlist_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_playlist_menu.Textcolor = System.Drawing.Color.White;
            this.button_playlist_menu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playlist_menu.Click += new System.EventHandler(this.button_playlist_menu_Click);
            // 
            // playlist_panel
            // 
            this.playlist_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playlist_panel.Controls.Add(this.Playlist);
            this.playlist_panel.Location = new System.Drawing.Point(-3, 30);
            this.playlist_panel.Name = "playlist_panel";
            this.playlist_panel.Size = new System.Drawing.Size(571, 454);
            this.playlist_panel.TabIndex = 29;
            this.playlist_panel.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Pplayer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PPlayer.Properties.Resources.panel4;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(-1, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 90);
            this.panel3.TabIndex = 24;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::PPlayer.Properties.Resources.title;
            this.pictureBox.Location = new System.Drawing.Point(9, 108);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(122, 99);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // percen_bar2
            // 
            this.percen_bar2.animated = false;
            this.percen_bar2.animationIterval = 5;
            this.percen_bar2.animationSpeed = 300;
            this.percen_bar2.BackColor = System.Drawing.Color.Transparent;
            this.percen_bar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("percen_bar2.BackgroundImage")));
            this.percen_bar2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percen_bar2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.percen_bar2.LabelVisible = false;
            this.percen_bar2.LineProgressThickness = 8;
            this.percen_bar2.LineThickness = 5;
            this.percen_bar2.Location = new System.Drawing.Point(464, 38);
            this.percen_bar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percen_bar2.MaxValue = 100;
            this.percen_bar2.Name = "percen_bar2";
            this.percen_bar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.percen_bar2.ProgressColor = System.Drawing.Color.SteelBlue;
            this.percen_bar2.Size = new System.Drawing.Size(64, 64);
            this.percen_bar2.TabIndex = 23;
            this.percen_bar2.Value = 0;
            // 
            // percen_bar
            // 
            this.percen_bar.animated = false;
            this.percen_bar.animationIterval = 5;
            this.percen_bar.animationSpeed = 300;
            this.percen_bar.BackColor = System.Drawing.Color.Transparent;
            this.percen_bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("percen_bar.BackgroundImage")));
            this.percen_bar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percen_bar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.percen_bar.LabelVisible = false;
            this.percen_bar.LineProgressThickness = 8;
            this.percen_bar.LineThickness = 5;
            this.percen_bar.Location = new System.Drawing.Point(-1, 38);
            this.percen_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percen_bar.MaxValue = 100;
            this.percen_bar.Name = "percen_bar";
            this.percen_bar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.percen_bar.ProgressColor = System.Drawing.Color.SteelBlue;
            this.percen_bar.Size = new System.Drawing.Size(64, 64);
            this.percen_bar.TabIndex = 22;
            this.percen_bar.Value = 0;
            // 
            // bopen_button
            // 
            this.bopen_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bopen_button.Image = global::PPlayer.Properties.Resources.playlist2;
            this.bopen_button.ImageActive = null;
            this.bopen_button.Location = new System.Drawing.Point(481, 265);
            this.bopen_button.Name = "bopen_button";
            this.bopen_button.Size = new System.Drawing.Size(45, 47);
            this.bopen_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bopen_button.TabIndex = 20;
            this.bopen_button.TabStop = false;
            this.bopen_button.Zoom = 10;
            this.bopen_button.Click += new System.EventHandler(this.bopen_button_Click);
            // 
            // bnext_button
            // 
            this.bnext_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnext_button.Image = global::PPlayer.Properties.Resources.next_play2;
            this.bnext_button.ImageActive = null;
            this.bnext_button.Location = new System.Drawing.Point(187, 265);
            this.bnext_button.Name = "bnext_button";
            this.bnext_button.Size = new System.Drawing.Size(70, 62);
            this.bnext_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnext_button.TabIndex = 19;
            this.bnext_button.TabStop = false;
            this.bnext_button.Zoom = 10;
            this.bnext_button.Click += new System.EventHandler(this.bnext_button_Click);
            // 
            // bplay_button
            // 
            this.bplay_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bplay_button.Image = global::PPlayer.Properties.Resources.play2;
            this.bplay_button.ImageActive = null;
            this.bplay_button.Location = new System.Drawing.Point(103, 265);
            this.bplay_button.Name = "bplay_button";
            this.bplay_button.Size = new System.Drawing.Size(73, 62);
            this.bplay_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bplay_button.TabIndex = 18;
            this.bplay_button.TabStop = false;
            this.bplay_button.Zoom = 10;
            this.bplay_button.Click += new System.EventHandler(this.bplay_button_Click);
            // 
            // bprev_button
            // 
            this.bprev_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bprev_button.Image = global::PPlayer.Properties.Resources.lost_play2;
            this.bprev_button.ImageActive = null;
            this.bprev_button.Location = new System.Drawing.Point(15, 265);
            this.bprev_button.Name = "bprev_button";
            this.bprev_button.Size = new System.Drawing.Size(77, 62);
            this.bprev_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bprev_button.TabIndex = 17;
            this.bprev_button.TabStop = false;
            this.bprev_button.Zoom = 10;
            this.bprev_button.Click += new System.EventHandler(this.bprev_button_Click);
            // 
            // Pplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.playlist_panel);
            this.Controls.Add(this.Track_label_box2);
            this.Controls.Add(this.Track_label_box);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.percen_bar2);
            this.Controls.Add(this.percen_bar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bopen_button);
            this.Controls.Add(this.bnext_button);
            this.Controls.Add(this.bplay_button);
            this.Controls.Add(this.bprev_button);
            this.Controls.Add(this.Volume_trackbar);
            this.Controls.Add(this.label_track_2);
            this.Controls.Add(this.label_track);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Pplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pplayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tray_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.playlist_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bopen_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnext_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bplay_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bprev_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_track;
        private System.Windows.Forms.Label label_track_2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuVTrackbar Volume_trackbar;
        private Bunifu.Framework.UI.BunifuProgressBar flat_track_slider;
        private System.Windows.Forms.ListBox Playlist;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private Bunifu.Framework.UI.BunifuImageButton bprev_button;
        private Bunifu.Framework.UI.BunifuImageButton bplay_button;
        private Bunifu.Framework.UI.BunifuImageButton bnext_button;
        private Bunifu.Framework.UI.BunifuImageButton bopen_button;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar percen_bar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar percen_bar2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Track_label_box2;
        private System.Windows.Forms.Label Track_label_box;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton button_play_menu;
        private Bunifu.Framework.UI.BunifuFlatButton button_playlist_menu;
        private System.Windows.Forms.Panel playlist_panel;
        private Bunifu.Framework.UI.BunifuImageButton tray_button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

