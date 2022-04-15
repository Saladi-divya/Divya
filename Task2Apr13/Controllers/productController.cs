using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_TASK2.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TASK2__13Apr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Productdetails> Get()
        {
            Db1Context pnt = new Db1Context();
            return pnt.Productdetails;
        }

        // GET api/<ProductController>/5
        [HttpGet("{pcode}")]
        public IEnumerable<Productdetails> Get(int pcode)
        {
            Db1Context pnt = new Db1Context();
            var sql = from i in pnt.Productdetails where i.Pcode == pcode select i;
            return sql;
        }
        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Productdetails value)
        {
            Db1Context pnt = new Db1Context();
            pnt.Productdetails.Add(value);
            pnt.SaveChanges();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productdetails value)
        {
            Db1Context pnt = new Db1Context();
            var det = pnt.Productdetails.Find(id);
            if (det != null)
            {
                det.Pname = value.Pname;
                det.Pdesc = value.Pdesc;
                det.Unitprice = value.Unitprice;
                det.Category = value.Category;
                det.StockinHand = value.StockinHand;
                pnt.SaveChanges();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Db1Context pnt = new Db1Context();
            var del = pnt.Productdetails.Find(id);
            pnt.Productdetails.Remove(del);
            pnt.SaveChanges();
        }
    }
}
