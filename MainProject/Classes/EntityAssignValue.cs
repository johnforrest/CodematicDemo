using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Classes
{
    public static class EntityAssignValue
    {
        /// <summary>
        /// 将实体2的值动态赋值给实体1(名称一样的属性进行赋值)
        /// </summary>
        /// <param name="model1">实体1</param>
        /// <param name="model2">实体2</param>
        /// <returns>赋值后的model1</returns>
        public static T1 BindModelValue<T1, T2>(T1 model1, T2 model2) where T1 : class where T2 : class
        {
            if (model2 != null)
            {
                Type t1temp = model1.GetType();
                Type t2temp = model2.GetType();
                PropertyInfo[] property2 = t2temp.GetProperties();
                //todo:排除主键
                List<string> exclude = new List<string>() { "Id" };
                foreach (PropertyInfo p in property2)
                {
                    if (exclude.Contains(p.Name)) { continue; }
                    t1temp.GetProperty(p.Name)?.SetValue(model1, p.GetValue(model2, null));
                }
                return model1;
            }
            return null;
        }
    }
}
