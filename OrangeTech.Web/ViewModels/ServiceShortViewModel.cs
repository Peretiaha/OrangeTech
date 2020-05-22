using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTech.Web.ViewModels
{
    public class ServiceShortViewModel
    {
        public Guid ServiceId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public byte[] Image { get; set; }
    }
}
