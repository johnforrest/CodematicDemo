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
    class PS_POINTImplements:SplitTableInterface
    {
        //业主需求的编码
        // private string _exp_no;
        private cjplp _cjplpModel;
        //计算的编码信息
        private string _code;

        public PS_POINTImplements()
        {

        }
        public PS_POINTImplements( Maticsoft.Model.cjplp cjplpModel,string code)
        {
            // this._exp_no = exp_no;
            this._code = code;
            this._cjplpModel = cjplpModel;
        }
        public void SplitTable()
        {
            Maticsoft.Model.ps_point psPointModel = new Maticsoft.Model.ps_point();
            Maticsoft.Model.ps_point resultPsPoint = EntityAssignValue.BindModelValue<Maticsoft.Model.ps_point, Maticsoft.Model.cjplp>(psPointModel, _cjplpModel);
            // Console.WriteLine("哈哈哈" + resultPsPoint);
            //todo：填充计算的信息
            // resultPsPoint.Exp_No = _exp_no;
            resultPsPoint.Code = _code;
            //todo:补充添加固定信息
            resultPsPoint.Prj_Name = ConfiguInfo.Prj_Name;
            resultPsPoint.Prj_No = ConfiguInfo.Prj_No;
            //todo：缺失信息忽略

            //增加数据库记录
            Maticsoft.DAL.ps_point psPointDAL = new Maticsoft.DAL.ps_point();

            bool exist = psPointDAL.Exists(resultPsPoint.Exp_No);
            if (!exist)
            {
                psPointDAL.Add(resultPsPoint);
            }
            else
            {
                //todo:2重复的数据，返回给用户
            }

        }
    }
}
