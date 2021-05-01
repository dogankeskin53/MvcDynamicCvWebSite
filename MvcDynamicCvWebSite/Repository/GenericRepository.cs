using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MvcDynamicCvWebSite.Models.Entity;

namespace MvcDynamicCvWebSite.Repository
{

    public class GenericRepository<T> where T:class,new()
    {
        DbCvEntities db = new DbCvEntities();
        
        public List<T> List() {
            return db.Set<T>().ToList();
        }

        public virtual void TAdd(T p) {
            db.Set<T>().Add(p);


            //0 hiç eklenmedi
            //-1 hata oluştu
            int count = db.SaveChanges();

            if (count == 0)
            {
                //new yeni kayıt
            }
            else
            {
                //update
            }
        }

        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges(); 
        }

        public T Tget(int id) {
            return db.Set<T>().Find();
        }

        public void TUpdate(T p) {
            db.SaveChanges();
        }

        /// <summary>
        /// Linq Expression İşlemi
        /// Where'den gelecek olan şarta göre ilk değer döndürülür.
        /// Genelde where veya filter parametresi verilir.
        /// Sadece 1 değer geri döner
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public T Find(Expression<Func<T, bool>> where)
        { 
            return db.Set<T>().FirstOrDefault(where);
        }
    }



 
}