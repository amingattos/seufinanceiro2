using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Balance : DTO_TypeBalance
    {
        public int Id_Balance { get; set; }
        public int Id_Type_Balance { get; set; }
        public int Id_Wallet_Balance { get; set; }
        public double Value_Balance { get; set; }
        public DateTime Date_Balance { get; set; }
    }
}
