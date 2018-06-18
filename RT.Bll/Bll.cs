using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RT.Bll
{
    public class Bll<T>:IBll.IBll<T> where T :class
    {
        protected Model.StockOnlineEntities DbContext { set; get; }

        public Bll()
        {
            this.DbContext = System.Runtime.Remoting.Messaging.CallContext.GetData("__@@dbcontext") as Model.StockOnlineEntities;
            if (this.DbContext == null)
            {
                this.DbContext = new Model.StockOnlineEntities(true);
                System.Runtime.Remoting.Messaging.CallContext.SetData("__@@dbcontext", this.DbContext);
            }
        }

        public List<S> GetEntity<S>(Expression<Func<T, S>> selector)
        {
            var lst= this.DbContext.Set<T>().Select(selector).ToList();
            
            return lst;

        }


        public List<S> GetEntity<S>(Expression<Func<T, S>> selector, Expression<Func<T, bool>> predicate)
        {
            return this.DbContext.Set<T>().Where(predicate).Select(selector).ToList();
        }

        public int EditById<S>(System.Linq.Expressions.Expression<Func<T, S>> selector,bool iscommit,  params T[] target)
        {
            var lstColName= this.ResolveColName(selector.Body);
            foreach (var obj in target)
            {
                var objwrapper= this.DbContext.Entry(obj);
                objwrapper.State = System.Data.Entity.EntityState.Unchanged;
                lstColName.ForEach(x=>objwrapper.Property(x).IsModified=true);
            }
            if (iscommit)
                return this.DbContext.SaveChanges();
            return 0;

        }

        public List<string> ResolveColName(System.Linq.Expressions.Expression exp)
        {
            var mexp= exp as System.Linq.Expressions.MemberExpression;
            if (mexp != null)
                return new List<string>() { mexp.Member.Name};
            var nexp=exp as System.Linq.Expressions.NewExpression;
            if (nexp != null)
                return nexp.Members.Select(x => x.Name).ToList();
            throw new ArgumentException("必须是x=>x.Id 或 x=>new{x.Id,x.Name}这两种形式");
        }
    }
}
