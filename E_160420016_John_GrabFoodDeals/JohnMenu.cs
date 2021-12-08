using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_GrabFoodDeals
{
    public class JohnMenu
    {
        #region DATA FIELDS
        private string menuId;
        private string menuName;
        private string menuType;
        private string menuDescription;
        private double menuPrice;
        #endregion

        #region CONSTRUCTORS
        public JohnMenu(string menuId, string menuName, string menuType, string menuDescription, double menuPrice)
        {
            this.MenuId = menuId;
            this.MenuName = menuName;
            this.MenuType = menuType;
            this.MenuDescription = menuDescription;
            this.MenuPrice = menuPrice;
        }
        #endregion

        #region PROPERTIES
        public string MenuId
        { 
            get => menuId;
            set
            {
                if (value.Length == 3)
                {
                    menuId = value;
                }
                else
                {
                    throw new ArgumentException("Menu ID must be 3 characters long.");
                }
            }
        }
        public string MenuName
        {
            get => menuName;
            set
            {
                if (value.Length > 0)
                {
                    menuName = value;
                }
                else
                {
                    throw new ArgumentException("Menu Name cannot be empty.");
                }
            }
        }
        public string MenuType
        {
            get => menuType;
            set
            {
                if (value.Length > 0)
                {
                    menuType = value;
                }
                else
                {
                    throw new ArgumentException("Menu Type cannot be empty.");
                }
            }
        }
        public string MenuDescription
        {
            get => menuDescription;
            set
            {
                if (value.Length > 0)
                {
                    menuDescription = value;
                }
                else
                {
                    throw new ArgumentException("Menu Description cannot be empty.");
                }
            }
        }
        public double MenuPrice
        {
            get => menuPrice;
            set
            {
                if (value >= 0)
                {
                    menuPrice = value;
                }
                else
                {
                    throw new ArgumentException("Menu Price cannot be negative.");
                }
            }
        }
        #endregion

        #region METHODS
        public string DisplayDataMenu()
        {
            return "Menu ID : " + MenuId + "\n"
                    + "Menu Name : " + MenuName + "\n"
                    + "Menu Type : " + MenuType + "\n"
                    + "Menu Description : " + MenuDescription + "\n"
                    + "Menu Price : Rp" + MenuPrice + "\n";
        }
        #endregion
    }
}