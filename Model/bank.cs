using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类bank
    /// </summary>
    public class bank
    {
        public bank()
        {

        }
        private int _id;
        private string _bank;
        private decimal _price;
        private string _beizhu;
        private bool _moren;
        /// <summary>
        /// id字段
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string banks
        {
            set { _bank = value; }
            get { return _bank; }
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
        public string beizhu
        {
            set { _beizhu = value; }
            get { return _beizhu; }
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
