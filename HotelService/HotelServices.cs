using System;
using System.Collections.Generic;
using System.Text;
using Hotel;

namespace HotelService
{
    /// <summary>
    /// class holds services of read and print methods 
    /// </summary>
    public class HotelServices
    {
        /// <summary>
        /// Read all details from console screen
        /// </summary>
        /// <returns></returns>
        public HotelModel readitemlist()
        {
            HotelModel hotel = new HotelModel();
            StringBuilder errors = new StringBuilder();

            bool reOrdercondition = false;
            double result = 0;
            int totalPlates = 0;

            Console.WriteLine("\t\t\tHOTEL MANAGEMENT APPICATION\n");
            Console.WriteLine("\t\t***Welcome to Jhon's Sp!cy Re$turant***");
            Console.WriteLine("\n\nFood Items:");
            do
            {
                Console.WriteLine("\n");
                List<string> itemsList = new List<string>();
                itemsList.Add(Constants.Constants.PURI);
                itemsList.Add(Constants.Constants.IDLI);
                itemsList.Add(Constants.Constants.BIRYANI);
                itemsList.Add(Constants.Constants.CHAPATHI);
                itemsList.Add(Constants.Constants.ICE_CREAM);

                Utility.Utility.PrintListValues(itemsList);

                Console.Write("\nWhat would you like to take it? (eg:select 1 for puri):");
                string itemStrValue = Console.ReadLine();
               
                if (!string.IsNullOrEmpty(itemStrValue))
                {                   
                        int itemValue = 0;
                        bool isitemHasValue = int.TryParse(itemStrValue, out itemValue);

                    if (isitemHasValue)
                    {
                        if (itemValue > 0)
                        {
                                Console.Write("How many plates do you want?:(eg:select 1 for one plate):");
                                string noOfPlatesStr = Console.ReadLine();
                            if (!string.IsNullOrEmpty(noOfPlatesStr))
                            {                           

                                int noOfPlates = 0;
                                bool isNoOfPlatesHasValue = int.TryParse(noOfPlatesStr, out noOfPlates);

                                if (isNoOfPlatesHasValue)
                                {
                                    if (noOfPlates > 0)
                                    {
                                        switch (itemValue)
                                        {
                                            case (int)Enums.FoodItems.Puri:
                                                result = result + (noOfPlates * 20);
                                                break;
                                            case (int)Enums.FoodItems.Idli:
                                                result = result + (noOfPlates * 40);
                                                break;
                                            case (int)Enums.FoodItems.Biryani:
                                                result = result + (noOfPlates * 50);
                                                break;
                                            case (int)Enums.FoodItems.Chapathi:
                                                result = result + (noOfPlates * 25);
                                                break;
                                            case (int)Enums.FoodItems.Ice_Cream:
                                                result = result + (noOfPlates * 100);
                                                break;
                                            default:
                                                errors.Append("unknown value has given for Item.");
                                                break;
                                        }
                                        totalPlates = totalPlates + noOfPlates;

                                    }
                                    else
                                        errors.Append("Please provide a integer vaue for no.of plate fields(Ex.1 for one plate).\n");
                                }
                                else
                                    errors.Append("Please provide a integer vaue for no.of plate fields(Ex.1 for one plate).\n");
                            }
                            else
                                errors.Append("no of plates value is missing.\n");                           
                        }
                        else
                            errors.Append("Please provide a integer vaue for item value fields(Ex.1 for one plate).\n");
                    }
                    else
                        errors.Append("Please provide a integer vaue for item value fields(Ex.1 for one plate).\n");
                }
                else
                    errors.Append("Item value value is missing.\n");

                Console.Write("Would you like to taste anything else still?(eg:true/false):");
                string reOrder = Console.ReadLine();
                if (!string.IsNullOrEmpty(reOrder))
                {
                    if (reOrder.ToLower() == "true" || reOrder.ToLower() == "false")
                    {
                        reOrdercondition = Convert.ToBoolean(reOrder);
                        if (reOrdercondition == true)
                        {
                            reOrdercondition = true;
                        }
                        else
                        {
                            reOrdercondition = false;
                        }
                    }
                    else
                        errors.Append("Please provide a value for reOrder(eg:true/false).\n");
                }
                else
                    errors.Append("reOrder value is missing.\n");   
            }
            while (reOrdercondition == true);

            hotel.TotalPrice = result;
            hotel.NoOfPlates = totalPlates;

            if(!string.IsNullOrEmpty(errors.ToString()))
            {
                Console.WriteLine("\nError validations:\n{0}", errors);
            }
            return hotel;
        }
        /// <summary>
        /// Print all details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void printItemsList(HotelModel details)
        {
            Console.Write($"\n\nTotal plates: {details.NoOfPlates} \nTotal Bill: Rs.{details.TotalPrice}/-");
            Console.ReadLine();
        }
    }
}

