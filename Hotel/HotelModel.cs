using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// Class holds that properties of Hotel
    /// </summary>
    public class HotelModel
    {
        public List<string> itemsList { get; set; }
        public int NoOfPlates { get; set; }
        public double TotalPrice { get; set;}
    }
}
