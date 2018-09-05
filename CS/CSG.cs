using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS
{
    public partial class CSG : Form
    {
        static readonly string template = @"Data Source={0};initial catalog={1};user Id={2};password={3};";
        public CSG()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxResult.Text = string.Format(template, this.textBoxAddress.Text, this.textBoxDbName.Text, this.textBoxUser.Text, this.textBoxPassword.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.buttonOk;
            this.CancelButton = this.buttonCancel;
        }
    }
}
