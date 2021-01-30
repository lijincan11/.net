using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WindowsForms_Student.DAL
{
	/// <summary>
	/// 数据访问类:department
	/// </summary>
	public partial class department
	{
		public department()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from department");
			strSql.Append(" where DNo=@DNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@DNo", SqlDbType.VarChar,30)			};
			parameters[0].Value = DNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WindowsForms_Student.Model.department model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into department(");
			strSql.Append("DNo,DName,DManger)");
			strSql.Append(" values (");
			strSql.Append("@DNo,@DName,@DManger)");
			SqlParameter[] parameters = {
					new SqlParameter("@DNo", SqlDbType.VarChar,30),
					new SqlParameter("@DName", SqlDbType.VarChar,30),
					new SqlParameter("@DManger", SqlDbType.VarChar,30)};
			parameters[0].Value = model.DNo;
			parameters[1].Value = model.DName;
			parameters[2].Value = model.DManger;

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
		public bool Update(WindowsForms_Student.Model.department model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update department set ");
			strSql.Append("DName=@DName,");
			strSql.Append("DManger=@DManger");
			strSql.Append(" where DNo=@DNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@DName", SqlDbType.VarChar,30),
					new SqlParameter("@DManger", SqlDbType.VarChar,30),
					new SqlParameter("@DNo", SqlDbType.VarChar,30)};
			parameters[0].Value = model.DName;
			parameters[1].Value = model.DManger;
			parameters[2].Value = model.DNo;

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
		public bool Delete(string DNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from department ");
			strSql.Append(" where DNo=@DNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@DNo", SqlDbType.VarChar,30)			};
			parameters[0].Value = DNo;

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
		public bool DeleteList(string DNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from department ");
			strSql.Append(" where DNo in ("+DNolist + ")  ");
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
		public WindowsForms_Student.Model.department GetModel(string DNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DNo,DName,DManger from department ");
			strSql.Append(" where DNo=@DNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@DNo", SqlDbType.VarChar,30)			};
			parameters[0].Value = DNo;

			WindowsForms_Student.Model.department model=new WindowsForms_Student.Model.department();
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
		public WindowsForms_Student.Model.department DataRowToModel(DataRow row)
		{
			WindowsForms_Student.Model.department model=new WindowsForms_Student.Model.department();
			if (row != null)
			{
				if(row["DNo"]!=null)
				{
					model.DNo=row["DNo"].ToString();
				}
				if(row["DName"]!=null)
				{
					model.DName=row["DName"].ToString();
				}
				if(row["DManger"]!=null)
				{
					model.DManger=row["DManger"].ToString();
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
			strSql.Append("select DNo,DName,DManger ");
			strSql.Append(" FROM department ");
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
			strSql.Append(" DNo,DName,DManger ");
			strSql.Append(" FROM department ");
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
			strSql.Append("select count(1) FROM department ");
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
				strSql.Append("order by T.DNo desc");
			}
			strSql.Append(")AS Row, T.*  from department T ");
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
			parameters[0].Value = "department";
			parameters[1].Value = "DNo";
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

