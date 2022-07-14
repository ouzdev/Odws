using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odws.Api.Application.Parameters
{
    public class RequsetParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        
        public RequsetParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
