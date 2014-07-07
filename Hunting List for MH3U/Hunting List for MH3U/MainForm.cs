using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunting_List_for_MH3U
{
    public partial class MainForm : Form
    {
        ImageList genders;
        public MainForm()
        {
            InitializeComponent();
            initGendersImageList();
        }

        private void btnAmrGender_Click(object sender, EventArgs e)
        {
            if (btnAmrGender.ImageIndex == 2)
            {
                btnAmrGender.ImageIndex = 0;
            }
            else
            {
                btnAmrGender.ImageIndex++;
            }
        }

        private void initGendersImageList()
        {
            genders = new ImageList();
            genders.ImageSize = new Size(24, 24);
            genders.Images.Add(Properties.Resources.icnGenders);
            genders.Images.Add(Properties.Resources.icnGendersMaleCentered);
            genders.Images.Add(Properties.Resources.icnGendersFemaleCentered);
            btnAmrGender.ImageList = genders;
            btnAmrGender.ImageIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnAmrGender.ImageIndex.ToString());
        }
    }
}
