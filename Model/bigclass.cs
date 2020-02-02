using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体类bigclass
    /// </summary>
   public class bigclass
    {
       public bigclass()
       {
       }
       private int _id;
       private string _bigclass;
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
       public string bigclasses
       {
           set { _bigclass = value; }
           get { return _bigclass; }
       }

    }
}
