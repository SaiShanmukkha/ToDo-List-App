using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemApp.Models.ViewModels
{
    public class ExpenseVM
    {
        public Expense Expense { set; get; }

        public IEnumerable<SelectListItem> TypeDropDown { set; get; }
    }
}
