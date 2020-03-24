using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Classes;
using MainProject.Interfaces;
using Maticsoft.Model;

namespace MainProject.ImplementClasses
{
    class PS_OUTFALLImplements:SplitTableInterface
    {
        private cjplp _cjplpModel;
        // private string _exp_no;
        private string _code;

        public PS_OUTFALLImplements()
        {

        }
        public PS_OUTFALLImplements( Maticsoft.Model.cjplp cjplpModel, string code)
        {
            // this._exp_no = exp_no;
            this._code = code;
            this._cjplpModel = cjplpModel;
        }
        public void SplitTable()
        {
            Maticsoft.Model.ps_outfall psOutfallModel = new Maticsoft.Model.ps_outfall();
            Maticsoft.Model.ps_outfall resultPsComb = EntityAssignValue.BindModelValue<Maticsoft.Model.ps_outfall, Maticsoft.Model.cjplp>(psOutfallModel, _cjplpModel);
            // Console.WriteLine("哈哈哈" + resultPsComb);
            //todo：填充计算的信息
            // resultPsComb.Exp_No = _exp_no;
            resultPsComb.Code = _code;

            //todo:补充添加固定信息
            resultPsComb.Prj_Name = ConfiguInfo.Prj_Name;
            resultPsComb.Prj_No = ConfiguInfo.Prj_No;
            //todo：缺失信息忽略

            //增加数据库记录
            Maticsoft.DAL.ps_outfall psOutfallDAL = new Maticsoft.DAL.ps_outfall();

            bool exist = psOutfallDAL.Exists(resultPsComb.Exp_No);
            if (!exist)
            {
                psOutfallDAL.Add(resultPsComb);
            }
            else
            {
                //todo:2重复的数据，返回给用户
            }

        }
    }
}
