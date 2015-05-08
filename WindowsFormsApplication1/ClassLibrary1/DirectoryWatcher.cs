using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Domain
{
    class DirectoryWatcher
    {
        static FileSystemWatcher watcher;

        public DirectoryWatcher()
        {
            // Establish the path to the directory to watch.
            watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"C:\MyFolder";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // Set up the things to be on the lookout for.
            watcher.NotifyFilter = NotifyFilters.LastAccess
              | NotifyFilters.LastWrite
              | NotifyFilters.FileName
              | NotifyFilters.Size
              | NotifyFilters.DirectoryName;

            // Only watch text files.
            watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);

            // Begin watching the directory.
            watcher.EnableRaisingEvents = true;
        }

        static void OnChanged(object source, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            //Read the file that has been changed
            if (e.Name == "Cars.txt")
            {
                using (StreamReader sr = File.OpenText(e.FullPath))
                {
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        string[] values = input.Split(';');
                        Cardealer.getInstance().registerVehicle(values[0], values[1], values[2], double.Parse(values[3]));
                    }
                }
            }
            else if (e.Name == "PrivateCustomers.txt")
            {
                using (StreamReader sr = File.OpenText(e.FullPath))
                {
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        string[] values = input.Split(';');
                        Cardealer.getInstance().registerPrivateCustomer(values[0], int.Parse(values[1]), values[2], DateTime.Parse(values[3]), values[4], bool.Parse(values[5]));
                    }
                }
            }
            else if (e.Name == "BusinessCustomers.txt")
            {
                using (StreamReader sr = File.OpenText(e.FullPath))
                {
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        string[] values = input.Split(';');
                        Cardealer.getInstance().registerBusinessCustomer(values[0], int.Parse(values[1]), int.Parse(values[2]), values[3], int.Parse(values[4]), values[5], bool.Parse(values[6]));
                    }
                }
            }
            watcher.EnableRaisingEvents = true;
        }
    }
}
