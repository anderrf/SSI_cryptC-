using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace atvHash_Ex2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnAplicacao_Click(object sender, EventArgs e)
        {
            string original = txtOriginal.Text;

            try
            {
                txtMD5.Text = Cripto(original);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                txtSHA1.Text = Cripto2(original);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string Cripto(string original)
        {
            string strCrypt = "";
            byte[] mensagem = System.Text.Encoding.Default.GetBytes(original);
            System.Security.Cryptography.MD5CryptoServiceProvider txtmd5 = new MD5CryptoServiceProvider();
            byte[] txthashcode = txtmd5.ComputeHash(mensagem);
            for (int i = 0; i < txthashcode.Length; i++)
            {
                strCrypt += (char)(txthashcode[i]);
            }
            return (strCrypt);
        }

        public string Cripto2(string original)
        {
            string strCrypt = "";
            byte[] mensagem = System.Text.Encoding.Default.GetBytes(original);
            System.Security.Cryptography.SHA1Managed txtsha1 = new SHA1Managed();
            byte[] txthashcode = txtsha1.ComputeHash(mensagem);
            for (int i = 0; i < txthashcode.Length; i++)
            {
                strCrypt += (char)(txthashcode[i]);
            }
            return (strCrypt);
        }
    }
}
