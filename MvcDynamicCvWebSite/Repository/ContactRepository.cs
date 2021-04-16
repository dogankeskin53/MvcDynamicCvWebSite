using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcDynamicCvWebSite.Models.Entity;


namespace MvcDynamicCvWebSite.Repository
{
    /// <summary>
    /// Tablo adı : Contact
    /// ContactRepository , GenericRepository e bağlı bir class haline geldi.
    /// </summary>
    public class ContactRepository : GenericRepository<Contact>
    {
    }
}