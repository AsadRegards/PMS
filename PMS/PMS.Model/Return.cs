using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.PMS.Model
{
    public class Return
    {
        public int Id { get; set; }
        public List<SaleItem> ReturnItems { get; set; }
        public int OrderId { get; set; }    
    }
}
