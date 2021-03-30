using System.Windows.Forms;
using CefSharp.WinForms;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public partial class ChromiumForm : Form
    {
        private ChromiumWebBrowser chromium;

        public ChromiumForm(string url, string title)
        {
            InitializeComponent();
            Text = title.Split(new string[] { " | " }, System.StringSplitOptions.RemoveEmptyEntries)[0];
            chromium = new ChromiumWebBrowser(url);
            Controls.Clear();
            Controls.Add(chromium);
            chromium.Dock = DockStyle.Fill;
        }
    }
}
