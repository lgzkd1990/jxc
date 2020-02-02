using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class rizi
    {
        public rizi()
        {
        }
        private int _id;
        private string _username;
        private string _class;
        private string _address;
        private DateTime _logindate;
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
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string classes
        {
            set { _class = value; }
            get { return _class; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime logindate
        {
            set { _logindate = value; }
            get { return _logindate; }
        }
    }
}
