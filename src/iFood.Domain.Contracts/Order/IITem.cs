using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IItem
    {
        int Index { get; set; }
        Guid Id { get; set; }
        Guid UniqueId { get; set; }
        string Name { get; set; }
        int Quantity { get; set; }
        string Unit { get; set; }
        double UnitPrice { get; set; }
        double OptionsPrice { get; set; }
        double TotalPrice { get; set; }
        double Price { get; set; }
    }
}
