using System;
using System.Windows.Forms;
using System.IO;

namespace PgProtEn
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CryptForm());
        }

        public static void CheckKeys()
        {
            if(File.Exists("pubkey.xml") && File.Exists("privkey.xml"))
            {
                Config.publicKey = File.ReadAllText("pubkey.xml");
                Config.privateKey = File.ReadAllText("privkey.xml");
            }
            else
            {
                string[] pair = EncryptionService.CreateKeys();

                Config.publicKey = pair[0];
                Config.privateKey = pair[1];

                File.WriteAllText("pubkey.xml", Config.publicKey);
                File.WriteAllText("privkey.xml", Config.privateKey);
            }
        }
    }
}
