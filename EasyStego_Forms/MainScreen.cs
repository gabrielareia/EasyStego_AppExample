using Easy_Stego;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStego_Forms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            labelErrorDecrypt.Text = "";
            labelErrorEncrypt.Text = "";
        }

        //Encrypt

        string ePublicImagePath;
        string eHiddenFilePath;
        string eOutputPath;

        bool eSkipAlpha = false;

        private void buttonPublicImageEncrypt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "supported files (*.png) |*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ePublicImagePath = openFileDialog1.FileName;

                string fileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\') + 1);
                labelPathImageEncrypt.Text = fileName;
            }
        }

        private void buttonHiddenFileEncrypt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "supported files (*.txt/*.png)|*.txt;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                eHiddenFilePath = openFileDialog1.FileName;

                string fileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\') + 1);
                labelPathFileEncrypt.Text = fileName;
            }
        }

        private void buttonOutputEncrypt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "png file (*.png)|*.png";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                eOutputPath = saveFileDialog1.FileName;

                var s = saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.LastIndexOf('\\'));
                string fileName = saveFileDialog1.FileName.Substring(s.LastIndexOf('\\') + 1);
                labelPathOutputEncrypt.Text = fileName;
            }
        }

        private async void buttonEncrypt_Click(object sender, EventArgs e)
        {
            labelErrorEncrypt.Text = "";

            if (string.IsNullOrEmpty(ePublicImagePath) || string.IsNullOrEmpty(eHiddenFilePath)
                || string.IsNullOrEmpty(eOutputPath))
            {
                labelErrorEncrypt.Text = "At least one field above is empty. Please fill all of them.";
                return;
            }

            try
            {
                await Task.Run(() =>
                {
                    string path = eHiddenFilePath.Substring(eHiddenFilePath.LastIndexOf('.') + 1);
                    if (path == "png")
                    {
                        EasyStego.EncryptImageWithImage(ePublicImagePath, eHiddenFilePath, eOutputPath, eSkipAlpha);
                    }
                    else if (path == "txt")
                    {
                        EasyStego.EncryptImageWithText(ePublicImagePath, eHiddenFilePath, eOutputPath, eSkipAlpha);
                    }
                    else
                    {
                        return;
                    }
                });
            }
            catch (Exception exception)
            {
                //Deal with exception
                labelErrorEncrypt.Text = $"An error has occurred: {exception.Message}";
                Debug.WriteLine($"Exception: '{exception.Message}' while encrypting");
            }
        }

        //Decrypt

        string dImagePath;
        string dOutputPath;

        bool dSkipAlpha = false;

        private void buttonImageDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "supported files (*.png) |*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dImagePath = openFileDialog1.FileName;

                string fileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\') + 1);
                labelPathImageDecrypt.Text = fileName;
            }
        }

        private void buttonOutputDecrypt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "png file (*.png)|*.png|" +
                "text file (*.txt)|*.txt|supported files (*.png/*.txt)|*.png;*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dOutputPath = saveFileDialog1.FileName;

                var s = saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.LastIndexOf('\\'));
                string fileName = saveFileDialog1.FileName.Substring(s.LastIndexOf('\\') + 1);
                labelPathOutputDecrypt.Text = fileName;
            }
        }



        private async void buttonDecrypt_Click(object sender, EventArgs e)
        {
            labelErrorDecrypt.Text = "";
            if (string.IsNullOrEmpty(dImagePath) || string.IsNullOrEmpty(dOutputPath))
            {
                labelErrorDecrypt.Text = "At least one field above is empty. Please fill all of them.";
                return;
            }

            try
            {
                await Task.Run(() =>
                {
                    string path = dOutputPath.Substring(dOutputPath.LastIndexOf('.') + 1);
                    if (path == "png")
                    {
                        EasyStego.DecryptImageWithImage(dImagePath, dOutputPath, dSkipAlpha);
                    }
                    else if (path == "txt")
                    {
                        EasyStego.DecryptImageWithText(dImagePath, dOutputPath, Encoding.UTF8, dSkipAlpha);
                    }
                    else
                    {
                        return;
                    }
                });

            }
            catch (Exception exception)
            {
                //Deal with exception
                labelErrorDecrypt.Text = $"An error has occurred: {exception.Message}";
                Debug.WriteLine($"Exception: '{exception.Message}' while decrypting");
            }

        }

        private void checkBoxEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            eSkipAlpha = checkBoxEncrypt.Checked;
        }

        private void checkBoxDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            dSkipAlpha = checkBoxDecrypt.Checked;
        }
    }
}
