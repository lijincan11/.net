using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WindowsForms_Student.Model;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;

namespace WindowsForms_Student.DAL
{
    public class Core
    {
        public Core() { }
        /// <summary>
        /// 获取连接数据库的字符串
        /// </summary>
        public void getDBConnectionString()
        {
            DbHelperSQL.connectionString= @"Data Source =.; Initial Catalog = db9.9; Integrated Security = True";
        }


        /// <summary>
        /// 根据学生编号和姓名获取学生信息
        /// </summary>
        /// <param name="SNo">学生编号</param>
        /// <param name="SName">学生姓名</param>
        /// <returns></returns>
        public DataSet GetListStudent(string SNo, string SName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.SNo,a.SName,a.SSex,a.SBirthday,a.DNo,a.SAge,b.DName");
            strSql.Append(" from student a,department b");
            strSql.Append(" where a.DNo = b.DNo");
            if (SNo != "")
                strSql.Append(" and SNo like '%" + SNo + "%' ");
            if (SName != "")
                strSql.Append(" and SName like '%" + SName + "%'");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据编号和姓名获取老师的信息
        /// </summary>
        /// <param name="TNo">老师编号</param>
        /// <param name="TName">老师姓名</param>
        /// <returns></returns>
        public DataSet GetListTeacher(string TNo, string TName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.TNo,a.TName,a.TSex,a.TNo,b.DName,a.TAge");
            strSql.Append(" from teacher a,department b");
            strSql.Append(" where a.DNo = b.DNo");
            if (TNo != "")
                strSql.Append(" and TNo like '%" + TNo + "%' ");
            if (TName != "")
                strSql.Append(" and TName like '%" + TName + "%'");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据编号和姓名获取课程的信息
        /// </summary>
        /// <param name="CNo">课程编号</param>
        /// <param name="CName">课程名</param>
        /// <returns></returns>
        public DataSet GetListCourse(string CNo, string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cNo,CName,CScore from Course where 1 = 1");
            if (CNo != "")
                strSql.Append(" and TNo like '%" + CNo + "%' ");
            if (CName != "")
                strSql.Append(" and TName like '%" + CName + "%'");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据SNO获取该学生已选课程列表
        /// </summary>
        /// <param name="SNo">学生编号</param>
        /// <returns></returns>
        public DataSet GetListS_C(string SNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CNo,CName,CScore from Course");
            strSql.Append(" where CNo in (select CNo from Student_Course where SNo = '"+SNo+"')");
           
           

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据SNO获取该学生未选课程列表
        /// </summary>
        /// <param name="SNo">学生编号</param>
        /// <returns></returns>
        public DataSet GetListS_CNot(string SNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CNo,CName,CScore from Course");
            strSql.Append(" where CNo not in (select CNo from Student_Course where SNo = '" + SNo + "')");
           


            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据TNO获取该老师已选课程列表
        /// </summary>
        /// <param name="TNo">老师编号</param>
        /// <returns></returns>
        public DataSet GetListT_C(string TNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CNo,CName,CScore from Course");
            strSql.Append(" where CNo in (select CNo from Teacher_Course where TNo = '" + TNo + "')");



            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据TNO获取该老师未选课程列表
        /// </summary>
        /// <param name="TNo">老师编号</param>
        /// <returns></returns>
        public DataSet GetListT_CNot(string TNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CNo,CName,CScore from Course");
            strSql.Append(" where CNo Not in (select CNo from Teacher_Course where TNo = '" + TNo + "')");



            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据CNo获取选修了这门课的学生和成绩数据列表
        /// </summary>
        /// <param name="CNo">课程编号</param>
        /// <returns></returns>
        public DataSet GetListS_CScore(string CNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.SNo,a.SName,a.SSex,b.Score");
            strSql.Append(" from student a,Student_Course b where a.SNo = b.SNo and b.CNo = '"+ CNo+"'");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据userId和UserPwd校验该用户是否存在
        /// </summary>
        /// <param name="UserId">用户名</param>
        /// <param name="UserPwd">密码</param>
        /// <returns></returns>
        public bool ExistUser(string UserID, string UPassWord)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COUNT(1) from S_User");
            strSql.Append(" where UserID=@UserID and UPassWord = @UPassWord");
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID",SqlDbType.VarChar,50),
                new SqlParameter("@UPassWord",SqlDbType.VarChar,10)
            };
            parameters[0].Value = UserID;
            parameters[1].Value = UPassWord;

            return DbHelperSQL.Exists(strSql.ToString(),parameters);
        }


        /// <summary>
        /// 根据UserID获取用户信息
        /// </summary>
        /// <param name="UserID">用户名</param>
        /// <returns></returns>
        public DataSet GetListUser(string UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserID,UPassWord,SNO,TNO from S_User");
            if (UserID != "")
                strSql.Append(" where UserID like '%" + UserID + "%'");

            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据UserID获取用户角色列表
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
        public DataSet GetListUserRole(string UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RoleID from S_U_R");
            strSql.Append(" where UserID like '"+UserID+"'");


            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据UserID删除该用户的所有角色信息
        /// </summary>
        /// <param name="UserId">用户ID</param>
        /// <returns></returns>
        public int DeleteUserRole(string UserId)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("delete from S_U_R where UserID = '" + UserId + "' ");
            return DbHelperSQL.ExecuteSql(strsql.ToString());
        }

        /// <summary>
        /// 根据RolrID获取该角色的所拥有的权限
        /// </summary>
        /// <param name="RolrID">角色ID</param>
        /// <returns></returns>
        public DataSet GetListRoleRight(string RolrID)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("select a.FunctionID,a.FunctionName,b.FunctionID as have from S_Function a ");
            strsql.Append(" left join S_R_F  b on a.FunctionID = b.FunctionID and b.RoleID = '"+RolrID+"'");
           
            return DbHelperSQL.Query(strsql.ToString());
        }

        /// <summary>
        /// 根据UserID获取该用户的所拥有的权限
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>返回用户权限的集合</returns>
        public DataSet GetListUserRight(string UserID)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("select FunctionID from S_R_F where RoleID in ");
            strsql.Append(" (select RoleID from S_U_R where UserID = '"+UserID+"')");

            return DbHelperSQL.Query(strsql.ToString());
        }

        /// <summary> 
        /// 功能：根据学生姓名和课程名称获取学生成绩
        /// 参数：CName 课程名称 SName 学生姓名
        /// </summary>
        public DataSet GetListStudentScore(string CName, string SName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Course.CName,Student.SNO,Student.SName,Student_Course.Score from Student,Student_Course,Course");
            strSql.Append(" where Student.SNO = Student_Course.SNO and Course.CNO = Student_Course.CNO"); // 
            if (CName != "")
            {
                strSql.Append(" and CName like '%" + CName + "%'");
            }
            if (SName != "")
            {
                strSql.Append(" and SName like '%" + SName + "%'");
            }

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据角色ID获取角色信息
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        /// <returns>返回角色信息</returns>
        public DataSet GetRoleList(string RoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select S_Role.RoleID,S_Role.RoleName from S_Role");
            if (RoleID != "")
            {
                strSql.Append(" where RoleID like '%" + RoleID + "%'");
            }

            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
