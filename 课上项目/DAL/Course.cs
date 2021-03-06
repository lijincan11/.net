﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WindowsForms_Student.DAL
{
	/// <summary>
	/// 数据访问类:Course
	/// </summary>
	public partial class Course
	{
		public Course()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Course");
			strSql.Append(" where CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@CNo", SqlDbType.VarChar,20)			};
			parameters[0].Value = CNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.Course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Course(");
			strSql.Append("CNo,CName,CScore,COptional)");
			strSql.Append(" values (");
			strSql.Append("@CNo,@CName,@CScore,@COptional)");
			SqlParameter[] parameters = {
					new SqlParameter("@CNo", SqlDbType.VarChar,20),
					new SqlParameter("@CName", SqlDbType.VarChar,30),
					new SqlParameter("@CScore", SqlDbType.VarChar,20),
					new SqlParameter("@COptional", SqlDbType.VarChar,30)};
			parameters[0].Value = model.CNo;
			parameters[1].Value = model.CName;
			parameters[2].Value = model.CScore;
			parameters[3].Value = model.COptional;

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
		public bool Update(WindowsForms_Student.Model.Course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Course set ");
			strSql.Append("CName=@CName,");
			strSql.Append("CScore=@CScore,");
			strSql.Append("COptional=@COptional");
			strSql.Append(" where CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@CName", SqlDbType.VarChar,30),
					new SqlParameter("@CScore", SqlDbType.VarChar,20),
					new SqlParameter("@COptional", SqlDbType.VarChar,30),
					new SqlParameter("@CNo", SqlDbType.VarChar,20)};
			parameters[0].Value = model.CName;
			parameters[1].Value = model.CScore;
			parameters[2].Value = model.COptional;
			parameters[3].Value = model.CNo;

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
		public bool Delete(string CNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Course ");
			strSql.Append(" where CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@CNo", SqlDbType.VarChar,20)			};
			parameters[0].Value = CNo;

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
		public bool DeleteList(string CNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Course ");
			strSql.Append(" where CNo in ("+CNolist + ")  ");
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
		public WindowsForms_Student.Model.Course GetModel(string CNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CNo,CName,CScore,COptional from Course ");
			strSql.Append(" where CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@CNo", SqlDbType.VarChar,20)			};
			parameters[0].Value = CNo;

			WindowsForms_Student.Model.Course model=new WindowsForms_Student.Model.Course();
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
		public WindowsForms_Student.Model.Course DataRowToModel(DataRow row)
		{
			WindowsForms_Student.Model.Course model=new WindowsForms_Student.Model.Course();
			if (row != null)
			{
				if(row["CNo"]!=null)
				{
					model.CNo=row["CNo"].ToString();
				}
				if(row["CName"]!=null)
				{
					model.CName=row["CName"].ToString();
				}
				if(row["CScore"]!=null)
				{
					model.CScore=row["CScore"].ToString();
				}
				if(row["COptional"]!=null)
				{
					model.COptional=row["COptional"].ToString();
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
			strSql.Append("select CNo,CName,CScore,COptional ");
			strSql.Append(" FROM Course ");
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
			strSql.Append(" CNo,CName,CScore,COptional ");
			strSql.Append(" FROM Course ");
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
			strSql.Append("select count(1) FROM Course ");
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
				strSql.Append("order by T.CNo desc");
			}
			strSql.Append(")AS Row, T.*  from Course T ");
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
			parameters[0].Value = "Course";
			parameters[1].Value = "CNo";
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

