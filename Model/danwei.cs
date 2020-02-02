using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类danwei
    /// </summary>
   public class danwei
    {
       public danwei()
       {
       }
       private int _id;
       private string _danwei;
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
       public string danweis
       {
           set { _danwei = value; }
           get { return _danwei; }
       }
    }
}
