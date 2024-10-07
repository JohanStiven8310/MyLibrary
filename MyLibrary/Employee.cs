using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GetInt()

        {
         return 5;
        }

            public virtual decimal CalculateMonthlyPayment()
        {
            return 12000;
        }

    
      
            
            
    }
}
