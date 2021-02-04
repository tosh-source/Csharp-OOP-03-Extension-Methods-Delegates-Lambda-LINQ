using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClassStudents.Models
{
    public class Students
    {
        private string firstName;
        private string lastName; 
        private int age;
        private string facultyNumber;  //Student faculty number
        private string tel;
        private string email;
        private List<int> mark;              //Student Mark variable is based on Bulgarian assessment system in school (from 2-bad to 6-excellent).
        private int groupNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<int> Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public static void Main()
        {
        }
    }
}
