
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach { Id = 1, Title ="toi thay hoa vang tren co xanh", AuthorName = "NNAnh", Price = 1,
                Content ="truyen ke ve tuoi tho" },
            new Sach { Id = 2, Title ="Pro ASP.net MVC 5 ", AuthorName = "AdamFreeman", Price = 3.75M,
                Content ="The ASP.net MVC 5 Framework is the latest evolution of Microsoft's ASP.net web platform" },
        };
        public  IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p)=>p.Id==id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
