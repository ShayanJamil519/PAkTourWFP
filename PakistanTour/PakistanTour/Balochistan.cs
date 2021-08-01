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
    public partial class Balochistan : Form
    {
        string[] KhuzdarFoods = new string[] { "Biryani                   ", "Pepperoni Pizza        ", "Quarter Broast          ", "Katakat                   ", "Chicken Malai Boti    ", "Chicken Behari Tikka " };
        string[] KhuzdarCultures = new string[] { "Education", "Shopping", "Cuisine", "Sports", "Television", "Cinema" };

        string[] TurbatFoods = new string[] { "Haleem         ", "Mutton Dalcha  ", "Mirch Salan    ", "Sofiana Biryani", "Boti Kebab     ", "Phirni         " };
        string[] TurbatCultures = new string[] { "Painting", "Handicraft", "Literature", "Jewelry", "Films", "Sport" };

        string[] QuettaFoods = new string[] { "Kadhi Chawal   ", "Seyal Mani     ", "Chaap Chola    ", "Palla Machli   ", "Mirch Salan    ", "Katakat        " };
        string[] QuettaCultures = new string[] { "Jewelry", "Sport", "Films", "Painting", "Films", "Handicraft" };

        public Balochistan()
        {
            InitializeComponent();
        }

        private void comboBoxBalochistan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBalochistan.Text == "Quetta")
            {
                labelListBoxHeadingBalochistan.Text = "Foods and Cultures of Quetta";
                labelPicBoxBalochistan.Text = "Famous Places of Quetta";

                for (int i = 0; i < QuettaFoods.Length; i++)
                {
                    listBoxBalochistan.Items.Remove("Dinner: " + (i + 1) + " " + TurbatFoods[i] + "     " + "Culture: " + (i + 1) + " " + TurbatCultures[i]);
                    listBoxBalochistan.Items.Remove("Dinner: " + (i + 1) + " " + KhuzdarFoods[i] + "     " + "Culture: " + (i + 1) + " " + KhuzdarCultures[i]);
                }

                for (int i = 0; i < QuettaFoods.Length; i++)
                {
                    listBoxBalochistan.Items.Add("Dinner: " + (i + 1) + " " + QuettaFoods[i] + "     " + "Culture: " + (i + 1) + " " + QuettaCultures[i]);
                }
            }

            if (comboBoxBalochistan.Text == "Khuzdar")
            {
                labelListBoxHeadingBalochistan.Text = "Foods and Cultures of Khuzdar";
                labelPicBoxBalochistan.Text = "Famous Places of Khuzdar";

                for (int i = 0; i < QuettaFoods.Length; i++)
                {
                    listBoxBalochistan.Items.Remove("Dinner: " + (i + 1) + " " + TurbatFoods[i] + "     " + "Culture: " + (i + 1) + " " + TurbatCultures[i]);
                    listBoxBalochistan.Items.Remove("Dinner: " + (i + 1) + " " + QuettaFoods[i] + "     " + "Culture: " + (i + 1) + " " + QuettaCultures[i]);
                }

                for (int i = 0; i < QuettaFoods.Length; i++)
                {
                    listBoxBalochistan.Items.Add("Dinner: " + (i + 1) + " " + KhuzdarFoods[i] + "     " + "Culture: " + (i + 1) + " " + KhuzdarCultures[i]);
                }
            }

            if (comboBoxBalochistan.Text == "Turbat")
            {
                labelListBoxHeadingBalochistan.Text = "Foods and Cultures of Turbat";
                labelPicBoxBalochistan.Text = "Famous Places of Turbat";

                for (int i = 0; i < QuettaFoods.Length; i++)
                {
                    listBoxBalochistan.Items.Remove("Dinner: " + (i + 1) + " " + KhuzdarFoods[i] + "     " + "Culture: " + (i + 1) + " " + KhuzdarCultures[i]);
                    listBoxBalochistan.Items.Remove("Dinner: " + (i + 1) + " " + QuettaFoods[i] + "     " + "Culture: " + (i + 1) + " " + QuettaCultures[i]);
                }

                for (int i = 0; i < QuettaFoods.Length; i++)
                {
                    listBoxBalochistan.Items.Add("Dinner: " + (i + 1) + " " + TurbatFoods[i] + "     " + "Culture: " + (i + 1) + " " + TurbatCultures[i]);
                }
            }




        }
        int IndexOfImageBalochistan = 0;
        private void buttonNextBalochistan_Click(object sender, EventArgs e)
        {
            if (comboBoxBalochistan.Text == "Quetta")
            {
                if (IndexOfImageBalochistan < 3)
                {
                    pictureBoxBalochistan.Image = imageListQuetta.Images[IndexOfImageBalochistan];
                    pictureBoxBalochistan.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImageBalochistan++;
                }
            }

            if (comboBoxBalochistan.Text == "Khuzdar")
            {
                if (IndexOfImageBalochistan < 3)
                {
                    pictureBoxBalochistan.Image = imageListKhuzdar.Images[IndexOfImageBalochistan];
                    pictureBoxBalochistan.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImageBalochistan++;
                }
            }

            if (comboBoxBalochistan.Text == "Turbat")
            {
                if (IndexOfImageBalochistan < 3)
                {
                    pictureBoxBalochistan.Image = imageListTurbat.Images[IndexOfImageBalochistan];
                    pictureBoxBalochistan.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImageBalochistan++;
                }
            }


        }

        private void buttonPreviousBalochistan_Click(object sender, EventArgs e)
        {

            if (comboBoxBalochistan.Text == "Quetta")
            {
                if (IndexOfImageBalochistan > 0)
                {
                    IndexOfImageBalochistan--;
                }
                pictureBoxBalochistan.Image = imageListQuetta.Images[IndexOfImageBalochistan];
                pictureBoxBalochistan.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxBalochistan.Text == "Khuzdar")
            {
                if (IndexOfImageBalochistan > 0)
                {
                    IndexOfImageBalochistan--;
                }
                pictureBoxBalochistan.Image = imageListKhuzdar.Images[IndexOfImageBalochistan];
                pictureBoxBalochistan.SizeMode = PictureBoxSizeMode.StretchImage;
            }


            if (comboBoxBalochistan.Text == "Turbat")
            {
                if (IndexOfImageBalochistan > 0)
                {
                    IndexOfImageBalochistan--;
                }
                pictureBoxBalochistan.Image = imageListTurbat.Images[IndexOfImageBalochistan];
                pictureBoxBalochistan.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }
    }
}
