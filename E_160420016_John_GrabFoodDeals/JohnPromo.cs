using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_160420016_John_GrabFoodDeals
{
    public class JohnPromo
    {
        #region DATA FIELDS
        private string promoId;
        private string promoName;
        private DateTime promoValidDate;
        private int promoDiscount;
        private int promoMaximumPrice;
        private List<JohnRestaurant> listOfRestaurants;
        #endregion

        #region CONSTRUCTORS
        public JohnPromo(string promoId, string promoName, DateTime promoValidDate, int promoDiscount, int promoMaximumPrice)
        {
            this.PromoId = promoId;
            this.PromoName = promoName;
            this.PromoValidDate = promoValidDate;
            this.PromoDiscount = promoDiscount;
            this.PromoMaximumPrice = promoMaximumPrice;

            this.ListOfRestaurants = new List<JohnRestaurant>();
        }
        #endregion

        #region PROPERTIES
        public string PromoId
        {
            get => promoId;
            set
            {
                if (value.Length == 6)
                {
                    promoId = value;
                }
                else 
                {
                    throw new ArgumentException("Promo Id must be exactly 6 characters long.");
                }
            }
        }
        public string PromoName
        {
            get => promoName;
            set
            {
                if (value.Length > 0)
                {
                    promoName = value;
                }
                else
                {
                    throw new ArgumentException("Promo Name cannot be empty.");
                }
            } 
        }
        public DateTime PromoValidDate
        {
            get => promoValidDate;
            set
            {
                if (value >= DateTime.Now)
                {
                    promoValidDate = value;
                }
                else
                {
                    throw new ArgumentException("Promo Validation Date cannot be in the past.");
                }
            }
        }
        public int PromoDiscount
        {
            get => promoDiscount;
            set 
            {
                if (value >= 0)
                {
                    if (value <= 100)
                    {
                        promoDiscount = value;
                    }
                    else
                    {
                        throw new ArgumentException("Promo Discount cannot be more than 100%.");
                    }
                }
                else
                {
                    throw new ArgumentException("Promo Discount cannot be negative.");
                }
            }
        }
        public int PromoMaximumPrice
        { 
            get => promoMaximumPrice;
            set
            {
                if (value >= 0)
                {
                    promoMaximumPrice = value;
                }
                else
                {
                    throw new ArgumentException("Promo Maximum Price cannot be negative.");
                }
            }
        }
        public List<JohnRestaurant> ListOfRestaurants { get => listOfRestaurants; set => listOfRestaurants = value; }
        #endregion

        #region METHODS
        public void JoinPromo(JohnRestaurant restaurant)
        {
            ListOfRestaurants.Add(restaurant);
        }
        public string DisplayDataPromo()
        {
            return "Promo ID : " + PromoId + "\n"
                    + "Promo Name : " + PromoName + "\n"
                    + "Promo Valid Date : " + PromoValidDate.ToShortDateString() + "\n"
                    + "Promo Discount : " + PromoDiscount + "%" + "\n"
                    + "Promo Maximum Price : Rp" + PromoMaximumPrice + "\n";
        }
        public string DisplayDataListRestaurant()
        {
            string data =
                "================================================" + "\n"
                + "List of joined restaurants :" + "\n";

            foreach (JohnRestaurant restaurant in listOfRestaurants)
            {
                data += "Restaurant ID : " + restaurant.RestaurantId + "\n"
                    + "Restaurant Name : " + restaurant.RestaurantName + "\n"
                    + "Restaurant Address : " + restaurant.RestaurantAddress + "\n\n";
            }

            data +=
                "================================================";

            return data;
        }
        #endregion
    }
}