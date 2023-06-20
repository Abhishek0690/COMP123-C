using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab___GUI_Premier
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeGui();
        }
        private Dictionary<string, Premier> premiers;
        private void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();
            List<Premier> shows = Premier.GetPremiers();
            foreach (Premier a in shows)
            {
                string key = a.GenerateKey();
                premiers.Add(key, a);
            }
            List<string> keys = new List<string>(premiers.Keys);
            listBox1.DataSource = keys;
        }
        void UpdateGui()
        {
            string SelectedKey = listBox1.SelectedItem.ToString();
            if (SelectedKey == null)
            {
                MessageBox.Show("please select an item");
            }
            else
            {
                Premier premier = premiers[SelectedKey];
                label1.Text = $"{premier.Name}";
                label2.Text = $"{premier.Life}";
                label3.Text = $"{premier.Start} - {premier.End}";
            }
            pictureBox1.Image = Image.FromFile("images/" + SelectedKey + ".jpg");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
