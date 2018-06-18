using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.Model
{
    public partial class StockOnlineEntities 
    {
        //static string Cnnstr = DeCoding();

        //static string DeCoding()
        //{
        //    string cnnstr = System.Configuration.ConfigurationManager.ConnectionStrings["StockOnlineEntities"].ConnectionString;
        //    var buffer = System.Convert.FromBase64String(cnnstr);

        //    string st1 = System.Text.Encoding.UTF8.GetString(buffer);

        //    st1 = st1.Substring(3);

        //    buffer = System.Convert.FromBase64String(st1);

        //    string rst = System.Text.Encoding.UTF8.GetString(buffer);
        //    return rst;
        //}

        public StockOnlineEntities(bool deCodeCnnstr)
            : base("name=StockOnlineEntities")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }
    }
}
