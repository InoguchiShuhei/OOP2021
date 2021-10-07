using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class ConfigForm : Form
    {

        Settings settings = Settings.getInstance();
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

        

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();

            


            //form1.tbTo.Text = tbUserName.Text;
            //form1.tbCc.Text = tbUserName.Text;
            //form1.tbBcc.Text = tbUserName.Text;
            //form1.ShowDialog();
        }

        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }
    }
}
