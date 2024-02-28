using ARventure_Path.Models;
using ARventure_Path.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class HappeningSoundForm : Form
    {
        private MyUtils.FormType formType;
        bool Play = false;
        private string audioRoute;
        private string audio;
        private string fileName;
        public HappeningSoundForm(MyUtils.FormType formType)
        {
            this.formType = formType;
            InitializeComponent();
        }

        private void HappeningSoundForm_Load(object sender, EventArgs e)
        {
            ChooseTypeOfForm();
            bindingSourceStory.DataSource = StoryOrm.Select();
            comboBoxStories.SelectedItem = null;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos MP3|*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                audio = openFileDialog.SafeFileName;
                audioRoute = openFileDialog.FileName;
                Mp3Player.URL = audioRoute;
                btnPlay.Image = Properties.Resources.pause;
                textBoxUrl.Text = audioRoute;

                fileName = Path.GetFileName(audioRoute);
            }
            {

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Mp3Player.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play;
                    Play = false;
                    break;
                case false:
                    Mp3Player.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Mp3Player.Ctlcontrols.stop();
            btnPlay.Image= Properties.Resources.play;
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshDataTrack();
            macTrackBarPlayer.Value = (int)Mp3Player.Ctlcontrols.currentPosition;
            macTrackBarVolume.Value = Mp3Player.settings.volume;
        }
        public void refreshDataTrack()
        {
            if (Mp3Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                macTrackBarPlayer.Maximum= (int)Mp3Player.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }else if (Mp3Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();

            }else if (Mp3Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                macTrackBarPlayer.Value = 0;
            }
        }

        private void Mp3Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            refreshDataTrack();
        }

        private void macTrackBarVolume_ValueChanged(object sender, decimal value)
        {
            Mp3Player.settings.volume = macTrackBarVolume.Value;
        }

        private void macTrackBarPlayer_ValueChanged(object sender, decimal value)
        {
           // Mp3Player.Ctlcontrols.currentPosition = macTrackBarPlayer.Value;
        }
 
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (formType == MyUtils.FormType.Create)
            {
                // Crear Evento de audio
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar Evento de audio
            }
            else
            {
                // Borrar Evento de audio
            }

            if (textBoxName.Text.Trim() != "" &&
                fileName != null &&
                comboBoxStories.SelectedItem != null)
            {
                happening happening = new happening();
                happening.name = textBoxName.Text.Trim();
                happening.url = fileName;
                happening.type = "audio";
                happening.idStory = (int)comboBoxStories.SelectedValue;


                string msg = HappeningOrm.Insert(happening);
                if (msg != "")
                {
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Evento creado satisfactoriamente.", "Éxito!");
                    Close();
                }

            }
            else if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("No has introducido nombre de evento.", "Error");
            }
            else if (comboBoxStories.SelectedItem == null)
            {
                MessageBox.Show("No has escogido la historia a la que pertenece.", "Error");

            }
            else if(fileName == null)
            {
                MessageBox.Show("No has escogido un archivo de audio.", "Error");
            }
        }
        private void ChooseTypeOfForm()
        {

            if (formType == MyUtils.FormType.Create)
            {
                becomeInCreatonForm();
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                becomeInModifyForm();
            }
            else
            {
                becomeInDeleteForm();
                
            }
        }

        private void becomeInDeleteForm()
        {
            buttonCreate.Text = "Borrar";
            bindingSourceHappenings.DataSource = HappeningOrm.Select("audio");
            Text = "Borrar evento de audio";
        }

        private void becomeInModifyForm()
        {
            buttonCreate.Text = "Guardar";
            bindingSourceHappenings.DataSource = HappeningOrm.Select("audio");
            Text = "Modificar evento de audio";

        }

        private void becomeInCreatonForm()
        {
            labelSelectHappening.Visible = false;
            comboBoxHappenings.Visible = false;
        }
    }
}
