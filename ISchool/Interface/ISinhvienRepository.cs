using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISchool.Models;

namespace ISchool.Interface
{
    interface ISinhvienRepository
    {
        IEnumerable<SINHVIEN> GetAll();
        SINHVIEN Get(int mssv);
        SINHVIEN Add(SINHVIEN item);
        bool Update(SINHVIEN item);
        bool Delete(int mssv);
    }
}