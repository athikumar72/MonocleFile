using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonocleFile
{
  

            public class Products

        {
            private string productNumber;
            private string name; //name of product
            private string category; //category of product
            private string description; //description of product
            private int price; //price of product
            

            public Products(String Productnumber, String Name, String Category, String Description, int Price)

            {
                this.productNumber = Productnumber;
                this.name = Name;
                this.category = Category;
                this.description = Description;
                this.price = Price;

           
            }
            public string GetProductNumber()
            {
                return productNumber;
            }


            public string GetCategory()
            {
                return category;
            }


            public string GetName()
            {
                return name;
            }



            public string GetDescription()
            {
                return description;
            }
        

            public int GetPrice()
            {
                return price;
            }

        


    }
}



    

