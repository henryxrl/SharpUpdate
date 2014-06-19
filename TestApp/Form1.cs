using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SharpUpdate;

namespace TestApp
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        private SharpUpdater updater;

        public Form1()
        {
            InitializeComponent();

            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        #region SharpUpdate
        public string ApplicationName
        {
            get { return "TestApp"; }
        }

        public string ApplicationID
        {
            get { return "TestApp"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
			get { return new Uri("https://github.com/henryxrl/SharpUpdate/blob/master/project.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion
    }
}
