using System;
namespace WindowsForms_Student.Model
{
	/// <summary>
	/// Teacher_Course:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Teacher_Course
	{
		public Teacher_Course()
		{}
		#region Model
		private string _tno;
		private string _cno;
		private string _time;
		private string _place;
		/// <summary>
		/// 
		/// </summary>
		public string TNo
		{
			set{ _tno=value;}
			get{return _tno;}
		}
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
		public string Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Place
		{
			set{ _place=value;}
			get{return _place;}
		}
		#endregion Model

	}
}

