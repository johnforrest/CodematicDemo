using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.ImplementClasses;
using MainProject.Interfaces;
using Maticsoft.Model;

namespace MainProject.Factory
{
    public class PointFactory
    {
        private Maticsoft.Model.cjplp _cjplpModel;

        // static Dictionary<string, SplitTableInterface> pointtypeDictionary = new Dictionary<string, SplitTableInterface>();

        public cjplp CjplpModel
        {
            get { return _cjplpModel; }
            set { _cjplpModel = value; }
        }

        static Dictionary<string, SplitTableInterface> pointtypeDictionary =
            new Dictionary<string, SplitTableInterface>();


        static PointFactory()
        {
            //todo:在静态代码区域不能获取到非静态字段
            // pointtypeDictionary.Add("PS_MANHOLE", new PS_MANHOLEImplements(("PS_MANHOLE", _cjplpModel)));
            // pointtypeDictionary.Add("PS_POINT", new PS_MANHOLEImplements(("PS_MANHOLE", _cjplpModel)));
        }

        // public static SplitTableInterface getSplitTable(string tableName, Maticsoft.Model.cjplp cjplpModel)
        public SplitTableInterface getSplitTable(string tableName)
        {
            return pointtypeDictionary[tableName];
        }
    }
}