using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPClient.Models
{
    public class Todos
    {
        private string userID {  get; set; }
        private string id { get; set; }
        private string title { get; set; }
        private string completed { get; set; }
    }
}
