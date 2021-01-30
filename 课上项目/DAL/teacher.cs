using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WindowsForms_Student.DAL
{
	/// <summary>
	/// 数据访问类:teacher
	/// </summary>
	public partial class teacher
	{
		public teacher()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string TNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from teacher");
			strSql.Append(" where TNo=@TNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@TNo", SqlDbType.VarChar,30)			};
			parameters[0].Value = TNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.teacher model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into teacher(");
			strSql.Append("TNo,TName,DNo,TSex,TAge)");
			strSql.Append(" values (");
			strSql.Append("@TNo,@TName,@DNo,@TSex,@TAge)");
			SqlParameter[] parameters = {
					new SqlParameter("@TNo", SqlDbType.VarChar,30),
					new SqlParameter("@TName", SqlDbType.VarChar,30),
					new SqlParameter("@DNo", SqlDbType.VarChar,30),
					new SqlParameter("@TSex", SqlDbType.VarChar,50),
					new SqlParameter("@TAge", SqlDbType.Int,4)};
			parameters[0].Value = model.TNo;
			parameters[1].Value = model.TName;
			parameters[2].Value = model.DNo;
			parameters[3].Value = model.TSex;
			parameters[4].Value = model.TAge;

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
		public bool Update(WindowsForms_Student.Model.teacher model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update teacher set ");
			strSql.Append("TName=@TName,");
			strSql.Append("DNo=@DNo,");
			strSql.Append("TSex=@TSex,");
			strSql.Append("TAge=@TAge");
			strSql.Append(" where TNo=@TNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@TName", SqlDbType.VarChar,30),
					new SqlParameter("@DNo", SqlDbType.VarChar,30),
					new SqlParameter("@TSex", SqlDbType.VarChar,50),
					new SqlParameter("@TAge", SqlDbType.Int,4),
					new SqlParameter("@TNo", SqlDbType.VarChar,30)};
			parameters[0].Value = model.TName;
			parameters[1].Value = model.DNo;
			parameters[2].Value = model.TSex;
			parameters[3].Value = model.TAge;
			parameters[4].Value = model.TNo;

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
		public bool Delete(string TNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from teacher ");
			strSql.Append(" where TNo=@TNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@TNo", SqlDbType.VarChar,30)			};
			parameters[0].Value = TNo;

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
		public bool DeleteList(string TNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from teacher ");
			strSql.Append(" where TNo in ("+TNolist + ")  ");
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
		public WindowsForms_Student.Model.teacher GetModel(string TNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TNo,TName,DNo,TSex,TAge from teacher ");
			strSql.Append(" where TNo=@TNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@TNo", SqlDbType.VarChar,30)			};
			parameters[0].Value = TNo;

			WindowsForms_Student.Model.teacher model=new WindowsForms_Student.Model.teacher();
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
		public WindowsForms_Student.Model.teacher DataRowToModel(DataRow row)
		{
			WindowsForms_Student.Model.teacher model=new WindowsForms_Student.Model.teacher();
			if (row != null)
			{
				if(row["TNo"]!=null)
				{
					model.TNo=row["TNo"].ToString();
				}
				if(row["TName"]!=null)
				{
					model.TName=row["TName"].ToString();
				}
				if(row["DNo"]!=null)
				{
					model.DNo=row["DNo"].ToString();
				}
				if(row["TSex"]!=null)
				{
					model.TSex=row["TSex"].ToString();
				}
				if(row["TAge"]!=null && row["TAge"].ToString()!="")
				{
					model.TAge=int.Parse(row["TAge"].ToString());
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
			strSql.Append("select TNo,TName,DNo,TSex,TAge ");
			strSql.Append(" FROM teacher ");
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
			strSql.Append(" TNo,TName,DNo,TSex,TAge ");
			strSql.Append(" FROM teacher ");
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
			strSql.Append("select count(1) FROM teacher ");
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
				strSql.Append("order by T.TNo desc");
			}
			strSql.Append(")AS Row, T.*  from teacher T ");
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
			parameters[0].Value = "teacher";
			parameters[1].Value = "TNo";
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

