using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ISchool.Models;
using ISchool.Interface;
using ISchool.Repositories;

namespace ISchool.Controllers
{
    public class iSinhvienController : ApiController
    {
        static readonly ISinhvienRepository repository = new SinhvienRepository();

        public IEnumerable GetAllSinhViens()
        {
            return repository.GetAll();
        }

        public SINHVIEN PostSinhvien(SINHVIEN item)
        {
            return repository.Add(item);
        }

        public IEnumerable PutSinhVien(int mssv, SINHVIEN sinhvien)
        {
            sinhvien.MSSV = mssv;
            if (repository.Update(sinhvien))
            {
                return repository.GetAll();
            }
            else
            {
                return null;
            }
        }

        public bool DeleteSinhVien(int mssv)
        {
            if (repository.Delete(mssv))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
