using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            CSVProcessor fileReader = new CSVProcessor();
            WineItemCollection collection = new WineItemCollection();
            WineItem wine = new WineItem();

            int choice = ui.GetUserInput();
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    ui.Pause();
                    break;
                default:
                    Console.WriteLine("Invalid Selection, Please choose from the menu below:");
                    Console.WriteLine();
                    choice = ui.GetUserInput();
                    break;
            }
        }
    }
}
