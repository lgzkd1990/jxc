using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类ku
    /// </summary>
   public class ku
    {
       public ku()
       {
       }
       private int _id;
		private string _ku;
		private string _login;
		private string _address;
		private string _tel;
		private string _beizhu;
		private bool _moren;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string kus
		{
			set{ _ku=value;}
			get{return _ku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string login
		{
			set{ _login=value;}
			get{return _login;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		/// <summary>
		/// 
		/// </summary>
        public bool moren
        {
            set { _moren = value; }
            get { return _moren; }
        }
    }
}
