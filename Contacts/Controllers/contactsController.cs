using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Contacts.Models;
using Contacts.Models.contracts;

namespace Contacts.Controllers
{
    public class contactsController : Controller
    {
        private leadifytestEntities db = new leadifytestEntities();
        private ILogger logger;

        public contactsController(ILogger _logger)
        {
             logger = _logger;
        }

        // GET: contacts
        public ActionResult Index()
        {
            return View(db.contacts.ToList());
        }

        // GET: contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                logger.Error("Get Details: id is null");
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                logger.Error(string.Format("Get Details: contact with id {0} not found", id));
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "contactid,firstname,lastname,cellphone,email")] contact contact)
        {
            if (ModelState.IsValid)
            {
                db.contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET: contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                logger.Error("Edit contact: id is null");
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                logger.Error(string.Format("Edit contact: contact with id {0} not found", id));
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "contactid,firstname,lastname,cellphone,email")] contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                logger.Error("Delete contact: id is null");
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                logger.Error(string.Format("Delete contact: contact with id {0} not found", id));
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contact contact = db.contacts.Find(id);
            db.contacts.Remove(contact);
            db.SaveChanges();
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
