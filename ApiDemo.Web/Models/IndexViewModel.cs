using ApiDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Web.Models
{
    public class IndexViewModel
    {
        public IEnumerable<News> News { get; set; }
    }
}
