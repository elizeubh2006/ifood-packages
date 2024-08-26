using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Order
{
    public interface IAdditionalFee
    {
        string Type { get; set; }
        string Description { get; set; }
        string FullDescription { get; set; }
        double Value { get; set; }
        List<ILiability> Liabilities { get; set; }
    }
}
