using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_01_71420058
{
    public abstract class Product_714230058
    {
        private string myType;
        private string myTitle;
        public Product_714230058()
        {
            
        }
        //Constructor
        public Product_714230058(string type, string title)
        {
            myType = type;
            myTitle = title;
        }
        // Properti untuk MyType
        public string MyType {
            get { return myType; }
            set { myType = value; }
        }
        // Properti untuk MyTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }
        //Metode abstract untuk menampilkan informasi produk
        public abstract void DisplayInfo();
    }
}
