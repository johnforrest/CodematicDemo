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
    class PS_MANHOLEImplements:SplitTableInterface
    {
        private cjplp _cjplpModel;
        // private string _exp_no;
        private string _code;

        public PS_MANHOLEImplements()
        {

        }
        public PS_MANHOLEImplements(Maticsoft.Model.cjplp cjplpModel, string code)
        {
            this._cjplpModel = cjplpModel;
            // this._exp_no = exp_no;
            this._code = code;
        }
        public void SplitTable()
        {
            Maticsoft.Model.ps_manhole psManholeModel = new Maticsoft.Model.ps_manhole();
            Maticsoft.Model.ps_manhole resultPsManhole = EntityAssignValue.BindModelValue<Maticsoft.Model.ps_manhole, Maticsoft.Model.cjplp>(psManholeModel, _cjplpModel);
            // Console.WriteLine("哈哈哈" + resultPsManhole);
            //todo：填充计算的信息
            // resultPsManhole.Exp_No = _exp_no;
            resultPsManhole.Code = _code;

            //todo:补充添加固定信息
            resultPsManhole.Prj_Name = ConfiguInfo.Prj_Name;
            resultPsManhole.Prj_No = ConfiguInfo.Prj_No;
            //todo：缺失信息忽略

            //增加数据库记录
            Maticsoft.DAL.ps_manhole psManholeDAL = new Maticsoft.DAL.ps_manhole();

            bool exist = psManholeDAL.Exists(resultPsManhole.Exp_No);
            if (!exist)
            {
                psManholeDAL.Add(resultPsManhole);
            }
            else
            {
                //todo:2重复的数据，返回给用户
            }
        }
    }
}
