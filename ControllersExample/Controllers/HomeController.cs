using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using ControllersExample.Models;
using System.Net.Cache;

namespace ControllersExample.Controllers
{
   public class HomeController:Controller
    {
        [Route("home")]    // for this URL, extecute the below action method(method1).
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult()
            //{
            //    Content = "Hello from Index",
            //    ContentType = "text/plain"
            //};

                             //OR

            //return Content("Hello from Index", "text/plain");
            return Content("<p> Hello from Index</p>", "text/html");
            
        }

        [Route("person")]   //this is known as attribute routing
        public JsonResult Person()
        {
            Person person=new Person() { Id = Guid.NewGuid(), FirstName="Sameer", LastName = "Singh", Age = 24 };
            //return new JsonResult(person);   //coverting the person object into JSON format.

                        //OR

            return Json(person);
        }


        [Route("static-files")]
        public VirtualFileResult StaticFiles()      //If the file is in the wwwroot folder, then we can use VirtualFileResult.
        {
            //return new VirtualFileResult("/sample.txt", "text/plain");

                          //OR

             return File("/sample.txt", "text/plain");
        }

        [Route("static-files2")]
        public PhysicalFileResult StaticFiles2()        //If the file is not in(outside) the wwwroot folder, then we can use PhysicalFileResult.
        {
            //return new PhysicalFileResult(@"C:\Users\v-samesingh\OneDrive - Microsoft\Desktop\carimg.jpg","image/jpeg");

                                             //OR

            return PhysicalFile(@"C:\Users\v-samesingh\OneDrive - Microsoft\Desktop\carimg.jpg", "image/jpeg");
        }

        [Route("static-files3")]
        public FileContentResult StaticFiles3()         //If we want to return the file content as byte array, then we can use FileContentResult.
        {
            byte[] bytes=System.IO.File.ReadAllBytes(@"C:\Users\v-samesingh\OneDrive - Microsoft\Desktop\carimg.jpg");
            //return new FileContentResult(bytes, "image/jpeg");

                                 //OR

            return File(bytes, "image/jpeg");
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello from Contact";
        }

       

        
    }
}
