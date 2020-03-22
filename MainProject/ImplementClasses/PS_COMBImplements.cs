using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MainProject.Classes;
using MainProject.Interfaces;
using Maticsoft.Model;

namespace MainProject.InplementClasses
{
    class PsCombImplements:SplitTableInterface
    {
        private string _chrOrAux;
        private Maticsoft.Model.cjplp _cjplpModel;

        public PsCombImplements(string chroraux, Maticsoft.Model.cjplp cjplpModel)
        {
            this._chrOrAux = chroraux;
            this._cjplpModel = cjplpModel;
        }

        /// <summary>
        /// 拆分PS_COM表
        /// </summary>
        public void SplitTable()
        {
            Maticsoft.Model.ps_comb psCombModel=new Maticsoft.Model.ps_comb();
            Maticsoft.Model.ps_comb resultPsComb = EntityAssignValue.BindModelValue<Maticsoft.Model.ps_comb, Maticsoft.Model.cjplp>(psCombModel,_cjplpModel);
            Console.WriteLine("哈哈哈" + resultPsComb);

            //todo:补充添加固定信息
            resultPsComb.Prj_Name = ConfiguInfo.Prj_Name;
            resultPsComb.Prj_No = ConfiguInfo.Prj_No;
            //todo：缺失信息忽略

            //增加数据库记录
            Maticsoft.DAL.ps_comb psCombDAL = new Maticsoft.DAL.ps_comb();
        
            bool exist = psCombDAL.Exists(resultPsComb.Exp_No);
            if (!exist)
            {
                psCombDAL.Add(resultPsComb);
            }
            else
            {
                //todo:2重复的数据，返回给用户
            }

        }

 
    }
}
