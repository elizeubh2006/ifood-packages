using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts.Merchant
{
    public interface IStatusByOperation
    {
        string Operation { get; set; }
        string SalesChannel { get; set; }
        bool Available { get; set; }
        string State { get; set; }
        IReopenable Reopenable { get; set; }
        List<IValidation> Validations { get; set; }
        IMessage Message { get; set; }
    }
}
