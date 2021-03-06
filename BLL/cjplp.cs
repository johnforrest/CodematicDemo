﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
    /// <summary>
    /// cjplp
    /// </summary>
    public partial class cjplp
    {
        private readonly Maticsoft.DAL.cjplp dal = new Maticsoft.DAL.cjplp();
        public cjplp()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Exp_NoOri)
        {
            return dal.Exists(Exp_NoOri);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.cjplp model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.cjplp model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Exp_NoOri)
        {

            return dal.Delete(Exp_NoOri);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Exp_NoOrilist)
        {
            return dal.DeleteList(Exp_NoOrilist);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.cjplp GetModel(string Exp_NoOri)
        {
            return dal.GetModel(Exp_NoOri);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Maticsoft.Model.cjplp GetModelByCache(string Exp_NoOri)
        {

            string CacheKey = "cjplpModel-" + Exp_NoOri;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Exp_NoOri);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Maticsoft.Model.cjplp)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

     

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.cjplp> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.cjplp> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.cjplp> modelList = new List<Maticsoft.Model.cjplp>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.cjplp model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  yjw扩展的方法
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.cjplp> GetMaxCodeModelList()
        {
            DataSet ds = dal.GetMaxModelList();
            return DataTableToList(ds.Tables[0]);
        }
        ///扩展的方法
        public List<Maticsoft.Model.cjplp> GetFileNames()
        {
            DataSet ds = dal.GetFileName();
            return DataTableToList(ds.Tables[0]);

            // return ds.Tables[0];
        }
        #endregion  ExtensionMethod


    }
}

