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
    public partial class FormAddPromo : Form
    {
        FormMenu formMenu;
        JohnPromo johnPromo;

        public FormAddPromo()
        {
            InitializeComponent();
        }

        private void FormAddPromo_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            comboBoxRestaurantName.Items.Clear();
            comboBoxRestaurantName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRestaurantName.DataSource = formMenu.listOfRestaurants;
            comboBoxRestaurantName.DisplayMember = "RestaurantName";
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            try
            {
                JohnRestaurant selectedRestaurant = (JohnRestaurant)comboBoxRestaurantName.SelectedItem;

                if (johnPromo == null)
                {
                    johnPromo = CreatePromoObject(textBoxPromoId, textBoxPromoName, dateTimePickerValidDate, numericUpDownDiscount, numericUpDownMaximumPrice);
                }

                johnPromo.JoinPromo(selectedRestaurant);
                listBoxDataRestaurant.Items.AddRange(selectedRestaurant.DisplayDataRestaurant().Split('\n'));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (johnPromo == null)
                {
                    johnPromo = CreatePromoObject(textBoxPromoId, textBoxPromoName, dateTimePickerValidDate, numericUpDownDiscount, numericUpDownMaximumPrice);
                }

                formMenu.listOfPromos.Add(johnPromo);
                listBoxDataRestaurant.Items.Clear();
                string promoAndJoinedRestaurant = johnPromo.DisplayDataPromo() + johnPromo.DisplayDataListRestaurant();
                listBoxDataPromo.Items.AddRange(promoAndJoinedRestaurant.Split('\n'));
                johnPromo = null;

                textBoxPromoId.Clear();
                textBoxPromoName.Clear();
                dateTimePickerValidDate.Value = DateTime.Now;
                numericUpDownDiscount.Value = 0;
                numericUpDownMaximumPrice.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private JohnPromo CreatePromoObject(TextBox textBoxID,
            TextBox textBoxName,
            DateTimePicker dateTimePickerValidDate,
            NumericUpDown numericUpDownDiscount,
            NumericUpDown numericUpDownMaximumPrice)
        {
            string promoId = textBoxID.Text;
            string promoName = textBoxName.Text;
            DateTime promoValidDate = dateTimePickerValidDate.Value;
            int promoDiscount = (int)numericUpDownDiscount.Value;
            int promoMaximumPrice = (int)numericUpDownMaximumPrice.Value;

            return new JohnPromo(promoId, promoName, promoValidDate, promoDiscount, promoMaximumPrice);
        }
    }
}
