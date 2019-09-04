using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Netcore2._0.Pages
{
    public class IndexModel : PageModel
    {
        public string TestResult { get; private set; } = "  ";
        public void OnGet()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach ( int i in list1)
            {
                if (i % 2 == 0)
                {
                    TestResult += i.ToString();
                }
            }
        }
    }
}
