using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplesDF
{
    public class TestsQueries
    {
        public List<Currency> getCurrencies()
        {
            using (AdventureWorks2012Entities db = new AdventureWorks2012Entities ())
            {
               return  db.Currency.ToList();
            }
        }
    }
}
