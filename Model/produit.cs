using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类produit 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class produit
    {
        public produit()
        {
        }
        private int _id;
        private string _title;
        private int _id_bigclass;
        private int _id_smallclass;
        private decimal _price;
        private decimal _price2;
        private decimal _shulian;
        private string _danwei;
        private int _id_ku;
        private int _tichen_type;
        private decimal _tichen;
        private string _guige;
        private string _huohao;
        private decimal _baojin;
        private int _class;
        private int _duihuan;
        private string _photo;
        private string _beizhu;
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
        public string title
        {
            set { _title = value; }
            get { return _title; }
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
        public decimal price2
        {
            set { _price2 = value; }
            get { return _price2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal shulian
        {
            set { _shulian = value; }
            get { return _shulian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string danwei
        {
            set { _danwei = value; }
            get { return _danwei; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id_ku
        {
            set { _id_ku = value; }
            get { return _id_ku; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int tichen_type
        {
            set { _tichen_type = value; }
            get { return _tichen_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal tichen
        {
            set { _tichen = value; }
            get { return _tichen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string guige
        {
            set { _guige = value; }
            get { return _guige; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huohao
        {
            set { _huohao = value; }
            get { return _huohao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal baojin
        {
            set { _baojin = value; }
            get { return _baojin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int classes
        {
            set { _class = value; }
            get { return _class; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int duihuan
        {
            set { _duihuan = value; }
            get { return _duihuan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string photo
        {
            set { _photo = value; }
            get { return _photo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beizhu
        {
            set { _beizhu = value; }
            get { return _beizhu; }
        }
    }
}
