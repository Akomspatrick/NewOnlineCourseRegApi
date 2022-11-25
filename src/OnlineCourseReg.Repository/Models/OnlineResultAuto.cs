using System; 
using System.Collections.ObjectModel; 
using System.ComponentModel.DataAnnotations;

namespace  OnlineCourseReg.Repository.Models 
 { 
    public  partial class  OnlineResult : IEntity  
 { 
public OnlineResult(String OnlineResultId, String CourseIdLine, Guid OnlineResultGUID  ) 
 { 
 myOnlineResultId = OnlineResultId ;
myCourseIdLine = CourseIdLine ;
myOnlineResultGUID = OnlineResultGUID ;

}
 
 
 
   private  String myOnlineResultId; 
 [MaxLength(60)]
 public    String OnlineResultId
 { get { return myOnlineResultId ;} 
   set { 
  
 myOnlineResultId  = value; 
 
 }
} 
 
 private  String myCourseIdLine; 
 [MaxLength(260)]
 public    String CourseIdLine
 { get { return myCourseIdLine ;} 
   set { 
  
 myCourseIdLine  = value; 
 
 }
} 
 
 private  Guid myOnlineResultGUID; 
 public    Guid OnlineResultGUID
 { get { return myOnlineResultGUID ;} 
   set { 
  
 myOnlineResultGUID  = value; 
 
 }
} 
 

 public OnlineResult() 
 { } 
  
 public static OnlineResult  Create() 
 { 
   OnlineResult  NewOnlineResult = new OnlineResult
 { 
 }; 
   return NewOnlineResult; 
 } }  
    } 