using System;
namespace WindowsForms_Student.Model
{
	/// <summary>
	/// department:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class department
	{
		public department()
		{}
		#region Model
		private string _dno;
		private string _dname;
		private string _dmanger;
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
		public string DName
		{
			set{ _dname=value;}
			get{return _dname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DManger
		{
			set{ _dmanger=value;}
			get{return _dmanger;}
		}
		#endregion Model

	}
}

