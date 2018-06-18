using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.IBll
{
    public interface IBll<T>:Model.IDependency
    {
        List<S> GetEntity<S>(System.Linq.Expressions.Expression<Func<T, S>> selector);
        List<S> GetEntity<S>(System.Linq.Expressions.Expression<Func<T, S>> selector, System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        int EditById<S>(System.Linq.Expressions.Expression<Func<T, S>> selector, bool iscommit, params T[] target);
    }
}
