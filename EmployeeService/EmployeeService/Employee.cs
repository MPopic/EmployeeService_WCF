using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    [DataContract]
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;

        [DataMember(Name ="ID",Order = 1)]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Order = 2)]
        public string Name { get => _name; set => _name = value; }

        [DataMember(Order = 3)]
        public string Gender { get => _gender; set => _gender = value; }

        [DataMember(Order = 4)]
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
    }
}
