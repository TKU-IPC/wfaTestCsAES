using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTestCsAES
{

    public partial class Form1 : Form
    {
        string _plainText = "This is the text to be encrypted";
        string _iv = "275d75495a3d196e";
        string _key = "b16920894899c7780b5fc7161560a412";
        string _cypherText = "";
        StringBuilder sb = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAES128_Click(object sender, EventArgs e)
        {
            sb.Length = 0;
            sb.AppendLine("AES 128");
            sb.AppendLine("iv=" + _iv);
            sb.AppendLine("key=" + _key);
            sb.AppendLine("Plain text = " + _plainText);
            _cypherText = AES128Helper.AESEncrypt(_plainText, _key);
            sb.AppendLine("Cypher text = " + _cypherText);

            sb.AppendLine("Back text = " + AES128Helper.AESDecrypt(_cypherText, _key));
            textBox1.Text = sb.ToString();

        }

        private void btnAES256_Click(object sender, EventArgs e)
        {
            AES256Helper _crypt = new AES256Helper();
            sb.Length = 0;
            sb.AppendLine("AES 256");
            sb.AppendLine("iv=" + _iv);
            sb.AppendLine("key=" + _key);
            sb.AppendLine("Plain text = " + _plainText);
            _cypherText = _crypt.encrypt(_plainText, _key, _iv);
            sb.AppendLine("Cypher text = " + _cypherText);

            sb.AppendLine("Back text = " + _crypt.decrypt(_cypherText, _key, _iv));
            textBox1.Text = sb.ToString();
        }
    }
}
