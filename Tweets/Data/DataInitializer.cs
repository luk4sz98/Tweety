using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tweets.Models;

namespace Tweets.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _context;

        public DataInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {

            if (_context.Database.CanConnect())
            {
                if(!_context.Smartphones.Any())
                {
                    List<Smartphone> smartphonesToDataBase = GetSmartphones();


                    smartphonesToDataBase.ForEach(s =>
                           {
                               Smartphone smartphone = new Smartphone()
                               {
                                   DeviceName = s.DeviceName,
                                   Performance = s.Performance,
                                   HardwareDescription = s.HardwareDescription,
                                   ScreenSize = s.ScreenSize,
                                   Popularity = s.Popularity
                               };
                               _context.Smartphones.Add(smartphone);
                               _context.SaveChanges();
                           });
                }
              
            }
        }

        private List<Smartphone> GetSmartphones()
        {
            StreamReader streamReader = new StreamReader("JSON/data.json");
            string data = streamReader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Smartphone>>(data);
        }
    }
}
