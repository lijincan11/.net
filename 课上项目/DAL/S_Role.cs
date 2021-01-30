﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WindowsForms_Student.DAL
{
	/// <summary>
	/// 数据访问类:S_Role
	/// </summary>
	public partial class S_Role
	{
		public S_Role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from S_Role");
			strSql.Append(" where RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50)			};
			parameters[0].Value = RoleID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.S_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into S_Role(");
			strSql.Append("RoleID,RoleName)");
			strSql.Append(" values (");
			strSql.Append("@RoleID,@RoleName)");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@RoleName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.RoleID;
			parameters[1].Value = model.RoleName;

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
		public bool Update(WindowsForms_Student.Model.S_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update S_Role set ");
			strSql.Append("RoleName=@RoleName");
			strSql.Append(" where RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleName", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.RoleName;
			parameters[1].Value = model.RoleID;

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
		public bool Delete(string RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_Role ");
			strSql.Append(" where RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50)			};
			parameters[0].Value = RoleID;

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
		public bool DeleteList(string RoleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from S_Role ");
			strSql.Append(" where RoleID in ("+RoleIDlist + ")  ");
			int rows = 0;
            try
            {
				 rows = DbHelperSQL.ExecuteSql(strSql.ToString());
			}
            catch (Exception)
            {

                throw;
            }
						
           
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
		public WindowsForms_Student.Model.S_Role GetModel(string RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 RoleID,RoleName from S_Role ");
			strSql.Append(" where RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50)			};
			parameters[0].Value = RoleID;

			WindowsForms_Student.Model.S_Role model=new WindowsForms_Student.Model.S_Role();
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
		public WindowsForms_Student.Model.S_Role DataRowToModel(DataRow row)
		{
			WindowsForms_Student.Model.S_Role model=new WindowsForms_Student.Model.S_Role();
			if (row != null)
			{
				if(row["RoleID"]!=null)
				{
					model.RoleID=row["RoleID"].ToString();
				}
				if(row["RoleName"]!=null)
				{
					model.RoleName=row["RoleName"].ToString();
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
			strSql.Append("select RoleID,RoleName ");
			strSql.Append(" FROM S_Role ");
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
			strSql.Append(" RoleID,RoleName ");
			strSql.Append(" FROM S_Role ");
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
			strSql.Append("select count(1) FROM S_Role ");
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
				strSql.Append("order by T.RoleID desc");
			}
			strSql.Append(")AS Row, T.*  from S_Role T ");
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
			parameters[0].Value = "S_Role";
			parameters[1].Value = "RoleID";
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

