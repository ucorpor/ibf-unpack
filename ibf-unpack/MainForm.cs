using System;
using System.IO;
using System.Windows.Forms;

namespace ibf_unpack
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void pathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathTxt.Text = dialog.FileName;
            }
        }

        private void unpackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathTxt.Text.Trim();
                IbfUnpack.Unpack(path);
                string systemDir = Path.Combine(Path.GetDirectoryName(path), "System");
                string message = $"Successfully unpacked to:{Environment.NewLine}{systemDir}";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
