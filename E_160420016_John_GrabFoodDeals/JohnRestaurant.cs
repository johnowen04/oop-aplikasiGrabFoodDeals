using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_GrabFoodDeals
{
    public class JohnRestaurant
    {
        #region DATA FIELDS
        private string restaurantId;
        private string restaurantName;
        private string restaurantAddress;

        private List<JohnMenu> listOfMenu;
        #endregion

        #region CONSTRUCTORS
        public JohnRestaurant(string restaurantId, string restaurantName, string restaurantAddress)
        {
            this.RestaurantId = restaurantId;
            this.RestaurantName = restaurantName;
            this.RestaurantAddress = restaurantAddress;

            this.ListOfMenu = new List<JohnMenu>();
        }
        #endregion

        #region PROPERTIES
        public string RestaurantId
        {
            get => restaurantId;
            set
            {
                if (value.Length == 5)
                {
                    restaurantId = value;
                }
                else
                {
                    throw new ArgumentException("Restaurant ID must be 5 characters long.");
                }
            }
        }
        public string RestaurantName
        {
            get => restaurantName;
            set
            {
                if (value.Length > 0)
                {
                    restaurantName = value;
                }
                else
                {
                    throw new ArgumentException("Restaurant Name cannot be empty.");
                }
            }
        }
        public string RestaurantAddress
        {
            get => restaurantAddress;
            set
            {
                if (value.Length > 0)
                {
                    restaurantAddress = value;
                }
                else
                {
                    throw new ArgumentException("Restaurant Address cannot be empty.");
                }
            }
        }
        public List<JohnMenu> ListOfMenu { get => listOfMenu; set => listOfMenu = value; }
        #endregion

        #region METHODS
        public void AddMenu(JohnMenu menu)
        {
            ListOfMenu.Add(menu);
        }
        public string DisplayDataRestaurant()
        {
            return "Restaurant ID : " + RestaurantId + "\n"
                + "Restaurant Name : " + RestaurantName + "\n"
                + "Restaurant Address : " + RestaurantAddress + "\n";
        }
        public string DisplayDataListMenu()
        {
            string data =
                "================================================" + "\n"
                + "Restaurant's Menu :" + "\n";

            foreach(JohnMenu menu in listOfMenu)
            {
                data += "Menu ID : " + menu.MenuId + "\n"
                    + "Menu Name : " + menu.MenuName + "\n"
                    + "Menu Type : " + menu.MenuType + "\n"
                    + "Menu Description : " + menu.MenuDescription + "\n"
                    + "Menu Price : Rp" + menu.MenuPrice + "\n\n";
            }

            data +=
                "================================================";

            return data;
        }
        #endregion
    }
}