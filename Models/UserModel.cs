using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public List<ChildModel> Children { get; set; }

        //static int id = 1001;
        public UserModel(string firstName, string lastName, string identityNumber, DateTime dateOfBirth, string gender, string hmo, List<ChildModel> children)
        {
            //Id = id++;
            FirstName = firstName;
            LastName = lastName;
            IdentityNumber = identityNumber;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            HMO = hmo;
            Children = children;
        }
    }
}
