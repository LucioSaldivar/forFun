using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forFun
{
    class Program
    {
        static void Main(string[] args)
        {

            int options = -1;// -1 to allow default.

            do
            {
                Console.WriteLine("Welcome! What would you like to do? 1 - Menu 2 - Employees 3 - Locations");
                options = Convert.ToInt32(Console.ReadLine());// Converts 'options' from string to number.
                switch (options)
                {
                    case 1:
                        Menu(options);
                        break;
                    case 2:
                        Employees(options);
                        break;
                    case 3:
                        Locations(options);
                        break;
                    default:
                        Console.WriteLine("Come on now! Put in a number!");
                        break;

                }//End of switch.
            }
            while (options != 1|| options !=2 || options != 3); // Add do while loop to keep program from stopping.
        }//End of Main Method.

        private static void Menu(int options)
        {
            int catagorys = 0;
            int results = catagorys;
            string[] apps = { "Mac n Chz bites", "Fr.Bacon", "Queso", "Fr. Pickles", "Fr. Shrooms" };
            string[] favorites = { "Meatloaf", "Chicken Fried Steak", "Chicken Fried Chicken", "Tenders", "Veggie Platter" };
            string[] burgers = { "Classic Burger", "Avocado-Burger", "Three Cheese Burger" };

            Console.WriteLine("What would you like to see? 1-Apps, 2 -Favorites, 3 -Burgers");
            catagorys = Convert.ToInt32(Console.ReadLine());

            switch (catagorys)
            {
                case 1: results=1;
                    break;
                case 2: results=2;
                    break;
                case 3: results=3;
                    break;
            }//End of Switch.

            if (results==1)
            {
                Console.WriteLine("Appetizers:");
                for (int a = 0; a < apps.Length; a++)
                {
                    Console.WriteLine(apps[a]);
                }//Allows you to loop through entire array.
                
            }
            if (results == 2)
            {
                Console.WriteLine("Favorites:");
                for (int f = 0; f < favorites.Length; f++)
                {
                    Console.WriteLine(favorites[f]);
                }
            }
            if (results == 3)
            {
                Console.WriteLine("Burgers:");
                for (int b = 0; b < burgers.Length; b++)
                {
                    Console.WriteLine(burgers[b]);
                }
            }
        }//End of Menu Method

        public static  void Employees(int options)
        {
            int position = 0;
            int results = position;
            string[] servers = { "Zach", "Manny", "Rosalinda", "Lauren", "Kenny", "Drake", "Alexis", "Sarah" };
            string[] bartenders = { "Torii", "Olivia", "Alexis", "Shannon"};
            string[] managers = { "Sergio", "Adam", "Andrea", "Shannon"};
            Console.WriteLine("What would you like to see? 1-servers, 2 -bartenders, 3 -managers");
            position = Convert.ToInt32(Console.ReadLine());

            switch (position)
            {
                case 1: results = 1;
                    break;
                case 2: results =2;
                    break;
                case 3: results =3;
                    break;
            }//End of switch

            if (results == 1)
            {
                Console.WriteLine("Servers");
            }
            if (results == 2)
            {
                Console.WriteLine("Bartenders");
            }
            if(results == 3)
            {
                Console.WriteLine("Managers");
            }
        }//End of Employees Method

        private static void Locations(int options)
        {
            int citys = 0;
            int result = citys;
            string[] grapevine = {"4020 William D Tate Ave, Grapevine" };
            string[] downtown = {"129 S Main St Ste 155, Grapevine, TX 76051" };
            string[] arlington = { "420 E. FM 3040, Ste. 100 Lewisville, TX 75067"};
            
            Console.WriteLine("What city would you like to see? 1 -grapevine, 2 -irving, 3 -arlington");
            citys =Convert.ToInt32(Console.ReadLine());

            switch (citys)
            {
                case 1:  result= 1;
                    break;
                case 2: result =2;
                    break;
                case 3: result =3;
                    break;
            }
            
            if (result == 1)
            {
                Console.WriteLine("Grapevine Store");
            }
            if (result == 2)
            {
                Console.WriteLine("DownTown Store");
            }
            if (result == 3)
            {
                Console.WriteLine("Lewisville Store");
            }
        }//End of Locations Method.
    }
}
