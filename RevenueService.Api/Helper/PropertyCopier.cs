using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueService.Api.Helper
{
    /// <summary>
    /// https://www.pluralsight.com/guides/property-copying-between-two-objects-using-reflection
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TChild"></typeparam>
    public class PropertyCopier<TParent, TChild> where TParent : class where TChild : class
    {
        public static void Copy(TParent parent, TChild child)
        {
            System.Reflection.PropertyInfo[] parentProperties = parent.GetType().GetProperties();
            System.Reflection.PropertyInfo[] childProperties = child.GetType().GetProperties();

            foreach (System.Reflection.PropertyInfo parentProperty in parentProperties)
            {
                foreach (System.Reflection.PropertyInfo childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(child, parentProperty.GetValue(parent));
                        break;
                    }
                }
            }
        }
    }
}
