using System;

namespace RecrangleApplication
{
    class Program
    {
        
        static void Main(string[] args = null)
        {
            String length, width;
            Console.WriteLine("Welcome to my Program.\n\n");
            Console.WriteLine("Please Enter Rectangle Length\n");
            length = Console.ReadLine();
            Console.WriteLine("Please Enter Rectangle Width\n");
            width = Console.ReadLine();
            int l = Int16.Parse(length);
            int w = Int16.Parse(width);
            if (l <= 0 || w <= 0)
            {
                Console.WriteLine("Length should  not be decimal and must start from 1\n\n");
                Program.Main(null);
            }
            else
            {
                Menu menu = new Menu();
                menu.GetMenu();


            }
        }
    }
    public class Menu
    {

        Rectangle rectangle = new Rectangle();
        String option;
        public void GetMenu()
        {
            Console.WriteLine("1. Get Rectangle Length\n");
            Console.WriteLine("2. Change Rectangle Length\n");
            Console.WriteLine("3. Get Rectangle Width\n");
            Console.WriteLine("4. Change Rectangle Width\n");
            Console.WriteLine("5. Get Rectangle Perimeter \n");
            Console.WriteLine("6. Get Rectangle Area\n");
            Console.WriteLine("7. Exit\n");
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Default Rectangle Length is " + rectangle.GetLength().ToString());

            }
            else if (option == "2")

            {
                Console.WriteLine("Enter New Length\n");
                String newLength = Console.ReadLine();
                int data = Int16.Parse(newLength);
                Console.WriteLine("New Rectangle Length is " + rectangle.SetLength(data).ToString());

            }
            else if (option == "3")
            {
                Console.WriteLine("Default Rectangle Width is " + rectangle.GetWidth().ToString());

            }
            else if (option == "4")
            {
                Console.WriteLine("Enter New Width\n");
                String newLength = Console.ReadLine();
                int data = Int16.Parse(newLength);
                Console.WriteLine("New Rectangle width is " + rectangle.SetWidth(data).ToString());

            }
            else if (option == "5")
            {
                Console.WriteLine("Default Rectangle Perimeter is " + rectangle.GetPerimeter().ToString());

            }
            else if (option == "6")
            {
                Console.WriteLine("Default Rectangle Area is " + rectangle.GetArea().ToString());

            }
            else if (option == "7")
            {
                Environment.Exit(-1);


            }
            else
            {
                Console.WriteLine("Invalid Option Please try Again \n\n");
                Menu menu = new Menu();
                menu.GetMenu();
              
            }



        }
    }
   

}
