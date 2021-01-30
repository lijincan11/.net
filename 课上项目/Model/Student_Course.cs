using System;
namespace WindowsForms_Student.Model
{
	/// <summary>
	/// Student_Course:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Student_Course
	{
		public Student_Course()
		{}
		#region Model
		private string _sno;
		private string _cno;
		private string _score;
		/// <summary>
		/// 
		/// </summary>
		public string SNo
		{
			set{ _sno=value;}
			get{return _sno;}
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
		public string Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model

	}
}

