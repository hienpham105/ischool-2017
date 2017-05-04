using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISchool.Models;
using ISchool.Interface;

namespace ISchool.Repositories
{
    public class SinhvienRepository
    {
        SCHOOLMANAGEMENTEntities db = new SCHOOLMANAGEMENTEntities();

        public IEnumerable<SINHVIEN> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return db.SINHVIENs;
        }

        public SINHVIEN Get(int mssv)
        {
            // TO DO : Code to find a record in database
            return db.SINHVIENs.Find(mssv);
        }

        public SINHVIEN Add(SINHVIEN item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            db.SINHVIENs.Add(item);
            db.SaveChanges();
            return item;
        }
        public bool Update(SINHVIEN item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database
            var sinhvien = db.SINHVIENs.Single(a => a.MSSV == item.MSSV);
            sinhvien.HOSV = item.HOSV;
            sinhvien.TENSV = item.TENSV;
            sinhvien.ANHDAIDIEN = item.ANHDAIDIEN;
            sinhvien.QUEQUAN = item.QUEQUAN;
            sinhvien.NGAYSINHSV = item.NGAYSINHSV;
            sinhvien.CMNDSV = item.CMNDSV;
            sinhvien.DIEM_TBTL = item.DIEM_TBTL;
            sinhvien.SDTSV = item.SDTSV;
            sinhvien.SDT_PHUHUYNH = item.SDT_PHUHUYNH;
            sinhvien.EMAIL = item.EMAIL;
            sinhvien.DIACHI_SV = item.DIACHI_SV;
            sinhvien.DIACHI_THUONGTRU = item.DIACHI_THUONGTRU;
            sinhvien.GIOITINH = item.GIOITINH;
            sinhvien.TRANGTHAISV = item.TRANGTHAISV;
            sinhvien.SaveChanges();
            return true;
        }

        public bool Delete(int mssv)
        {
            // TO DO : Code to remove the records from database
            SINHVIEN sinhvien = db.SINHVIENs.Find(mssv);
            db.SINHVIENs.Remove(sinhvien);
            db.SaveChanges();
            return true;
        }
    }
}