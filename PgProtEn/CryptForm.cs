using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PgProtEn
{
    public partial class CryptForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public CryptForm()
        {
            InitializeComponent();
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CryptForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            CryptForm_MouseDown(sender, e);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            CryptForm_MouseDown(sender, e);
        }

        private void INPUT_FIELD_Enter(object sender, EventArgs e)
        {
            if(INPUT_FIELD.Text == "Type your message here" || INPUT_FIELD.Text == "Paste your encrypted message here")
            {
                INPUT_FIELD.Text = "";
                INPUT_FIELD.ForeColor = Color.White;
            }
        }

        private void INPUT_FIELD_Leave(object sender, EventArgs e)
        {
            if (INPUT_FIELD.Text == "")
            {
                if (ENCRYPT_SWITCH.Checked)
                {
                    INPUT_FIELD.Text = "Type your message here";
                }
                else
                {
                    INPUT_FIELD.Text = "Paste your encrypted message here";
                }
                
                INPUT_FIELD.ForeColor = Color.DarkGray;
            }
        }

        private void OUTPUT_FIELD_Enter(object sender, EventArgs e)
        {
            if (OUTPUT_FIELD.Text == "Encrypted message" || OUTPUT_FIELD.Text == "Decrypted message")
            {
                OUTPUT_FIELD.Text = "";
                OUTPUT_FIELD.ForeColor = Color.White;
            }
        }

        private void OUTPUT_FIELD_Leave(object sender, EventArgs e)
        {
            if (OUTPUT_FIELD.Text == "")
            {
                if (ENCRYPT_SWITCH.Checked)
                {
                    OUTPUT_FIELD.Text = "Encrypted message";
                }
                else
                {
                    OUTPUT_FIELD.Text = "Decrypted message";
                }
                
                OUTPUT_FIELD.ForeColor = Color.DarkGray;
            }
        }

        private void SETTINGS_BUTTON_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private void CryptForm_Load(object sender, EventArgs e)
        {
            Program.CheckKeys();
        }

        private void ENCRYPT_SWITCH_CheckedChanged(object sender, EventArgs e)
        {
            if (ENCRYPT_SWITCH.Checked)
            {
                INPUT_FIELD.Text = "Type your message here";
                INPUT_FIELD.ForeColor = Color.DarkGray;

                OUTPUT_FIELD.Text = "Encrypted message";
                OUTPUT_FIELD.ForeColor = Color.DarkGray;

                PROCESS_OPERATION_BUTTON.Text = "Encrypt";
            }
            else
            {
                INPUT_FIELD.Text = "Paste your encrypted message here";
                INPUT_FIELD.ForeColor = Color.DarkGray;

                OUTPUT_FIELD.Text = "Decrypted message";
                OUTPUT_FIELD.ForeColor = Color.DarkGray;

                PROCESS_OPERATION_BUTTON.Text = "Decrypt";
            }
        }

        private void PROCESS_OPERATION_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(INPUT_FIELD.Text))
                {
                    if (ENCRYPT_SWITCH.Checked)
                    {
                        OUTPUT_FIELD.Text = BTTEncoder.Encode(EncryptionService.Encrypt(INPUT_FIELD.Text, Config.publicKey));
                        OUTPUT_FIELD.ForeColor = Color.White;
                    }
                    else
                    {
                        OUTPUT_FIELD.Text = EncryptionService.Decrypt(BTTEncoder.Decode(INPUT_FIELD.Text), Config.privateKey);
                        OUTPUT_FIELD.ForeColor = Color.White;
                    }
                    
                }
            }
            catch
            {
                OUTPUT_FIELD.ForeColor = Color.Red;
                errorAnimation.Start();
            }
        }

        private void errorAnimation_Tick(object sender, EventArgs e)
        {
            OUTPUT_FIELD.ForeColor = Color.DarkGray;
            errorAnimation.Stop();
        }
    }
}
