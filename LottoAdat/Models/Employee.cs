using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoAdat.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tipp> Tips { get; } = new List<Tipp>();

        public Employee()
        {
        } 
        public Employee(string sor)
        {
            Name = sor;
        }


    }
}
