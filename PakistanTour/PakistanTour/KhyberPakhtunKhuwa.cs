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
    public partial class KhyberPakhtunKhuwa : Form
    {
        string[] AbbottabadFoods = new string[] { "Biryani                   ", "Pepperoni Pizza        ", "Quarter Broast          ", "Katakat                   ", "Chicken Malai Boti    ", "Chicken Behari Tikka " };
        string[] AbbottabadCultures = new string[] { "Education", "Shopping", "Cuisine", "Sports", "Television", "Cinema" };

        string[] DeraIsmailKhanFoods = new string[] { "Haleem         ", "Mutton Dalcha  ", "Mirch Salan    ", "Sofiana Biryani", "Boti Kebab     ", "Phirni         " };
        string[] DeraIsmailKhanCultures = new string[] { "Painting", "Handicraft", "Literature", "Jewelry", "Films", "Sport" };

        string[] MansehraFoods = new string[] { "Kadhi Chawal   ", "Seyal Mani     ", "Chaap Chola    ", "Palla Machli   ", "Mirch Salan    ", "Katakat        " };
        string[] MansehraCultures = new string[] { "Jewelry", "Sport", "Films", "Painting", "Films", "Handicraft" };
        public KhyberPakhtunKhuwa()
        {
            InitializeComponent();
        }

        private void comboBoxKPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKPK.Text == "Abbottabad")
            {
                labelListBoxHeadingKPK.Text = "Foods and Cultures of Abbottabad";
                labelPicBoxKPK.Text = "Famous Places of Abbottabad";

                for (int i = 0; i < AbbottabadFoods.Length; i++)
                {
                    listBoxKPK.Items.Remove("Dinner: " + (i + 1) + " " + DeraIsmailKhanFoods[i] + "     " + "Culture: " + (i + 1) + " " + DeraIsmailKhanCultures[i]);
                    listBoxKPK.Items.Remove("Dinner: " + (i + 1) + " " + MansehraFoods[i] + "     " + "Culture: " + (i + 1) + " " + MansehraCultures[i]);
                }

                for (int i = 0; i < AbbottabadFoods.Length; i++)
                {
                    listBoxKPK.Items.Add("Dinner: " + (i + 1) + " " + AbbottabadFoods[i] + "     " + "Culture: " + (i + 1) + " " + AbbottabadCultures[i]);
                }
            }

            if (comboBoxKPK.Text == "Dera Ismail Khan")
            {
                labelListBoxHeadingKPK.Text = "Foods & Cultures of Dera Ismail";
                labelPicBoxKPK.Text = "Famous Places of Dera Ismail";

                for (int i = 0; i < AbbottabadFoods.Length; i++)
                {
                    listBoxKPK.Items.Remove("Dinner: " + (i + 1) + " " + AbbottabadFoods[i] + "     " + "Culture: " + (i + 1) + " " + AbbottabadCultures[i]);
                    listBoxKPK.Items.Remove("Dinner: " + (i + 1) + " " + MansehraFoods[i] + "     " + "Culture: " + (i + 1) + " " + MansehraCultures[i]);
                }

                for (int i = 0; i < AbbottabadFoods.Length; i++)
                {
                    listBoxKPK.Items.Add("Dinner: " + (i + 1) + " " + DeraIsmailKhanFoods[i] + "     " + "Culture: " + (i + 1) + " " + DeraIsmailKhanCultures[i]);
                }
            }

            if (comboBoxKPK.Text == "Mansehra")
            {
                labelListBoxHeadingKPK.Text = "Foods and Cultures of Mansehra";
                labelPicBoxKPK.Text = "Famous Places of Mansehra";

                for (int i = 0; i < AbbottabadFoods.Length; i++)
                {
                    listBoxKPK.Items.Remove("Dinner: " + (i + 1) + " " + AbbottabadFoods[i] + "     " + "Culture: " + (i + 1) + " " + AbbottabadCultures[i]);
                    listBoxKPK.Items.Remove("Dinner: " + (i + 1) + " " + DeraIsmailKhanFoods[i] + "     " + "Culture: " + (i + 1) + " " + DeraIsmailKhanCultures[i]);
                }

                for (int i = 0; i < AbbottabadFoods.Length; i++)
                {
                    listBoxKPK.Items.Add("Dinner: " + (i + 1) + " " + MansehraFoods[i] + "     " + "Culture: " + (i + 1) + " " + MansehraFoods[i]);
                }
            }

        }
        int IndexOfImageKPK = 0;
        private void buttonNextKPK_Click(object sender, EventArgs e)
        {
            if (comboBoxKPK.Text == "Abbottabad")
            {
                if (IndexOfImageKPK < 3)
                {
                    pictureBoxKPK.Image = imageListAbbottabad.Images[IndexOfImageKPK];
                    pictureBoxKPK.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImageKPK++;
                }
            }

            if (comboBoxKPK.Text == "Dera Ismail Khan")
            {
                if (IndexOfImageKPK < 3)
                {
                    pictureBoxKPK.Image = imageListDeraIsmailKhan.Images[IndexOfImageKPK];
                    pictureBoxKPK.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImageKPK++;
                }
            }

            if (comboBoxKPK.Text == "Mansehra")
            {
                if (IndexOfImageKPK < 3)
                {
                    pictureBoxKPK.Image = imageListMansehra.Images[IndexOfImageKPK];
                    pictureBoxKPK.SizeMode = PictureBoxSizeMode.StretchImage;
                    IndexOfImageKPK++;
                }
            }

        }

        private void buttonPreviousKPK_Click(object sender, EventArgs e)
        {
            if (comboBoxKPK.Text == "Abbottabad")
            {
                if (IndexOfImageKPK > 0)
                {
                    IndexOfImageKPK--;
                }
                pictureBoxKPK.Image = imageListAbbottabad.Images[IndexOfImageKPK];
                pictureBoxKPK.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxKPK.Text == "Dera Ismail Khan")
            {
                if (IndexOfImageKPK > 0)
                {
                    IndexOfImageKPK--;
                }
                pictureBoxKPK.Image = imageListDeraIsmailKhan.Images[IndexOfImageKPK];
                pictureBoxKPK.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (comboBoxKPK.Text == "Mansehra")
            {
                if (IndexOfImageKPK > 0)
                {
                    IndexOfImageKPK--;
                }
                pictureBoxKPK.Image = imageListMansehra.Images[IndexOfImageKPK];
                pictureBoxKPK.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
