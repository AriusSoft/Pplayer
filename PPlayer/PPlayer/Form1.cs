using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPlayer
{
    public partial class Pplayer : Form
    {


        public Pplayer()
        {
            InitializeComponent();
            Main.Link = this;
            MainBass.InitBass(MainBass.HG);
            Main.InputFormats();

            try
            {
                PLAYLIST playlist_ = new PLAYLIST(Main.AppPath + "playlists\\base.m3u");
                for (int i = 0; i < playlist_.Count(); i++)
                {
                    Main.Files.Add(playlist_[i]);
                    Tag Showed_track = new Tag(playlist_[i]);
                    Playlist.Items.Add((i + 1) + ". " + Showed_track.Artist + " — " + Showed_track.Title);
                }

                Playlist.SelectedIndex = 0;

                Tag Showed_track_t = new Tag(playlist_[0]);
                pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title; ;
                Track_label_box.Text = Showed_track_t.Artist;
                Track_label_box2.Text = Showed_track_t.Title;

                bplay_button_Click(this, new EventArgs());
            }
            catch
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label_track_Click(object sender, EventArgs e)
        {

        }

        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName.Contains(".m3u"))
            {
                    PLAYLIST playlist_ = new PLAYLIST(openFileDialog1.FileName);

                    for (int i = 0; i < playlist_.Count(); i++)
                    {
                        Main.Files.Add(playlist_[i]);
                        Tag Showed_track = new Tag(playlist_[i]);
                        Playlist.Items.Add((i + 1) + ". " + Showed_track.Artist + " — " + Showed_track.Title);
                    }

                    Tag Showed_track_t = new Tag(playlist_[0]);
                    pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                    Track_label_box.Text = Showed_track_t.Artist;
                    Track_label_box2.Text = Showed_track_t.Title;
            }
            else
            {
                string[] deque = openFileDialog1.FileNames;

                for (int i = 0; i < deque.Length; i++)
                {
                    Main.Files.Add(deque[i]);
                    Tag Showed_track = new Tag(deque[i]);
                    Playlist.Items.Add((i + 1) + ". " + Showed_track.Artist + " — " + Showed_track.Title);
                   
                }

                Tag Showed_track_t = new Tag(deque[0]);
                pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                Track_label_box.Text = Showed_track_t.Artist;
                Track_label_box2.Text = Showed_track_t.Title;
            }

            
            
            
        }

        


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label_track.Text = TimeSpan.FromSeconds(MainBass.GetPosOfStream(MainBass.Stream)).ToString();
                flat_track_slider.Value = MainBass.GetPosOfStream(MainBass.Stream);
                percen_bar.Value = MainBass.GetPosOfStream(MainBass.Stream);
                percen_bar2.Value = MainBass.GetPosOfStream(MainBass.Stream);
            }
            catch (System.Exception)
            {

            }
            if(MainBass.NextTrack())
            {
                
                Playlist.SelectedIndex = Main.CurTrackNumber;
                label_track.Text = TimeSpan.FromSeconds(MainBass.GetPosOfStream(MainBass.Stream)).ToString();
                label_track_2.Text = TimeSpan.FromSeconds(MainBass.GetTimeOfStream(MainBass.Stream)).ToString();


                flat_track_slider.MaximumValue = MainBass.GetTimeOfStream(MainBass.Stream);
                flat_track_slider.Value = MainBass.GetPosOfStream(MainBass.Stream);

                percen_bar.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);
                percen_bar2.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);
                percen_bar.Value = MainBass.GetPosOfStream(MainBass.Stream);
                percen_bar2.Value = MainBass.GetPosOfStream(MainBass.Stream);

                Tag Showed_track_t = new Tag(Main.Files[Main.CurTrackNumber]);
                pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                Track_label_box.Text = Showed_track_t.Artist;
                Track_label_box2.Text = Showed_track_t.Title;
            }
            
            if (MainBass.EndOfPlaylist)
            {
                MainBass.Stop();
                timer1.Enabled = false;
                Playlist.SelectedIndex = Main.CurTrackNumber = 0; ;

                flat_track_slider.Value = 0;
                label_track.Text = "00:00:00";
                percen_bar.Value = percen_bar2.Value = 0;
                MainBass.EndOfPlaylist = false;
                bplay_button.Image = PPlayer.Properties.Resources.play;
                MainBass.img_flag = true;

                Tag Showed_track_t = new Tag(Main.Files[0]);
                pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                Track_label_box.Text = Showed_track_t.Artist;
                Track_label_box2.Text = Showed_track_t.Title;
            }
            

        }

        private void bplay_button_Click(object sender, EventArgs e)
        {
            if (MainBass.img_flag)
            {
                if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
                {
                    string cur = Main.Files[Playlist.SelectedIndex];

                    Main.CurTrackNumber = Playlist.SelectedIndex;

                    MainBass.Play(cur, MainBass.Volume);
                    label_track.Text = TimeSpan.FromSeconds(MainBass.GetPosOfStream(MainBass.Stream)).ToString();
                    label_track_2.Text = TimeSpan.FromSeconds(MainBass.GetTimeOfStream(MainBass.Stream)).ToString();
                    flat_track_slider.MaximumValue = MainBass.GetTimeOfStream(MainBass.Stream);
                    percen_bar.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);
                    percen_bar2.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);

                    flat_track_slider.Value = MainBass.GetPosOfStream(MainBass.Stream);


                    timer1.Enabled = true;
                    bplay_button.Image = PPlayer.Properties.Resources.pause2;
                    MainBass.img_flag = false;

                    Tag Showed_track_t = new Tag(Main.Files[Main.CurTrackNumber]);
                    pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                    Track_label_box.Text = Showed_track_t.Artist;
                    Track_label_box2.Text = Showed_track_t.Title;
                }
            }
            else
            {
                MainBass.Pause();
                timer1.Enabled = false;
                bplay_button.Image = PPlayer.Properties.Resources.play2;
                MainBass.img_flag = true;

            }
        }

        private void bopen_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }


        private void Volume_trackbar_ValueChanged(object sender, EventArgs e)
        {
            MainBass.SetVolumeToStream(MainBass.Stream, Volume_trackbar.Value);
        }

        private void flat_track_slider_progressChanged(object sender, EventArgs e)
        {
            MainBass.Scroll(MainBass.Stream, flat_track_slider._Value);
            
        }

       
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        



        private void flat_track_slider_MouseDown(object sender, MouseEventArgs e)
        {
            
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
            {

                float absWidth = flat_track_slider.Width - flat_track_slider.Bounds.X;
                float absMouse = PointToClient(MousePosition).X - flat_track_slider.Bounds.X;
                float progresss = (absMouse * flat_track_slider.MaximumValue) / absWidth;

                

                flat_track_slider.Value = Convert.ToInt32(progresss);

                MainBass.Scroll(MainBass.Stream, flat_track_slider.Value);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
            {

                float absWidth = flat_track_slider.Width - flat_track_slider.Bounds.X;
                float absMouse = PointToClient(MousePosition).X - flat_track_slider.Bounds.X;
                float progresss = (absMouse * flat_track_slider.MaximumValue) / absWidth;

                

                flat_track_slider.Value = Convert.ToInt32(progresss);

                MainBass.Scroll(MainBass.Stream, flat_track_slider.Value);
            }
        }

        private void Playlist_DoubleClick(object sender, EventArgs e)
        {
            
                if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
                {
                    string cur = Main.Files[Playlist.SelectedIndex];

                    Main.CurTrackNumber = Playlist.SelectedIndex;

                    MainBass.Play(cur, MainBass.Volume);
                    label_track.Text = TimeSpan.FromSeconds(MainBass.GetPosOfStream(MainBass.Stream)).ToString();
                    label_track_2.Text = TimeSpan.FromSeconds(MainBass.GetTimeOfStream(MainBass.Stream)).ToString();
                    flat_track_slider.MaximumValue = MainBass.GetTimeOfStream(MainBass.Stream);
                    percen_bar.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);
                    percen_bar2.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);

                    flat_track_slider.Value = MainBass.GetPosOfStream(MainBass.Stream);


                    timer1.Enabled = true;
                    bplay_button.Image = PPlayer.Properties.Resources.pause2;
                    MainBass.img_flag = false;

                    Tag Showed_track_t = new Tag(Main.Files[Main.CurTrackNumber]);
                    pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                    Track_label_box.Text = Showed_track_t.Artist;
                    Track_label_box2.Text = Showed_track_t.Title;
            }
            
        }

        private void bnext_button_Click(object sender, EventArgs e)
        {
            
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
            {
                MainBass.Stop();
                
                Main.CurTrackNumber = (Playlist.SelectedIndex+1 < Main.Files.Count)? ++Playlist.SelectedIndex:0;
                Playlist.SelectedIndex = Main.CurTrackNumber;

                string cur = Main.Files[Playlist.SelectedIndex];

                MainBass.Play(cur, MainBass.Volume);
                label_track.Text = TimeSpan.FromSeconds(MainBass.GetPosOfStream(MainBass.Stream)).ToString();
                label_track_2.Text = TimeSpan.FromSeconds(MainBass.GetTimeOfStream(MainBass.Stream)).ToString();
                flat_track_slider.MaximumValue = MainBass.GetTimeOfStream(MainBass.Stream);
                percen_bar.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);
                percen_bar2.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);

                flat_track_slider.Value = MainBass.GetPosOfStream(MainBass.Stream);

                Tag Showed_track_t = new Tag(Main.Files[Main.CurTrackNumber]);
                pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                Track_label_box.Text = Showed_track_t.Artist;
                Track_label_box2.Text = Showed_track_t.Title;

                timer1.Enabled = true;


            }

            


        }

        private void bprev_button_Click(object sender, EventArgs e)
        {
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
            {
                MainBass.Stop();

                Main.CurTrackNumber = (Playlist.SelectedIndex !=  0) ? --Playlist.SelectedIndex : Main.Files.Count-1;
                Playlist.SelectedIndex = Main.CurTrackNumber;

                string cur = Main.Files[Playlist.SelectedIndex];

                MainBass.Play(cur, MainBass.Volume);
                label_track.Text = TimeSpan.FromSeconds(MainBass.GetPosOfStream(MainBass.Stream)).ToString();
                label_track_2.Text = TimeSpan.FromSeconds(MainBass.GetTimeOfStream(MainBass.Stream)).ToString();
                flat_track_slider.MaximumValue = MainBass.GetTimeOfStream(MainBass.Stream);
                percen_bar.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);
                percen_bar2.MaxValue = MainBass.GetTimeOfStream(MainBass.Stream);

                flat_track_slider.Value = MainBass.GetPosOfStream(MainBass.Stream);
                Tag Showed_track_t = new Tag(Main.Files[Main.CurTrackNumber]);
                pictureBox.Image = (Showed_track_t.picture != null) ? Showed_track_t.picture : PPlayer.Properties.Resources.title;
                Track_label_box.Text = Showed_track_t.Artist;
                Track_label_box2.Text = Showed_track_t.Title;
                timer1.Enabled = true;

            }
        }
    }
}
