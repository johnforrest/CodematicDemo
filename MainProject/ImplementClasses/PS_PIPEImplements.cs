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
    class PS_PIPEImplements:SplitTableInterface
    {
        private cjpll _cjpllModel;
        private string _code;

        public PS_PIPEImplements()
        {

        }
        public PS_PIPEImplements(Maticsoft.Model.cjpll cjpllModel, string code)
        {
            this._cjpllModel = cjpllModel;
            this._code = code;
        }

        public void SplitTable()
        {
            Maticsoft.Model.ps_pipe psPipeModel = new Maticsoft.Model.ps_pipe();
            Maticsoft.Model.ps_pipe resultPsPipe = EntityAssignValue.BindModelValue<Maticsoft.Model.ps_pipe, Maticsoft.Model.cjpll>(psPipeModel, _cjpllModel);
            resultPsPipe.Code = _code;
            //todo:补充添加固定信息
            resultPsPipe.Prj_Name = ConfiguInfo.Prj_Name;
            resultPsPipe.Prj_No = ConfiguInfo.Prj_No;
            //todo：缺失信息忽略

            //增加数据库记录
            Maticsoft.DAL.ps_pipe psPipeDAL = new Maticsoft.DAL.ps_pipe();

            bool exist = psPipeDAL.Exists(resultPsPipe.Lno);
            if (!exist)
            {
                psPipeDAL.Add(resultPsPipe);
            }
            else
            {
                //todo:2重复的数据，返回给用户
            }
        }
    }
}
