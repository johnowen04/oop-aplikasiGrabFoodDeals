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
    public partial class FormAddRestaurant : Form
    {
        FormMenu formMenu;

        public FormAddRestaurant()
        {
            InitializeComponent();
        }

        private void FormAddRestaurant_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string restaurantId = textBoxRestaurantId.Text;
                string restaurantName = textBoxRestaurantName.Text;
                string restaurantAddress = textBoxRestaurantAddress.Text;

                JohnRestaurant johnRestaurant = new JohnRestaurant(restaurantId, restaurantName, restaurantAddress);
                formMenu.listOfRestaurants.Add(johnRestaurant);

                listBoxData.Items.AddRange(johnRestaurant.DisplayDataRestaurant().Split('\n'));

                textBoxRestaurantId.Clear();
                textBoxRestaurantName.Clear();
                textBoxRestaurantAddress.Clear();
                textBoxRestaurantId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
