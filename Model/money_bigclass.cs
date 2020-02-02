using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类 money_bigclass
    /// </summary>
   public class money_bigclass
    {
       public money_bigclass()
       {
       }
       private int _id;
       private string _bigclass;
       private int _type;
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
       public string bigclass
       {
           set { _bigclass = value; }
           get { return _bigclass; }
       }
       /// <summary>
       /// 
       /// </summary>
       public int type
       {
           set { _type = value; }
           get { return _type; }
       }
    }
}
