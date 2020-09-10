using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressClass
{
    public class Address
    {
        string houseNo;
        int roadNo;
        string area;
        string city;

        public Address(string houseNo,int roadNo,string area,string city)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.area = area;
            this.city = city;
        }

        public Address():this("",-1,"","")
        {

        }

        public string HouseNo
        {
            get { return this.houseNo; }
            set { this.houseNo = value; }
        }

        public int RoadNo
        {
            get { return this.roadNo; }
            set { this.roadNo = value; }
        }

        public string Ares
        {
            get { return this.area; }
            set { this.area = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public void showAddress()
        {
            Console.WriteLine("House No : " + houseNo);
            Console.WriteLine("Road No : " + roadNo);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("City : " + city);
        }
    }
}
