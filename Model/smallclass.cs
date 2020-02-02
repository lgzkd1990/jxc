using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class smallclass
    {
        public smallclass()
		{}
		#region Model
		private int _id;
		private string _smallclass;
		private int _id_bigclass;
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
		public string smallclasses
		{
			set{ _smallclass=value;}
			get{return _smallclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int id_bigclass
		{
			set{ _id_bigclass=value;}
			get{return _id_bigclass;}
		}
		#endregion Model

	}
    }

