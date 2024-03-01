using ARventure_Path.Models;
using ARventure_Path.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class HappeningSoundForm : Form
    {
        bool Play = false;
        private string audioPath = Path.Combine(Application.StartupPath, "..", "..", "filesToServer", "audioHappening");
        private string filePath;
        private string fileName;
        private MyUtils.FormType formType;

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

            if (formType == MyUtils.FormType.Create)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    Mp3Player.URL = filePath;
                    btnPlay.Image = Properties.Resources.pause;
                    textBoxUrl.Text = filePath;

                    fileName = Path.GetFileName(filePath);
                }
            } else if (formType == MyUtils.FormType.Modify)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    filePath = openFileDialog.FileName;
                    Mp3Player.URL = filePath;
                    btnPlay.Image = Properties.Resources.pause;
                    if (Path.GetFileName(filePath) != fileName)
                    {
                        deleteAudio();
                    }
                    textBoxUrl.Text = filePath;

                    fileName = Path.GetFileName(filePath);
                }
            }
        }
        private void saveAudio()
        {
            if (!Directory.Exists(audioPath))
            {
                Directory.CreateDirectory(audioPath);
            }
            String destinationPath = Path.Combine(audioPath, fileName);
            File.Copy(filePath, destinationPath, true);                
            
        }
        private void deleteAudio()
        {
            String destinationPath = Path.Combine(audioPath, fileName);
            if (File.Exists(destinationPath))
            {
                try
                {
                    File.Delete(destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el archivo: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe en la ruta especificada.", "Error");
            }
        }
        private void comboBoxHappenings_SelectedIndexChanged(object sender, EventArgs e)
        {
            happening happening = (happening)comboBoxHappenings.SelectedItem;
            if (happening != null)
            {
                if (formType == MyUtils.FormType.Modify)
                {
                    comboBoxStories.Enabled = true;
                    groupboxIA.Enabled = true;
                    groupboxAudioHappening.Enabled = true;
                }else if(formType == MyUtils.FormType.Delete)
                {
                    groupboxAudioHappening.Enabled = true;
                    textBoxName.Enabled = false;
                    textBoxUrl.Enabled = false;
                    buttonSearch.Enabled = false;
                }
                buttonCreate.Enabled = true;
                comboBoxStories.SelectedItem = happening.story;
                textBoxName.Text = happening.name;
                fileName = happening.url;
                filePath = Path.Combine(audioPath, fileName);
                Mp3Player.URL = filePath;
                btnPlay.Image = Properties.Resources.pause;
                textBoxUrl.Text = filePath;
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
            // Obtener la posición actual en segundos como un double
            double currentPosition = Mp3Player.Ctlcontrols.currentPosition;

            // Convertir los segundos a minutos y segundos
            int minutos = (int)(currentPosition / 60);
            int segundos = (int)(currentPosition % 60);

            // Crear una cadena formateada en el patrón "0:00"
            string tiempoFormateado = string.Format("{0}:{1:00}", minutos, segundos);

            // Asignar el texto al control labelDuration
            labelDuration.Text = tiempoFormateado;
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
                if (textBoxName.Text.Trim() != "" &&
                fileName != null &&
                comboBoxStories.SelectedItem != null)
                {
                    happening happening = new happening();
                    happening.name = textBoxName.Text.Trim();
                    happening.url = fileName;
                    happening.type = "audio";
                    happening.idStory = (int)comboBoxStories.SelectedValue;
                    saveAudio();


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
                else if (fileName == null)
                {
                    MessageBox.Show("No has escogido un archivo de audio.", "Error");
                }
            }
            else if (formType == MyUtils.FormType.Modify)
            {
                // Modificar Evento de audio
                happening happening = (happening)comboBoxHappenings.SelectedItem;

                if (happening != null
                    && textBoxName.Text.Trim() != "" &&
                    fileName != null &&
                    comboBoxStories.SelectedItem != null)
                {
                    if (happening.url != fileName)
                    {
                        saveAudio();
                    }
                    happening.name = textBoxName.Text.Trim();
                    happening.url = fileName;
                    happening.type = "audio";
                    happening.idStory = (int)comboBoxStories.SelectedValue;
                    
                        
                    string msg = Orm.Update();
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Evento modificado satisfactoriamente.", "Éxito!");
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
                else if (fileName == null)
                {
                    MessageBox.Show("No has escogido un archivo de audio.", "Error");
                }
            }
            else
            {
                // Borrar Evento de audio
                happening happening = (happening)comboBoxHappenings.SelectedItem;
                if (happening != null)
                {
                    string msg = HappeningOrm.Delete(happening);

                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El evento se ha eliminado correctamente.", "Éxito!");
                        deleteAudio();
                        Close();
                    }
                }
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
            comboBoxHappenings.SelectedItem = null;
            comboBoxStories.Enabled = false;
            groupboxIA.Enabled = false;
            groupboxAudioHappening.Enabled = false;
            Text = "Borrar evento de audio";
        }

        private void becomeInModifyForm()
        {
            buttonCreate.Text = "Guardar";
            bindingSourceHappenings.DataSource = HappeningOrm.Select("audio");
            comboBoxHappenings.SelectedItem = null;
            comboBoxStories.Enabled = false;
            groupboxIA.Enabled = false;
            groupboxAudioHappening.Enabled = false;
            Text = "Modificar evento de audio";

        }

        private void becomeInCreatonForm()
        {
            labelSelectHappening.Visible = false;
            comboBoxHappenings.Visible = false;
            buttonCreate.Enabled = true;
        }

        private void HappeningSoundForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mp3Player.close();
        }
    }
}
