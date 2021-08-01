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
    public partial class Sindh : Form
    {
        string[] Karachifoods = new string[] { "Biryani                   ", "Pepperoni Pizza        ", "Quarter Broast          ", "Katakat                   ", "Chicken Malai Boti    ", "Chicken Behari Tikka " };
        string[] Karachicultures = new string[] { "Education", "Shopping", "Cuisine", "Sports", "Television", "Cinema" };

        string[] HyderabadFoods = new string[] { "Haleem         ", "Mutton Dalcha  ", "Mirch Salan    ", "Sofiana Biryani", "Boti Kebab     ", "Phirni         " };
        string[] HyderabadCultures = new string[] { "Painting", "Handicraft", "Literature", "Jewelry", "Films", "Sport" };

        string[] LarkanaFoods = new string[] { "Kadhi Chawal   ", "Seyal Mani     ", "Chaap Chola    ", "Palla Machli   ", "Mirch Salan    ", "Katakat        " };
        string[] LarkanaCultures = new string[] { "Jewelry", "Sport", "Films", "Painting", "Films", "Handicraft" };


        public Sindh()
        {
            InitializeComponent();
        }

        private void comboBoxSindh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSindh.Text == "Karachi")
            {
                labelListBoxHeading.Text = "Foods and Cultures of Karachi";
                labelPicBoxHeading.Text = "Famous Places of Karachi";

                for (int i = 0; i < Karachifoods.Length; i++)
                {
                    listBoxSindh.Items.Remove("Dinner: " + (i + 1) + " " + HyderabadFoods[i] + "     " + "Culture: " + (i + 1) + " " + HyderabadCultures[i]);
                    listBoxSindh.Items.Remove("Dinner: " + (i + 1) + " " + LarkanaFoods[i] + "     " + "Culture: " + (i + 1) + " " + LarkanaCultures[i]);
                }

                for (int i = 0; i < Karachifoods.Length; i++)
                {
                    listBoxSindh.Items.Add("Dinner: " + (i + 1) + " " + Karachifoods[i] + "     " + "Culture: " + (i + 1) + " " + Karachicultures[i]);
                }
            }

            if (comboBoxSindh.Text == "Hyderabad")
            {
                labelListBoxHeading.Text = "Foods and Cultures of Hyderabad";
                labelPicBoxHeading.Text = "Famous Places of Hyderabad";

                for (int i = 0; i < Karachifoods.Length; i++)
                {
                    listBoxSindh.Items.Remove("Dinner: " + (i + 1) + " " + Karachifoods[i] + "     " + "Culture: " + (i + 1) + " " + Karachicultures[i]);
                    listBoxSindh.Items.Remove("Dinner: " + (i + 1) + " " + LarkanaFoods[i] + "     " + "Culture: " + (i + 1) + " " + LarkanaCultures[i]);
                }

                for (int i = 0; i < Karachifoods.Length; i++)
                {
                    listBoxSindh.Items.Add("Dinner: " + (i + 1) + " " + HyderabadFoods[i] + "     " + "Culture: " + (i + 1) + " " + HyderabadCultures[i]);
                }
            }

            if (comboBoxSindh.Text == "Larkana")
            {
                labelListBoxHeading.Text = "Foods and Cultures of Larkana";
                labelPicBoxHeading.Text = "Famous Places of Larkana";

                for (int i = 0; i < Karachifoods.Length; i++)
                {
                    listBoxSindh.Items.Remove("Dinner: " + (i + 1) + " " + Karachifoods[i] + "     " + "Culture: " + (i + 1) + " " + Karachicultures[i]);
                    listBoxSindh.Items.Remove("Dinner: " + (i + 1) + " " + HyderabadFoods[i] + "     " + "Culture: " + (i + 1) + " " + HyderabadCultures[i]);
                }

                for (int i = 0; i < Karachifoods.Length; i++)
                {
                    listBoxSindh.Items.Add("Dinner: " + (i + 1) + " " + LarkanaFoods[i] + "     " + "Culture: " + (i + 1) + " " + LarkanaCultures[i]);
                }
            }
        }

        int IndexOfImage = 0;
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (comboBoxSindh.Text == "Karachi")
            {
                if (IndexOfImage < 5)
                {
                    pictureBoxSindh.Image = imageListKarachi.Images[IndexOfImage];
                    pictureBoxSindh.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImage++;
                }
            }

            if (comboBoxSindh.Text == "Hyderabad")
            {
                if (IndexOfImage < 5)
                {
                    pictureBoxSindh.Image = imageListHyderabad.Images[IndexOfImage];
                    pictureBoxSindh.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImage++;
                }
            }

            if (comboBoxSindh.Text == "Larkana")
            {
                if (IndexOfImage < 5)
                {
                    pictureBoxSindh.Image = imageListLarkana.Images[IndexOfImage];
                    pictureBoxSindh.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImage++;

                }
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (comboBoxSindh.Text == "Karachi")
            {

                if (IndexOfImage > 0)
                {
                    IndexOfImage--;
                }
                pictureBoxSindh.Image = imageListKarachi.Images[IndexOfImage];
                pictureBoxSindh.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxSindh.Text == "Hyderabad")
            {

                if (IndexOfImage > 0)
                {
                    IndexOfImage--;
                }
                pictureBoxSindh.Image = imageListHyderabad.Images[IndexOfImage];
                pictureBoxSindh.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxSindh.Text == "Larkana")
            {
                if (IndexOfImage > 0)
                {
                    IndexOfImage--;
                }
                pictureBoxSindh.Image = imageListLarkana.Images[IndexOfImage];
                pictureBoxSindh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
