using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WindowsForms_Student.DAL
{
	/// <summary>
	/// 数据访问类:S_Function
	/// </summary>
	public partial class S_Function
	{
		public S_Function()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FunctionID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from S_Function");
			strSql.Append(" where FunctionID=@FunctionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionID", SqlDbType.VarChar,50)			};
			parameters[0].Value = FunctionID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.S_Function model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into S_Function(");
			strSql.Append("FunctionID,FunctionName)");
			strSql.Append(" values (");
			strSql.Append("@FunctionID,@FunctionName)");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionID", SqlDbType.VarChar,50),
					new SqlParameter("@FunctionName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.FunctionID;
			parameters[1].Value = model.FunctionName;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WindowsForms_Student.Model.S_Function model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update S_Function set ");
			strSql.Append("FunctionName=@FunctionName");
			strSql.Append(" where FunctionID=@FunctionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionName", SqlDbType.VarChar,50),
					new SqlParameter("@FunctionID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.FunctionName;
			parameters[1].Value = model.FunctionID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FunctionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_Function ");
			strSql.Append(" where FunctionID=@FunctionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionID", SqlDbType.VarChar,50)			};
			parameters[0].Value = FunctionID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string FunctionIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_Function ");
			strSql.Append(" where FunctionID in ("+FunctionIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WindowsForms_Student.Model.S_Function GetModel(string FunctionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FunctionID,FunctionName from S_Function ");
			strSql.Append(" where FunctionID=@FunctionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionID", SqlDbType.VarChar,50)			};
			parameters[0].Value = FunctionID;

			WindowsForms_Student.Model.S_Function model=new WindowsForms_Student.Model.S_Function();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WindowsForms_Student.Model.S_Function DataRowToModel(DataRow row)
		{
			WindowsForms_Student.Model.S_Function model=new WindowsForms_Student.Model.S_Function();
			if (row != null)
			{
				if(row["FunctionID"]!=null)
				{
					model.FunctionID=row["FunctionID"].ToString();
				}
				if(row["FunctionName"]!=null)
				{
					model.FunctionName=row["FunctionName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FunctionID,FunctionName ");
			strSql.Append(" FROM S_Function ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" FunctionID,FunctionName ");
			strSql.Append(" FROM S_Function ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM S_Function ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.FunctionID desc");
			}
			strSql.Append(")AS Row, T.*  from S_Function T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "S_Function";
			parameters[1].Value = "FunctionID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

