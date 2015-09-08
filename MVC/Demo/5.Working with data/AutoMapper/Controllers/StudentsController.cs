using System.Linq;
using System.Web.Mvc;
using AutoMapper.Models;
using AutoMapper;
using AutoMapper.ViewModels;
using DataValidation.Models;

namespace AutoMapper.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var student = this.db.Students.FirstOrDefault();
            Mapper.CreateMap<Student, StudentViewModel>();

            var viewModel = Mapper.Map<StudentViewModel>(student);
            return this.View(viewModel);
        }
    }
}