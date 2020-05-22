using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Interfaces
{
    public interface IImageService 
    {
        public void DeleteByWorkId(Guid workId);
    }
}
