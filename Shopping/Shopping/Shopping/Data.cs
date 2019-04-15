using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Shopping
{
    public class Product
    {
        public int ID_List { get; set; }
        public int ID_Product { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public bool IsVisible { get; set; }
        public bool IsSelected { get; set; }

        public Product(int ID_List, int ID_Product, string Name, string Quantity, bool IsVisible, bool IsSelected)
        {
            this.ID_List = ID_List;
            this.ID_Product = ID_Product;
            this.Name = Name;
            this.Quantity = Quantity;
            this.IsVisible = IsVisible;
            this.IsSelected = IsSelected;
        }
    }


    public class List
    {
        public int ID_List { get; set; }
        public string Name_List { get; set; }

        public List(int ID_List, string Name_List)
        {
            this.ID_List = ID_List;
            this.Name_List = Name_List;
        }
    }

    public class Data_Listy
    {
        public static ObservableCollection<List> ListOfList = new ObservableCollection<List>
        {
            new List(1,"Lista pierwsza"),
            new List(2,"Lista druga"),
        };
    }

    public class Data
    {
        public static ObservableCollection<Product> ProductList = new ObservableCollection<Product>
        {
            new Product (1,1,"Masło","20g",true,true),
            new Product (1,2,"Kurwy z roxy","200ml",true,false),
            new Product (2,3,"Mąka","2kg",true,true)
        };
    }


}
