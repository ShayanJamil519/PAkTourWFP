using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakistanTour
{
    public partial class Punjab : Form
    {
        string[] FaislabadFood = new string[] { "Biryani                   ", "Pepperoni Pizza        ", "Quarter Broast          ", "Katakat                   ", "Chicken Malai Boti    ", "Chicken Behari Tikka " };
        string[] FaislabadCultures = new string[] { "Education", "Shopping", "Cuisine", "Sports", "Television", "Cinema" };

        string[] LahoreFood = new string[] { "Haleem         ", "Mutton Dalcha  ", "Mirch Salan    ", "Sofiana Biryani", "Boti Kebab     ", "Phirni         " };
        string[] LahoreCultures = new string[] { "Painting", "Handicraft", "Literature", "Jewelry", "Films", "Sport" };

        string[] RawalpindiFood = new string[] { "Kadhi Chawal   ", "Seyal Mani     ", "Chaap Chola    ", "Palla Machli   ", "Mirch Salan    ", "Katakat        " };
        string[] RawalpindiCultures = new string[] { "Jewelry", "Sport", "Films", "Painting", "Films", "Handicraft" };

        public Punjab()
        {
            InitializeComponent();
        }
        private void comboBoxPunjab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPunjab.Text == "Lahore")
            {
                labelListBoxHeadingPunjab.Text = "Foods and Cultures of Lahore";
                labelPicBoxPunjab.Text = "Famous Places of Lahore";

                for (int i = 0; i < LahoreFood.Length; i++)
                {
                    listBoxPunjab.Items.Remove("Dinner: " + (i + 1) + " " + FaislabadFood[i] + "     " + "Culture: " + (i + 1) + " " + FaislabadCultures[i]);
                    listBoxPunjab.Items.Remove("Dinner: " + (i + 1) + " " + RawalpindiFood[i] + "     " + "Culture: " + (i + 1) + " " + RawalpindiCultures[i]);
                }

                for (int i = 0; i < LahoreFood.Length; i++)
                {
                    listBoxPunjab.Items.Add("Dinner: " + (i + 1) + " " + LahoreFood[i] + "     " + "Culture: " + (i + 1) + " " + LahoreCultures[i]);
                }
            }

            if (comboBoxPunjab.Text == "Faisalabad")
            {
                labelListBoxHeadingPunjab.Text = "Foods and Cultures of Faisalabad";
                labelPicBoxPunjab.Text = "Famous Places of Faisalabad";

                for (int i = 0; i < LahoreFood.Length; i++)
                {
                    listBoxPunjab.Items.Remove("Dinner: " + (i + 1) + " " + LahoreFood[i] + "     " + "Culture: " + (i + 1) + " " + LahoreCultures[i]);
                    listBoxPunjab.Items.Remove("Dinner: " + (i + 1) + " " + RawalpindiFood[i] + "     " + "Culture: " + (i + 1) + " " + RawalpindiCultures[i]);
                }

                for (int i = 0; i < LahoreFood.Length; i++)
                {
                    listBoxPunjab.Items.Add("Dinner: " + (i + 1) + " " + FaislabadFood[i] + "     " + "Culture: " + (i + 1) + " " + FaislabadCultures[i]);
                }
            }

            if (comboBoxPunjab.Text == "Rawalpindi")
            {
                labelListBoxHeadingPunjab.Text = "Foods and Cultures of Rawalpindi";
                labelPicBoxPunjab.Text = "Famous Places of Rawalpindi";

                for (int i = 0; i < LahoreFood.Length; i++)
                {
                    listBoxPunjab.Items.Remove("Dinner: " + (i + 1) + " " + LahoreFood[i] + "     " + "Culture: " + (i + 1) + " " + LahoreCultures[i]);
                    listBoxPunjab.Items.Remove("Dinner: " + (i + 1) + " " + FaislabadFood[i] + "     " + "Culture: " + (i + 1) + " " + FaislabadCultures[i]);
                }

                for (int i = 0; i < LahoreFood.Length; i++)
                {
                    listBoxPunjab.Items.Add("Dinner: " + (i + 1) + " " + RawalpindiFood[i] + "     " + "Culture: " + (i + 1) + " " + RawalpindiCultures[i]);
                }
            }
        }

        int IndexOfImagePunjab = 0;
        private void buttonNextPunjab_Click(object sender, EventArgs e)
        {
            if (comboBoxPunjab.Text == "Lahore")
            {
                if (IndexOfImagePunjab < 3)
                {
                    pictureBoxPunjab.Image = imageListLahore.Images[IndexOfImagePunjab];
                    pictureBoxPunjab.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImagePunjab++;
                }
            }

            if (comboBoxPunjab.Text == "Faisalabad")
            {
                if (IndexOfImagePunjab < 3)
                {
                    pictureBoxPunjab.Image = imageListFaisalabad.Images[IndexOfImagePunjab];
                    pictureBoxPunjab.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImagePunjab++;
                }
            }

            if (comboBoxPunjab.Text == "Rawalpindi")
            {
                if (IndexOfImagePunjab < 3)
                {
                    pictureBoxPunjab.Image = imageListRawalpindi.Images[IndexOfImagePunjab];
                    pictureBoxPunjab.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImagePunjab++;

                }
            }
        }

        private void buttonPreviousPunjab_Click(object sender, EventArgs e)
        {
            if (comboBoxPunjab.Text == "Lahore")
            {
                if (IndexOfImagePunjab > 0)
                {
                    IndexOfImagePunjab--;
                }
                pictureBoxPunjab.Image = imageListLahore.Images[IndexOfImagePunjab];
                pictureBoxPunjab.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxPunjab.Text == "Faisalabad")
            {
                if (IndexOfImagePunjab > 0)
                {
                    IndexOfImagePunjab--;
                }
                pictureBoxPunjab.Image = imageListFaisalabad.Images[IndexOfImagePunjab];
                pictureBoxPunjab.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxPunjab.Text == "Rawalpindi")
            {
                if (IndexOfImagePunjab > 0)
                {
                    IndexOfImagePunjab--;
                }
                pictureBoxPunjab.Image = imageListRawalpindi.Images[IndexOfImagePunjab];
                pictureBoxPunjab.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}



