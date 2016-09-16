using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    static class CSVProcessor
    {
        //Declare a private variable for the file path
        private static string path = Path.Combine(Environment.CurrentDirectory + "../../../../datafiles/WineList.csv");
        //Declare a public variable for the stream reader.
        public static StreamReader streamReader = null;
         public static bool ImportCSV(WineItem[] wineItems)
        {
            //Start a try to verify the path to the file.
            //Throw an exception if incorrect.
            try
            {
                //Declare a string for each line we will read in.
                string line;
                //Instantiate the stream reader with the file path.
                streamReader = new StreamReader(path);
                //Setup a counter.
                int counter = 0;
                //While loop for processing the data in the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    processLine(line, wineItems, counter);
                    counter++;
                }
                //All the reads are successful, return true.
                return true;
            }
            catch (Exception e)
            {
                //Output the exception and the stack trace.
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                //Return false, reading failed
                return false;
            }
            //Ensuring the stream reader gets closed regardless of try outcome.
            finally
            {
                //Check to make sure the stream was instantiated.
                if (streamReader != null)
                {
                    //Close the reader
                    streamReader.Close();
                }
            }
        }
        //Method for processing each line of text from the CSV file.
        private static void processLine(string line, WineItem[] wineItems, int index)
        {
            //Declare a string array and assigne the spline line to it.
            string[] parts = line.Split(',');
            //Assign the parts to local variables that mean something
            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];
            //Use the variables to create a new Wine Item in the Wine Items array at the index point that was passed in.
            wineItems[index] = new WineItem(id, description, pack);
        }
    }
}
