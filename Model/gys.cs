using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类gys
    /// </summary>
   public class gys
    {
       public gys() { }
       private int _id;
       private string _company;
       private string _name;
       private string _address;
       private string _tel;
       private string _beizhu;
       private string _fax;
       private string _shouji;
       private string _site;
       private string _email;
       private string _pc;
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
       public string company
       {
           set { _company = value; }
           get { return _company; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string name
       {
           set { _name = value; }
           get { return _name; }
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
       public string tel
       {
           set { _tel = value; }
           get { return _tel; }
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
       public string fax
       {
           set { _fax = value; }
           get { return _fax; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string shouji
       {
           set { _shouji = value; }
           get { return _shouji; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string site
       {
           set { _site = value; }
           get { return _site; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string email
       {
           set { _email = value; }
           get { return _email; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string pc
       {
           set { _pc = value; }
           get { return _pc; }
       }
    }

}
