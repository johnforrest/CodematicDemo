using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;

namespace MainProject.Classes
{
    public static class ConfiguInfo
    {
        public static string Prj_No = "44030720190143001001";
        public static string Prj_Name = "龙岗区排水系统提质增效排查与评估项目";

        public static Dictionary<string, esriFieldType> TempDictionary = new Dictionary<string, esriFieldType>();

        static ConfiguInfo()
        {
            TempDictionary.Add("Char", esriFieldType.esriFieldTypeString);
            TempDictionary.Add("String", esriFieldType.esriFieldTypeString);

            TempDictionary.Add("Decimal", esriFieldType.esriFieldTypeDouble);
            TempDictionary.Add("Double", esriFieldType.esriFieldTypeDouble);

            TempDictionary.Add("Int16", esriFieldType.esriFieldTypeInteger);
            TempDictionary.Add("Int32", esriFieldType.esriFieldTypeInteger);
            TempDictionary.Add("Int64", esriFieldType.esriFieldTypeInteger);

            TempDictionary.Add("Empty", esriFieldType.esriFieldTypeString);

            TempDictionary.Add("Nullable`1", esriFieldType.esriFieldTypeString);
            Console.WriteLine("字典调用————————————————————————————————————————————————————————");
        }

        public static Dictionary<string, esriFieldType> getArcgisType()
        {
            //todo：写到这里面的话，每次引用该函数都会添加一次字段
            Dictionary<string, esriFieldType> TempDictionary = new Dictionary<string, esriFieldType>();

            TempDictionary.Add("Char", esriFieldType.esriFieldTypeString);
            TempDictionary.Add("String", esriFieldType.esriFieldTypeString);

            TempDictionary.Add("Decimal", esriFieldType.esriFieldTypeDouble);
            TempDictionary.Add("Double", esriFieldType.esriFieldTypeDouble);

            TempDictionary.Add("Int16", esriFieldType.esriFieldTypeInteger);
            TempDictionary.Add("Int32", esriFieldType.esriFieldTypeInteger);
            TempDictionary.Add("Int64", esriFieldType.esriFieldTypeInteger);

            TempDictionary.Add("Empty", esriFieldType.esriFieldTypeString);

            TempDictionary.Add("Nullable`1", esriFieldType.esriFieldTypeString);

            Console.WriteLine("字典调用————————————————————————————————————————————————————————");

            return TempDictionary;
        }
    }
}