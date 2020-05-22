using Microsoft.AspNetCore.Http;
using OrangeTech.Models.Models;
using System;

namespace OrangeTech.Web.ViewModels
{
    public class WorkShortViewModel 
    {
        public Guid WorkId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public byte[] Image { get; set; }
    }
}
