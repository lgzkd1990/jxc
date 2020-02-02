using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class zu_huiyuan
    {
        public zu_huiyuan()
        { }
        #region Model
        private int _id;
        private string _zu;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zu
        {
            set { _zu = value; }
            get { return _zu; }
        }
        #endregion Model
    }
}
