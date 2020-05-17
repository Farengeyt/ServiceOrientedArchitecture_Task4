using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Task4.Models;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            StudentListServiceReference.GetStudentsGraterThanRequest getStudentsGraterThanRequest = new StudentListServiceReference.GetStudentsGraterThanRequest();
            StudentListServiceReference.MyWebServiceSoapClient myWebServiceSoap = new StudentListServiceReference.MyWebServiceSoapClient();
            var students = myWebServiceSoap.GetStudentsGraterThan(3);
            return View(students);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetGraterThan(string mark)
        {
            try
            {
                mark = mark.Replace('.', ',');
                var markFloat = Convert.ToSingle(mark);
                StudentListServiceReference.MyWebServiceSoapClient myWebServiceSoap = new StudentListServiceReference.MyWebServiceSoapClient();
                var students = myWebServiceSoap.GetStudentsGraterThan(markFloat);
                return View("Result", students);
            }
            catch(FormatException formatEx)
            {
                StudentListServiceReference.Student[] students = new StudentListServiceReference.Student[1];
                students[0] = new StudentListServiceReference.Student();
                students[0].Name = formatEx.Message;
                students[0].AvgMark = 0;
                return View("Result", students);
            }
            
        }

        [HttpPost]
        public ActionResult GetLowerThan(string mark)
        {
            try
            {
                mark = mark.Replace('.', ',');
                var markFloat = Convert.ToSingle(mark);
                StudentListServiceReference.MyWebServiceSoapClient myWebServiceSoap = new StudentListServiceReference.MyWebServiceSoapClient();
                var students = myWebServiceSoap.GetStudentsLowerThan(markFloat);
                return View("Result", students);
            }
            catch (FormatException formatEx)
            {
                StudentListServiceReference.Student[] students = new StudentListServiceReference.Student[1];
                students[0] = new StudentListServiceReference.Student();
                students[0].Name = formatEx.Message;
                students[0].AvgMark = 0;
                return View("Result", students);
            }
        }

        [HttpPost]
        public ActionResult GetInRange(string minMark, string maxMark)
        {
            try
            {
                StudentListServiceReference.MyWebServiceSoapClient myWebServiceSoap = new StudentListServiceReference.MyWebServiceSoapClient();
                minMark = minMark.Replace('.', ',');
                maxMark = maxMark.Replace('.', ',');
                var minMarkFloat = Convert.ToSingle(minMark);
                var maxMarkFloat = Convert.ToSingle(maxMark);
                var students = myWebServiceSoap.GetStudentsInRange(minMarkFloat, maxMarkFloat);
                return View("Result", students);
            }
            catch (FormatException formatEx)
            {
                StudentListServiceReference.Student[] students = new StudentListServiceReference.Student[1];
                students[0] = new StudentListServiceReference.Student();
                students[0].Name = formatEx.Message;
                students[0].AvgMark = 0;
                return View("Result", students);
            }
        }

    }
}