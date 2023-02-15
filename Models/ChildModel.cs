using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class ChildModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentityNumber { get; set; }

        //static int id = 2001;

        //public ChildModel()
        //{
        //    this.Id = id++;
        //}
        public ChildModel(string name, DateTime dateOfBirth, string identityNumber)
        {
           // Id = id++;
            Name = name;
            DateOfBirth = dateOfBirth;
            IdentityNumber = identityNumber;
        }
    }
}
