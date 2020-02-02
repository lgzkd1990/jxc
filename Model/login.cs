using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类login
    /// </summary>
   public class login
    {
       public login()
       {
       }
       private int _id;
       private string _bianhao;
       private string _username;
       private string _pwd;
       private string _quanxian;
       private string _xinbie;
       private string _tel;
       private string _address;
       private string _sfz;
       private decimal _gongzi;
       private string _qq;
       private string _email;
       private int _id_zu;
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
       public string bianhao
       {
           set { _bianhao = value; }
           get { return _bianhao; }
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
       public string pwd
       {
           set { _pwd = value; }
           get { return _pwd; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string quanxian
       {
           set { _quanxian = value; }
           get { return _quanxian; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string xinbie
       {
           set { _xinbie = value; }
           get { return _xinbie; }
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
       public string address
       {
           set { _address = value; }
           get { return _address; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string sfz
       {
           set { _sfz = value; }
           get { return _sfz; }
       }
       /// <summary>
       /// 
       /// </summary>
       public decimal gongzi
       {
           set { _gongzi = value; }
           get { return _gongzi; }
       }
       /// <summary>
       /// 
       /// </summary>
       public string qq
       {
           set { _qq = value; }
           get { return _qq; }
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
       public int id_zu
       {
           set { _id_zu = value; }
           get { return _id_zu; }
       }
    }
}
