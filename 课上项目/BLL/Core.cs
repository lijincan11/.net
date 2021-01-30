using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WindowsForms_Student.Model;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WindowsForms_Student.BLL
{
    public class Core
    {
        private static string strUserRight;//保存用户登录的所有权限


        private readonly WindowsForms_Student.DAL.Core dal = new WindowsForms_Student.DAL.Core();

        /// <summary>
        /// 获取连接数据库的字符串
        /// </summary>
        public void getDBConnectionString()
        {
            dal.getDBConnectionString();
        }

        /// <summary>
        /// 根据学生编号和姓名获取学生信息
        /// </summary>
        /// <param name="SNo">学生编号</param>
        /// <param name="SName">学生姓名</param>
        /// <returns></returns>
        public DataSet GetListStudent(string SNo, string SName)
        {
            return dal.GetListStudent(SNo, SName);
        }

        /// <summary>
        /// 根据编号和姓名获取老师的信息
        /// </summary>
        /// <param name="TNo">老师编号</param>
        /// <param name="TName">老师姓名</param>
        /// <returns></returns>
        public DataSet GetListTeacher(string TNo, string TName)
        {
            return dal.GetListTeacher(TNo, TName);
        }

        /// <summary>
        /// 根据编号和姓名获取课程的信息
        /// </summary>
        /// <param name="CNo">课程编号</param>
        /// <param name="CName">课程名</param>
        /// <returns></returns>
        public DataSet GetListCourse(string CNo, string CName)
        {
            return dal.GetListCourse(CNo, CName);
        }

        /// <summary>
        /// 根据SNO获取该学生已选课程列表
        /// </summary>
        /// <param name="SNo">学生编号</param>
        /// <returns></returns>
        public DataSet GetListS_C(string SNo)
        {
            return dal.GetListS_C(SNo);
        }

        /// <summary>
        /// 根据SNO获取该学生未选课程列表
        /// </summary>
        /// <param name="SNo">学生编号</param>
        /// <returns></returns>
        public DataSet GetListS_CNot(string SNo)
        {
            return dal.GetListS_CNot(SNo);
        }

        /// <summary>
        /// 根据TNO获取该老师已选课程列表
        /// </summary>
        /// <param name="TNo">老师编号</param>
        /// <returns></returns>
        public DataSet GetListT_C(string TNo)
        {
            return dal.GetListT_C(TNo);
        }

        /// <summary>
        /// 根据TNO获取该老师未选课程列表
        /// </summary>
        /// <param name="TNo">老师编号</param>
        /// <returns></returns>
        public DataSet GetListT_CNot(string TNo)
        {
            return dal.GetListT_CNot(TNo);
        }

        /// <summary>
        /// 根据CNo获取选修了这门课的学生和成绩数据列表
        /// </summary>
        /// <param name="CNo">课程编号</param>
        /// <returns></returns>
        public DataSet GetListS_CScore(string CNo)
        {
            return dal.GetListS_CScore(CNo);
        }


        /// <summary>
        /// 根据userId和UserPwd校验该用户是否存在
        /// </summary>
        /// <param name="UserId">用户名</param>
        /// <param name="UserPwd">密码</param>
        /// <returns></returns>
        public bool ExistUser(string UserID, string UPassWord)
        {
            return dal.ExistUser(UserID,UPassWord);
        }


        /// <summary>
        /// 根据UserID获取用户信息
        /// </summary>
        /// <param name="UserID">用户名</param>
        /// <returns></returns>
        public DataSet GetListUser(string UserID)
        {
            return dal.GetListUser(UserID);
        }

        /// <summary>
        /// 根据UserID获取用户角色列表
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
        public DataSet GetListUserRole(string UserID)
        {
            return dal.GetListUserRole(UserID);
        }


        /// <summary>
        /// 根据UserID删除该用户的所有角色信息
        /// </summary>
        /// <param name="UserId">用户ID</param>
        /// <returns>返回删除数据的个数</returns>
        public int DeleteUserRole(string UserId)
        {
            return dal.DeleteUserRole(UserId);
        }

        /// <summary>
        /// 根据RolrID获取该角色的所拥有的权限
        /// </summary>
        /// <param name="RolrID">角色ID</param>
        /// <returns></returns>
        public DataSet GetListRoleRight(string RolrID)
        {

            return dal.GetListRoleRight(RolrID);
        }

        /// <summary>
        /// 根据UserID获取该用户的所拥有的权限并保存到strUserRight
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>返回用户权限的集合</returns>
        public void GetUserRight(string UserID)
        {
            strUserRight = ",";//初始化
            DataTable tbRight = dal.GetListUserRight(UserID).Tables[0];
            foreach (DataRow row in tbRight.Rows)
            {
                strUserRight += row["FunctionID"].ToString() + ",";
            }

        }

        /// <summary>
        /// 判断登陆用户是否拥有FunctionID对应的权限
        /// </summary>
        /// <param name="FunctionID"></param>
        /// <returns>返回是否拥有权限</returns>
        public static bool IsHaveRight(string FunctionID)
        {
            return strUserRight.Contains("," + FunctionID + ",");
        }

        /// <summary> 
        /// 功能：根据学生姓名和课程名称获取学生成绩
        /// 参数：CName 课程名称 SName 学生姓名
        /// </summary>
        public DataSet GetListStudentScore(string CName, string SName)
        {
            return dal.GetListStudentScore(CName, SName);
        }

        /// <summary>
        /// 根据角色ID获取角色信息
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        /// <returns>返回角色信息</returns>
        public DataSet GetRoleList(string RoleID)
        {
            return dal.GetRoleList(RoleID);
        }
    }
}
