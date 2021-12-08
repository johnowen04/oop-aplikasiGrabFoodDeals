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
    public partial class FormDisplayRestaurant : Form
    {
        FormMenu formMenu;

        public FormDisplayRestaurant()
        {
            InitializeComponent();
        }

        private void FormDisplayRestaurant_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            listBoxData.Items.Clear();
            foreach(JohnRestaurant johnRestaurant in formMenu.listOfRestaurants)
            {
                string restaurantAndMenu = johnRestaurant.DisplayDataRestaurant() + johnRestaurant.DisplayDataListMenu();
                listBoxData.Items.AddRange(restaurantAndMenu.Split('\n'));
            }
        }
    }
}
