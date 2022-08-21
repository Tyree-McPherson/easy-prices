using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Api.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string email { get; set; }

        public string password { get; set; }
    }
}
