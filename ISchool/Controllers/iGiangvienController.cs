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
    public class iGiangvienController : ApiController
    {
        static readonly IGiangvienRepository repository = new GiangvienRepository();

        public IEnumerable GetAllGiangViens()
        {
            return repository.GetAll();
        }

        public GIANGVIEN PostGiangvien(GIANGVIEN item)
        {
            return repository.Add(item);
        }

        public IEnumerable PutGiangVien(int magv, GIANGVIEN giangvien)
        {
            giangvien.MAGV = magv;
            if (repository.Update(giangvien))
            {
                return repository.GetAll();
            }
            else
            {
                return null;
            }
        }

        public bool DeleteGiangVien(int magv)
        {
            if (repository.Delete(magv))
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
