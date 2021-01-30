using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WindowsForms_Student.Model;
namespace WindowsForms_Student.BLL
{
	/// <summary>
	/// S_Function
	/// </summary>
	public partial class S_Function
	{
		private readonly WindowsForms_Student.DAL.S_Function dal=new WindowsForms_Student.DAL.S_Function();
		public S_Function()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FunctionID)
		{
			return dal.Exists(FunctionID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.S_Function model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WindowsForms_Student.Model.S_Function model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FunctionID)
		{
			
			return dal.Delete(FunctionID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FunctionIDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(FunctionIDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WindowsForms_Student.Model.S_Function GetModel(string FunctionID)
		{
			
			return dal.GetModel(FunctionID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WindowsForms_Student.Model.S_Function GetModelByCache(string FunctionID)
		{
			
			string CacheKey = "S_FunctionModel-" + FunctionID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FunctionID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WindowsForms_Student.Model.S_Function)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WindowsForms_Student.Model.S_Function> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WindowsForms_Student.Model.S_Function> DataTableToList(DataTable dt)
		{
			List<WindowsForms_Student.Model.S_Function> modelList = new List<WindowsForms_Student.Model.S_Function>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WindowsForms_Student.Model.S_Function model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

