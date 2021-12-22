using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ililce
{
    public partial class ililceFrm : Form
    {
        public ililceFrm()
        {
            InitializeComponent();
        }

        private void ilyuklebtn_Click(object sender, EventArgs e)
        {
            String[] iller = File.ReadAllLines("iller.txt");
            for(int i=0;i<iller.Length;i++)
            {
                String[] satir = iller[i].Split('	');
                illercmb.Items.Add(satir[1]);
            }

        }

        private void illercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcelercmb.Items.Clear();
            String[] ilceler = File.ReadAllLines("ilceler.txt");
            for (int i = 0; i < ilceler.Length; i++)
            {
                String[] satir = ilceler[i].Split('	');
                if(satir[2]==(illercmb.SelectedIndex+1).ToString())
                {
                    ilcelercmb.Items.Add(satir[1]);
                }
            }
        }
    }
}
