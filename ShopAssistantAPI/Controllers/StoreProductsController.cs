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
    public class StoreProductsController : ApiController
    {
        private ShopAssistantAPIContext db = new ShopAssistantAPIContext();

        // GET: api/StoreProducts
        public IQueryable<StoreProduct> GetStoreProducts()
        {
            return db.StoreProducts;
        }

        // GET: api/StoreProducts/5
        [ResponseType(typeof(StoreProduct))]
        public async Task<IHttpActionResult> GetStoreProduct(int id)
        {
            StoreProduct storeProduct = await db.StoreProducts.FindAsync(id);
            if (storeProduct == null)
            {
                return NotFound();
            }

            return Ok(storeProduct);
        }

        // PUT: api/StoreProducts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStoreProduct(int id, StoreProduct storeProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != storeProduct.StoreId)
            {
                return BadRequest();
            }

            db.Entry(storeProduct).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreProductExists(id))
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

        // POST: api/StoreProducts
        [ResponseType(typeof(StoreProduct))]
        public async Task<IHttpActionResult> PostStoreProduct(StoreProduct storeProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StoreProducts.Add(storeProduct);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoreProductExists(storeProduct.StoreId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = storeProduct.StoreId }, storeProduct);
        }

        // DELETE: api/StoreProducts/5
        [ResponseType(typeof(StoreProduct))]
        public async Task<IHttpActionResult> DeleteStoreProduct(int id)
        {
            StoreProduct storeProduct = await db.StoreProducts.FindAsync(id);
            if (storeProduct == null)
            {
                return NotFound();
            }

            db.StoreProducts.Remove(storeProduct);
            await db.SaveChangesAsync();

            return Ok(storeProduct);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StoreProductExists(int id)
        {
            return db.StoreProducts.Count(e => e.StoreId == id) > 0;
        }
    }
}