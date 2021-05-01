using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcDynamicCvWebSite.Models.Entity;

namespace MvcDynamicCvWebSite.Repository
{
    /// <summary>
    /// Tablo adı : Experience
    /// ExperianceRepository , GenericRepository e bağlı bir class haline geldi.
    /// </summary>
    public class ExperianceRepository:GenericRepository<Experience>
    {
        public override void TAdd(Experience p)
        {
            base.TAdd(p);
        }
    }
}