using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ghsaa.Models
{
    public class UserProfileViewModel
    {
        
        
            [DisplayName("First Name")]
            [DataType(DataType.Text)]
            public string FirstName { get; set; }

            [DisplayName("Last Name")]
            [DataType(DataType.Text)]
            public string LastName { get; set; }
        


    }
}