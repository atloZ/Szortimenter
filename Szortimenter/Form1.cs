using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Szortimenter
{
    public partial class Form1 : MaterialForm
    {
        private List<Fajl> fajlok;

        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green800,
                Primary.Green800, Accent.LightGreen200,
                TextShade.WHITE
            );

            fajlok = new List<Fajl>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            locationText.Text = System.Reflection.Assembly.GetEntryAssembly().Location;
            locationText.Text = locationText.Text.Substring(0,locationText.Text.Length - 16);
        }

        private void ujLocatioButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (fbd.SelectedPath != "")
                {
                    locationText.Text = fbd.SelectedPath;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(locationText.Text);
            
            for (int i = 0; i < files.Length; i++)
            {
                fajlok.Add(new Fajl(files[i].Split('\\').Last()));
            }

            for (int i = 0; i < fajlok.Count; i++)
            {
                mappaHaKellLetrehoz(fajlok[i].Kiterjesztes);
                mappabRak(fajlok[i], fajlok[i].Kiterjesztes);

            }
            
            fajlok.Clear();

            if (offRadioButton.Checked == true)
            {
                Application.Exit();
            }
        }

        private void mappabRak(Fajl fajl, string mappa)
        {
            try
            {
                var from = System.IO.Path.Combine(locationText.Text + @"\" + fajl.TeljNev);
                var to = System.IO.Path.Combine(locationText.Text + @"\" + mappa + @"\" + fajl.TeljNev);
                File.Move(from, to); // Try to move
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void mappaHaKellLetrehoz(string mappaNev)
        {
            string s = locationText.Text + @"\" + mappaNev;
            
            if (!Directory.Exists(s))
            {
                Directory.CreateDirectory(s);
            }
        }
    }
}
