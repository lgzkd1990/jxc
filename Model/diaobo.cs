using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类diaobo
    /// </summary>
  public class diaobo
    {
      public diaobo()
      {
      }
      private int _id;
      private int _id_produit;
      private string _title;
      private int _id_login;
      private string _login;
      private int _id_login2;
      private string _login2;
      private DateTime _selldate;
      private decimal _shulian;
      private int _type;
      private int _id_ku_chu;
      private string _ku_chu;
      private int _id_ku_ru;
      private string _ku_ru;
      private string _huohao;
      private string _bigclass;
      private string _smallclass;
      private string _guige;
      private decimal _price;
      private decimal _price2;
      private bool _isok;
      private string _photo;
      private string _bianhao;
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
      public int id_produit
      {
          set { _id_produit = value; }
          get { return _id_produit; }
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
      public int id_login2
      {
          set { _id_login2 = value; }
          get { return _id_login2; }
      }
      /// <summary>
      /// 
      /// </summary>
      public string login2
      {
          set { _login2 = value; }
          get { return _login2; }
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
      public decimal shulian
      {
          set { _shulian = value; }
          get { return _shulian; }
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
      public int id_ku_chu
      {
          set { _id_ku_chu = value; }
          get { return _id_ku_chu; }
      }
      /// <summary>
      /// 
      /// </summary>
      public string ku_chu
      {
          set { _ku_chu = value; }
          get { return _ku_chu; }
      }
      /// <summary>
      /// 
      /// </summary>
      public int id_ku_ru
      {
          set { _id_ku_ru = value; }
          get { return _id_ku_ru; }
      }
      /// <summary>
      /// 
      /// </summary>
      public string ku_ru
      {
          set { _ku_ru = value; }
          get { return _ku_ru; }
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
      public string bigclass
      {
          set { _bigclass = value; }
          get { return _bigclass; }
      }
      /// <summary>
      /// 
      /// </summary>
      public string smallclass
      {
          set { _smallclass = value; }
          get { return _smallclass; }
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
      public bool isok
      {
          set { _isok = value; }
          get { return _isok; }
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
      public string bianhao
      {
          set { _bianhao = value; }
          get { return _bianhao; }
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
