using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {

        public Settings settings = Settings.getInstance();
        //Form1 form1;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();
            tbSender.Text = settings.sMailAddr();
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            form1 = new Form1();
        }*/

        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();
            this.Close();

            //form1.tbTo.Text = tbUserName.Text;
            //form1.tbCc.Text = tbUserName.Text;
            //form1.tbBcc.Text = tbUserName.Text;
            //form1.ShowDialog();
            //this.Close();
        }

        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();

            //form1.tbTo.Text = tbUserName.Text;
            //form1.tbCc.Text = tbUserName.Text;
            //form1.tbBcc.Text = tbUserName.Text;
            //form1.ShowDialog();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
