using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechToTextClassLibrary;

namespace SpeechToTextWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartSpeaking_Click(object sender, EventArgs e)
        {
            var repository = new Repository();
            var outputStr = repository.ReturnSpeech();
            lblSpeech.Text = outputStr;
        }
    }
}
