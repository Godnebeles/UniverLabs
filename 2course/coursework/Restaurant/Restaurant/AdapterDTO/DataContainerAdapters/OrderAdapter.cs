using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class OrderAdapter : IAdapter<Order, OrderDTO>
    {
        public OrderDTO ConvertToDTO(Order model)
        {
            throw new NotImplementedException();
        }

        public Order ConvertToModel(OrderDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
