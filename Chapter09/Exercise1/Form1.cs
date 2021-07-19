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

namespace Exercise1 {
    public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void btOpen_Click(object sender, EventArgs e) {
        if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
            using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();  //１行読み込み
                    tbOutput.Text += line + "\r\n";
                }
            }
        }
    }

    private void tbKeyWord_TextChanged(object sender, EventArgs e) {
        if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
            int count = 0;
            using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                while (reader.EndOfStream) {
                    var line = reader.ReadLine();  //１行読み込み
                    if (line.Contains(tbKeyWord.Text))
                        count++;                        
                }
                tbOutput.Text = ("キーワード" + tbKeyWord.Text + "が含まれている行は、" + count.ToString() + "行です。");
            }
        }
    }

    private void btRAL_Click(object sender, EventArgs e) {
        if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
            int count = 0;
            var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis")); {
                    foreach (var line in lines)
                    if (line.Contains(tbKeyWord.Text))
                        count++;
                }
                tbOutput.Text = ("キーワード" + tbKeyWord.Text + "が含まれている行は、" + count.ToString() + "行です。");
            }
        }

        private void btRL_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                {
                    foreach (var line in lines)
                        if (line.Contains(tbKeyWord.Text))
                            count++;
                }
                tbOutput.Text = ("キーワード" + tbKeyWord.Text + "が含まれている行は、" + count.ToString() + "行です。");
            }
        }
    }
}
