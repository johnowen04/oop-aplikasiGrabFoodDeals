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
    public partial class FormAddMenu : Form
    {
        FormMenu formMenu;

        public FormAddMenu()
        {
            InitializeComponent();
        }

        private void FormAddMenu_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            comboBoxRestaurantName.Items.Clear();
            comboBoxRestaurantName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRestaurantName.DataSource = formMenu.listOfRestaurants;
            comboBoxRestaurantName.DisplayMember = "RestaurantName";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                JohnRestaurant selectedRestaurant = (JohnRestaurant)comboBoxRestaurantName.SelectedItem;

                string menuId = textBoxMenuId.Text;
                string menuName = textBoxMenuName.Text;
                string menuType = textBoxMenuType.Text;
                string menuDescription = textBoxMenuDescription.Text;
                double menuPrice = (double)numericUpDownPrice.Value;

                JohnMenu johnMenu = new JohnMenu(menuId, menuName, menuType, menuDescription, menuPrice);
                selectedRestaurant.AddMenu(johnMenu);
                listBoxData.Items.AddRange(johnMenu.DisplayDataMenu().Split('\n'));

                textBoxMenuId.Clear();
                textBoxMenuName.Clear();
                textBoxMenuType.Clear();
                textBoxMenuDescription.Clear();
                numericUpDownPrice.Value = 0;
                textBoxMenuId.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
