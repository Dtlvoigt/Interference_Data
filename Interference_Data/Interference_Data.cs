using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Interference_Data
{
    public struct interferenceSet
    {
        public string serial;
        public DateTime timeStamp;
        public string status;

        public interferenceSet(string serial, DateTime timeStamp = default(DateTime), string status = "")
        {
            this.serial = serial;
            this.timeStamp = timeStamp;
            this.status = status;
        }
    }

    class Interference_Data
    {
        //list to hold all interference data sets
        public static List<interferenceSet> interferenceData;

        //loads all folders in Logs folder into string array
        public static string[] loadFiles(string path)
        {
            if (Directory.Exists(path))
                return Directory.GetDirectories(path);
            else
            {
                Console.WriteLine("Folder: {0} not present", path);
                throw new DirectoryNotFoundException();
            }
        }


        static void Main(string[] args)
        {
            try
            {
                //create path to Logs folder
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
                string[] logFolders;

                //load serial number folders into array
                logFolders = loadFiles(path);

                //process each folder in Logs
                foreach (string folder in logFolders)
                {
                    //initialise data set
                    interferenceSet newSet;

                    //set serial

                    //set datetime

                    //set status
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                System.Environment.Exit(0);
            }
            
        }
    }
}
