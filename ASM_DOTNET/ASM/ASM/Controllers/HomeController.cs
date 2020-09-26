using ASM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfficeOpenXml;
using System.IO;

namespace ASM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ListMovieOutputModel> Data = new List<ListMovieOutputModel>();
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            string path = System.Web.HttpContext.Current.Server.MapPath("~/Data/DATA.xlsx");
            FileInfo file = new FileInfo(path);
            ExcelPackage pack = new ExcelPackage(file);
            ExcelWorksheet sheet = pack.Workbook.Worksheets["Sheet1"];
            int row = 2;
            int col = 1;
            object data = 0;
            while (data != null)
            {
                ListMovieOutputModel dt = new ListMovieOutputModel();
                data = sheet.Cells[row, col].Value;
                if (data == null)
                    break;
                dt.ID = Convert.ToInt32(sheet.Cells[row, 1].Value.ToString());
                dt.Name = sheet.Cells[row, 2].Value.ToString();
                dt.Des = sheet.Cells[row, 3].Value.ToString();
                dt.ReleaseDate = sheet.Cells[row, 4].Value.ToString();
                dt.Rating = sheet.Cells[row, 5].Value == null ? 0 : Convert.ToInt32(sheet.Cells[row, 5].Value.ToString());
                dt.Image = sheet.Cells[row, 9].Value.ToString();
                dt.Lenght = sheet.Cells[row, 10].Value.ToString() + "min";
                row++;
                Data.Add(dt);
            }
            return View(Data);
        }


    }
}