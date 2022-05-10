using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DateTimeContainerAdapter : IAdapter<DateTimeContainer, DateTimeContainerDTO>
    {
        public DateTimeContainerDTO ConvertToDTO(DateTimeContainer model) => new DateTimeContainerDTO() { DateTime = model.DateTime };

        public DateTimeContainer ConvertToModel(DateTimeContainerDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
