using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISchool.Models;

namespace ISchool.Interface
{
      
    interface IGiangvienRepository
    {
        IEnumerable<GIANGVIEN> GetAll();
        GIANGVIEN Get(int magv);
        GIANGVIEN Add(GIANGVIEN item);
        bool Update(GIANGVIEN item);
        bool Delete(int magv);
        //Hello hiền đẹp trai 
    }
}