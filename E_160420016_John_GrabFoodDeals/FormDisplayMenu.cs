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
    public partial class FormDisplayMenu : Form
    {
        FormMenu formMenu;

        public FormDisplayMenu()
        {
            InitializeComponent();
        }

        private void FormDisplayMenu_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            comboBoxRestaurantName.Items.Clear();
            comboBoxRestaurantName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRestaurantName.DataSource = formMenu.listOfRestaurants;
            comboBoxRestaurantName.DisplayMember = "RestaurantName";
        }

        private void comboBoxRestaurantName_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            JohnRestaurant selectedRestaurant = (JohnRestaurant)comboBoxRestaurantName.SelectedItem;
            string restaurantAndMenu = selectedRestaurant.DisplayDataRestaurant() + selectedRestaurant.DisplayDataListMenu();
            listBoxData.Items.AddRange(restaurantAndMenu.Split('\n'));
        }
    }
}
