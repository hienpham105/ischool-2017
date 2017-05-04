using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISchool.Models;
using ISchool.Interface;


namespace ISchool.Repositories
{
    public class GiangvienRepository : IGiangvienRepository
    {
        SCHOOLMANAGEMENTEntities db = new SCHOOLMANAGEMENTEntities();

        public IEnumerable<GIANGVIEN> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return db.GIANGVIENs;
        }

        public GIANGVIEN Get(int magv)
        {
            // TO DO : Code to find a record in database
            return db.GIANGVIENs.Find(magv);
        }

        public GIANGVIEN Add(GIANGVIEN item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            db.GIANGVIENs.Add(item);
            db.SaveChanges();
            return item;
        }
        public bool Update(GIANGVIEN item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database
            var giangvien = db.GIANGVIENs.Single(a => a.MAGV == item.MAGV);
            giangvien.HOGV = item.HOGV;
            giangvien.TENGV = item.TENGV;
            giangvien.ANHDAIDIEN = item.ANHDAIDIEN;
            giangvien.QUEQUAN = item.QUEQUAN;
            giangvien.DIACHI = item.DIACHI;
            giangvien.NGAYSINH = item.NGAYSINH;
            giangvien.SDT = item.SDT;
            giangvien.CMND = item.CMND;
            giangvien.GIOITINH = item.GIOITINH;
            giangvien.EMAIL = item.EMAIL;
            giangvien.MAHV = item.MAHV;
            giangvien.MADV = item.MADV;
            giangvien.MACV = item.MACV;
            giangvien.TRANGTHAIGV = item.TRANGTHAIGV;
            giangvien.MOTA = item.MOTA;

            giangvien.SaveChanges();
            return true;
        }

        public bool Delete(int magv)
        {
            // TO DO : Code to remove the records from database
            GIANGVIEN giangvien = db.GIANGVIENs.Find(magv);
            db.GIANGVIENs.Remove(giangvien);
            db.SaveChanges();
            return true;
        }
    }
}