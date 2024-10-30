using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230058
{
    public abstract class Bp
    {
        private string brand;
        private string model;


    //constructor
    public Bp(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model;}
        set { model = value; }
    }
    public abstract void Start();
    public abstract void Stop();
    public abstract void CheckStatus();
}
}