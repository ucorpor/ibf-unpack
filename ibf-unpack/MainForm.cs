using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ibf_unpack
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string version = FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
            Text += $" v{version}";
        }

        private void pathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "IBF-files (*.ibf)|*.ibf|All files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathTxt.Text = dialog.FileName;
            }
        }

        private void unpackBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                string path = pathTxt.Text.Trim();
                IbfUnpack.Unpack(path, renameCb.Checked);
                string systemDir = Path.Combine(Path.GetDirectoryName(path), "System");
                string message = $"Successfully unpacked to:{Environment.NewLine}{systemDir}";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ucorpor/ibf-unpack");
        }

    }
}
