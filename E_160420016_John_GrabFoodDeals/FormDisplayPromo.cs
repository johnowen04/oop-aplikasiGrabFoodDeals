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
    public partial class FormDisplayPromo : Form
    {
        FormMenu formMenu;

        public FormDisplayPromo()
        {
            InitializeComponent();
        }

        private void FormDisplayPromo_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            listBoxData.Items.Clear();
            foreach (JohnPromo johnPromo in formMenu.listOfPromos)
            {
                string promoAndRestaurant = johnPromo.DisplayDataPromo() + johnPromo.DisplayDataListRestaurant();
                listBoxData.Items.AddRange(promoAndRestaurant.Split('\n'));
            }
        }
    }
}
