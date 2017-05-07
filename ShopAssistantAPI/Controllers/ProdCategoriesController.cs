using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ShopAssistantAPI.Models;

namespace ShopAssistantAPI.Controllers
{
    public class ProdCategoriesController : ApiController
    {
        private ShopAssistantAPIContext db = new ShopAssistantAPIContext();

        // GET: api/ProdCategories
        public IQueryable<ProdCategory> GetProdCategories()
        {
            return db.ProdCategories;
        }

        // GET: api/ProdCategories/5
        [ResponseType(typeof(ProdCategory))]
        public async Task<IHttpActionResult> GetProdCategory(int id)
        {
            ProdCategory prodCategory = await db.ProdCategories.FindAsync(id);
            if (prodCategory == null)
            {
                return NotFound();
            }

            return Ok(prodCategory);
        }

        // PUT: api/ProdCategories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProdCategory(int id, ProdCategory prodCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prodCategory.Id)
            {
                return BadRequest();
            }

            db.Entry(prodCategory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProdCategories
        [ResponseType(typeof(ProdCategory))]
        public async Task<IHttpActionResult> PostProdCategory(ProdCategory prodCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProdCategories.Add(prodCategory);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = prodCategory.Id }, prodCategory);
        }

        // DELETE: api/ProdCategories/5
        [ResponseType(typeof(ProdCategory))]
        public async Task<IHttpActionResult> DeleteProdCategory(int id)
        {
            ProdCategory prodCategory = await db.ProdCategories.FindAsync(id);
            if (prodCategory == null)
            {
                return NotFound();
            }

            db.ProdCategories.Remove(prodCategory);
            await db.SaveChangesAsync();

            return Ok(prodCategory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProdCategoryExists(int id)
        {
            return db.ProdCategories.Count(e => e.Id == id) > 0;
        }
    }
}