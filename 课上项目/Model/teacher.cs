using System;
namespace WindowsForms_Student.Model
{
	/// <summary>
	/// teacher:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class teacher
	{
		public teacher()
		{}
		#region Model
		private string _tno;
		private string _tname;
		private string _dno;
		private string _tsex;
		private int? _tage;
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
		public string TName
		{
			set{ _tname=value;}
			get{return _tname;}
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
		public string TSex
		{
			set{ _tsex=value;}
			get{return _tsex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TAge
		{
			set{ _tage=value;}
			get{return _tage;}
		}
		#endregion Model

	}
}

