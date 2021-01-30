using System;
namespace WindowsForms_Student.Model
{
	/// <summary>
	/// student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class student
	{
		public student()
		{}
		#region Model
		private string _sno;
		private string _sname;
		private string _ssex;
		private string _dno;
		private int? _sage;
		private string _sbirthday;
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
		public string SName
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SSex
		{
			set{ _ssex=value;}
			get{return _ssex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DNo
		{
			set{ _dno=value;}
			get{return _dno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SAge
		{
			set{ _sage=value;}
			get{return _sage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBirthday
		{
			set{ _sbirthday=value;}
			get{return _sbirthday;}
		}
		#endregion Model

	}
}

