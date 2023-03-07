using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Model
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String FullName => $"{FirstName}  {LastName}";
    }
}
