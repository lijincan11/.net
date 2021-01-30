using System;
namespace WindowsForms_Student.Model
{
	/// <summary>
	/// Course:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Course
	{
		public Course()
		{}
		#region Model
		private string _cno;
		private string _cname;
		private string _cscore;
		private string _coptional;
		/// <summary>
		/// 
		/// </summary>
		public string CNo
		{
			set{ _cno=value;}
			get{return _cno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CScore
		{
			set{ _cscore=value;}
			get{return _cscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COptional
		{
			set{ _coptional=value;}
			get{return _coptional;}
		}
		#endregion Model

	}
}

