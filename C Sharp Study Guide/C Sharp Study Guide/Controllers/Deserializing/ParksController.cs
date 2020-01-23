using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using C_Sharp_Study_Guide.Models;
using System.Net.Http;
using Newtonsoft.Json;
using C_Sharp_Study_Guide.Models.JsonApiCalls;

namespace C_Sharp_Study_Guide.Controllers.Deserializing
{
    public class ParksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public async Task RunBasicParkJson()
        {
            string parkKey = ApiKeys.NpsKey; // Getting api key from my ApiKeys class on my root folder. Added to gitignore file so it's not exposed to other users
            int apiLimit = 150; // An optional parameter in the NPS API call, setting my maximum outcomes to 150
            string url = $"https://developer.nps.gov/api/v1/parks?q=National%20Park&limit={apiLimit}&api_key={parkKey}"; // Actual REST API call from NPS. Extra "National Park" string query to refine results; API key and limit replaced by above variables

            // Allows sending and recieving URL calls to API -- Initializing new instance
            HttpClient client = new HttpClient(); // Don't forget to add using directive at the top ^^ using System.Net.Http;

            // Gets HTTP response and status, uses new instantiated client to send a GET request from above URL
            HttpResponseMessage response = await client.GetAsync(url); // Above using statement takes care of this one as well
            string jsonresult = await response.Content.ReadAsStringAsync();
            Park park = new Park(); // Instantiate a new park
            if (response.IsSuccessStatusCode)
            {
                // Run through entire JSON file
                NpsJsonInfo npsJsonInfo = JsonConvert.DeserializeObject<NpsJsonInfo>(jsonresult); // Add using C_Sharp_Study_Guide.Models.JsonApiCalls; to connect with postman class from API
                var parkList = npsJsonInfo.data.Select(m => m).ToList(); // returns entire list of Parks, up to 150, this only has 90 based of the National Parks query
                await db.SaveChangesAsync();
            }
        }

        // ======================== Pre-Made Methods from scaffolding ============================================


        // GET: Parks
        public async Task<ActionResult> Index()
        {
            return View(await db.Parks.ToListAsync());
        }

        // GET: Parks/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Park park = await db.Parks.FindAsync(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }

        // GET: Parks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ParkId,ParkName,ParkState,ParkLat,ParkLng,ParkDescription,ParkCode")] Park park)
        {
            if (ModelState.IsValid)
            {
                db.Parks.Add(park);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(park);
        }

        // GET: Parks/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Park park = await db.Parks.FindAsync(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }

        // POST: Parks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ParkId,ParkName,ParkState,ParkLat,ParkLng,ParkDescription,ParkCode")] Park park)
        {
            if (ModelState.IsValid)
            {
                db.Entry(park).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(park);
        }

        // GET: Parks/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Park park = await db.Parks.FindAsync(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }

        // POST: Parks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Park park = await db.Parks.FindAsync(id);
            db.Parks.Remove(park);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
