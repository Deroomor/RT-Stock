using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.Dal
{
    public class Dal
    {
        protected Model.StockOnlineEntities DbContext { set; get; }

        public Dal()
        {
            this.DbContext = System.Runtime.Remoting.Messaging.CallContext.GetData("__@@dbcontext") as Model.StockOnlineEntities;
            if (this.DbContext == null)
                throw new ArgumentException("未找到数据库上下文");
        }
    }
}
