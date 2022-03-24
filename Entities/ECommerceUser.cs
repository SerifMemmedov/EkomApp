using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class ECommerceUser:IdentityUser
    {

        public string? FullName { get; set; }
        public string? CustomerAddress { get; set; }
        public int? PictureID { get; set; }
        public virtual Picture Picture { get; set; }
        public DateTime? RegisteredOn { get; set; }
    }
}
