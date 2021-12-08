using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_160420016_John_GrabFoodDeals
{
    public partial class FormMenu : Form
    {
        public List<JohnPromo> listOfPromos = new List<JohnPromo>();
        public List<JohnRestaurant> listOfRestaurants = new List<JohnRestaurant>();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddRestaurant formAddRestaurant = new FormAddRestaurant();
            formAddRestaurant.Owner = this;
            formAddRestaurant.ShowDialog();
        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMenu formAddMenu = new FormAddMenu();
            formAddMenu.Owner = this;
            formAddMenu.ShowDialog();
        }

        private void addPromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddPromo formAddPromo = new FormAddPromo();
            formAddPromo.Owner = this;
            formAddPromo.ShowDialog();
        }

        private void displayMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayMenu formDisplayMenu = new FormDisplayMenu();
            formDisplayMenu.Owner = this;
            formDisplayMenu.ShowDialog();
        }

        private void displayRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayRestaurant formDisplayRestaurant = new FormDisplayRestaurant();
            formDisplayRestaurant.Owner = this;
            formDisplayRestaurant.ShowDialog();
        }

        private void displayPromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayPromo formDisplayPromo = new FormDisplayPromo();
            formDisplayPromo.Owner = this;
            formDisplayPromo.ShowDialog();
        }
    }
}
