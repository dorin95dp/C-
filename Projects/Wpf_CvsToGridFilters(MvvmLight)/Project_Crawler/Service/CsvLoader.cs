using Microsoft.Win32;
using Project_Crawler.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Crawler.Service
{
    class CsvLoader
    {
        public List<PersonModel> LoadEmployees(string filename)
        {
            {
                var superstring = File.ReadAllText(filename);
                string[] linestring = superstring.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var collector = new List<PersonModel>();

                foreach (var line in linestring.Skip(1))
                {
                    var splitline = line.Split(';');
                    if (splitline.Length > 1)
                    {
                        collector.Add(new PersonModel()
                        {
                            FirstName = splitline[0],
                            LastName = splitline[1],
                            CompanyName = splitline[2],
                            IsSuccessful = true,
                            Email = splitline[3],
                        });
                    }
                }

               return collector;
            }
        }
    }
    
}
