using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WindowsForms_Student.DAL
{
	/// <summary>
	/// 数据访问类:Student_Course
	/// </summary>
	public partial class Student_Course
	{
		public Student_Course()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SNo,string CNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Student_Course");
			strSql.Append(" where SNo=@SNo and CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SNo", SqlDbType.VarChar,30),
					new SqlParameter("@CNo", SqlDbType.VarChar,20)			};
			parameters[0].Value = SNo;
			parameters[1].Value = CNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.Student_Course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Student_Course(");
			strSql.Append("SNo,CNo,Score)");
			strSql.Append(" values (");
			strSql.Append("@SNo,@CNo,@Score)");
			SqlParameter[] parameters = {
					new SqlParameter("@SNo", SqlDbType.VarChar,30),
					new SqlParameter("@CNo", SqlDbType.VarChar,20),
					new SqlParameter("@Score", SqlDbType.VarChar,30)};
			parameters[0].Value = model.SNo;
			parameters[1].Value = model.CNo;
			parameters[2].Value = model.Score;

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
		public bool Update(WindowsForms_Student.Model.Student_Course model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Student_Course set ");
			strSql.Append("Score=@Score");
			strSql.Append(" where SNo=@SNo and CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@Score", SqlDbType.VarChar,30),
					new SqlParameter("@SNo", SqlDbType.VarChar,30),
					new SqlParameter("@CNo", SqlDbType.VarChar,20)};
			parameters[0].Value = model.Score;
			parameters[1].Value = model.SNo;
			parameters[2].Value = model.CNo;

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
		public bool Delete(string SNo,string CNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Student_Course ");
			strSql.Append(" where SNo=@SNo and CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SNo", SqlDbType.VarChar,30),
					new SqlParameter("@CNo", SqlDbType.VarChar,20)			};
			parameters[0].Value = SNo;
			parameters[1].Value = CNo;

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
		/// 得到一个对象实体
		/// </summary>
		public WindowsForms_Student.Model.Student_Course GetModel(string SNo,string CNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SNo,CNo,Score from Student_Course ");
			strSql.Append(" where SNo=@SNo and CNo=@CNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SNo", SqlDbType.VarChar,30),
					new SqlParameter("@CNo", SqlDbType.VarChar,20)			};
			parameters[0].Value = SNo;
			parameters[1].Value = CNo;

			WindowsForms_Student.Model.Student_Course model=new WindowsForms_Student.Model.Student_Course();
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
		public WindowsForms_Student.Model.Student_Course DataRowToModel(DataRow row)
		{
			WindowsForms_Student.Model.Student_Course model=new WindowsForms_Student.Model.Student_Course();
			if (row != null)
			{
				if(row["SNo"]!=null)
				{
					model.SNo=row["SNo"].ToString();
				}
				if(row["CNo"]!=null)
				{
					model.CNo=row["CNo"].ToString();
				}
				if(row["Score"]!=null)
				{
					model.Score=row["Score"].ToString();
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
			strSql.Append("select SNo,CNo,Score ");
			strSql.Append(" FROM Student_Course ");
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
			strSql.Append(" SNo,CNo,Score ");
			strSql.Append(" FROM Student_Course ");
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
			strSql.Append("select count(1) FROM Student_Course ");
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
			strSql.Append(")AS Row, T.*  from Student_Course T ");
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
			parameters[0].Value = "Student_Course";
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

