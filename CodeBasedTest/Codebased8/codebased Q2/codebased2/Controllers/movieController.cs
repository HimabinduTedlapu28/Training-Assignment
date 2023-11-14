using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codebased2.Models;
using codebased2.Models.repository;

namespace codebased2.Controllers
{
    public class movieController : Controller
    {
        irepository<movie> _repository = null;
        public movieController()
        {
            _repository = new repository<movie>();
        }
        // GET: movie
        public ActionResult Index()
        {
            var movie= _repository.GetAll();
            return View(movie);
        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(movie);
                _repository.save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
        }
        public ActionResult edit(int mid)
        {
            var movie = _repository.GetBydateofrelease(Id);
            return View(movie);

        }
        [HttpPost]
        public ActionResult edit(movie)
        {
            
                if (ModelState.IsValid)
                {
                    _repository.update(m);
                    _repository.save();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(p);
                }
            

        }
        public ActionResult Details(int mid)
        {
            var movie= _repository.GetBydateofrelease(mid);
            return View(movie);
        }
        public ActionResult Delete(int mid)
        {
            var product = _repository.GetBydateofrelease(mid);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int mid)
        {
            var product = _repository.GetBydateofrelease(mid);
            _repository.Delete(mid);
            _repository.save();
            return RedirectToAction("Index");
        }
    }
}