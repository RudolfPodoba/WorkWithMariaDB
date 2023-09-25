using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DbKniznica
{

    public class Helper
    {
        public void prop<M>(M o, Expression<Func<M, string>> propExpr)
        {
            Type type = typeof(M);
            MemberExpression member = propExpr.Body as MemberExpression;
            PropertyInfo propInfo = member.Member as PropertyInfo;
            var name = propInfo.Name;
            var func = propExpr.Compile();
            var value = func(o);
        }
    }


    public enum eObjectState
    {
        notchanged=0, // default
        updated =1,
        created=2,
        deleted =3
    }


    public class Dal
    {

        public eObjectState objectState { get; set; }  

        protected object IfNull(DateTime? v)
        {
            if (v.HasValue )
            {
                return v.Value;
            }
            else
            {
                return System.DBNull.Value;
            }
        }

        protected object IfNull(int? v)
        {
            if (v.HasValue)
            {
                return v.Value;
            }
            else
            {
                return System.DBNull.Value;
            }
        }

        protected object IfNull(short? v)
        {
            if (v.HasValue)
            {
                return v.Value;
            }
            else
            {
                return System.DBNull.Value;
            }
        }

        protected object IfNull(string v)
        {
            if (v != null  && !string.IsNullOrWhiteSpace(v )  )
            {
                return v ;
            }
            else
            {
                return System.DBNull.Value;
            }
        }

        protected object IfNull(int v)
        {
            if (v > int.MinValue)
            {
                return v;
            }
            else
            {
                return System.DBNull.Value;
            }
        }
    }
}
