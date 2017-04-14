using System;
using System.Collections.Generic;
using System.Linq;
using LatihanEF.Models;
using LatihanEF2.EDM;

namespace LatihanEF.BF
{
    public class MahasiswaBFC
    {
        public List<MahasiswaModel> RetrieveALL()
        {
            latihanEntities ent = new latihanEntities();
            //MahasiswaModel mhs = new MahasiswaModel();

            List<MahasiswaModel> model = ent.Mahasiswa.Select(i =>
            new MahasiswaModel
            {
                Jurusan = i.Jurusan,
                Nama = i.Nama,
                NIM = i.Nim,
            }).ToList();

            return model;
        }

        public void Save(MahasiswaModel model)
        {
            latihanEntities ent = new latihanEntities();
            Mahasiswa mhs = new Mahasiswa();
            mhs.Jurusan = model.Jurusan;
            mhs.Nama = model.Nama;
            mhs.Nim = model.NIM;
            ent.Mahasiswa.Add(mhs);
            ent.SaveChanges();
        }

        public void Update(MahasiswaModel model)
        {
            latihanEntities ent = new latihanEntities();

            Mahasiswa mhs = ent.Mahasiswa.Find(model.NIM);
            mhs.Jurusan = model.Jurusan;
            mhs.Nama = model.Nama;
            mhs.Nim = model.NIM;

            ent.SaveChanges();
        }

        public void Delete(MahasiswaModel model)
        {
            latihanEntities ent = new latihanEntities();
            Mahasiswa mhs = ent.Mahasiswa.Find(model.NIM);
            ent.Mahasiswa.Remove(mhs);
            ent.SaveChanges();
        }

        public List<MahasiswaModel> RetrieveByNim(string nim)
        {
            latihanEntities ent = new latihanEntities();
            //MahasiswaModel mhs = new MahasiswaModel();

            List<MahasiswaModel> model = ent.Mahasiswa
                .Where(i => i.Nim.Contains(nim))
                .Select(i =>
                          new MahasiswaModel
                          {
                              Jurusan = i.Jurusan,
                              Nama = i.Nama,
                              NIM = i.Nim,
                        }).ToList();

            return model;
        }
    }
}
