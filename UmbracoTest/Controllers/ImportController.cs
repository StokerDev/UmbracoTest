using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoTest.Controllers
{
    public class ImportController : SurfaceController
    {
        [HttpPost][ValidateInput(false)]
        public async Task<JsonResult> ReadXMLFile(string xmlFile)
        {
            // Execute a function from the 'ImportService'...
            return Json("File uploaded successfully!");
        }
    }
}