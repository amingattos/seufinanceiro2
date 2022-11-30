using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    public class DTO_Wallet : DTO_Balance
    {
        public int Id_wallet { get; set; }
        public int Id_usr_wallet { get; set; }
        public string Name_wallet { get; set; }
        public decimal Account_Balance_Wallet { get; set; }
    }
}
