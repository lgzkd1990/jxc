using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public  class shiwei_money
    {
        public shiwei_money()
        { }
        #region Model
        private int _id;
        private string _beizhu;
        private int _id_login;
        private string _login;
        private DateTime _selldate;
        private int _type;
        private int _id_bigclass;
        private int _id_smallclass;
        private decimal _price;
        private bool _isok;
        private int _id_bank;
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
        public string beizhu
        {
            set { _beizhu = value; }
            get { return _beizhu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id_login
        {
            set { _id_login = value; }
            get { return _id_login; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string login
        {
            set { _login = value; }
            get { return _login; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime selldate
        {
            set { _selldate = value; }
            get { return _selldate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id_bigclass
        {
            set { _id_bigclass = value; }
            get { return _id_bigclass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id_smallclass
        {
            set { _id_smallclass = value; }
            get { return _id_smallclass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool isok
        {
            set { _isok = value; }
            get { return _isok; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id_bank
        {
            set { _id_bank = value; }
            get { return _id_bank; }
        }
    }
        #endregion
}

