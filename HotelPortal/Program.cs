using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel;
using HotelService;

namespace HotelPortal
{
    public class Program
    {
        static void Main(string[] args)
        {
            HotelServices hotelService = new HotelServices();
            HotelModel hotel = hotelService.readitemlist();

            hotelService.printItemsList(hotel);

        }
    }
}
