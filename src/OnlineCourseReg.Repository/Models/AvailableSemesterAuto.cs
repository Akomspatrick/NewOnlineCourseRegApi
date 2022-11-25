using System; 
using System.Collections.ObjectModel; 
using System.ComponentModel.DataAnnotations;

namespace  OnlineCourseReg.Repository.Models 
 { 
    public  partial class  AvailableSemester : IEntity  
 { 
public AvailableSemester(String CampId, String ProgId, String AsetId, String AsessionId, String SemesterId, String TheprogType, String Remark  ) 
 { 
 myCampId = CampId ;
myProgId = ProgId ;
myAsetId = AsetId ;
myAsessionId = AsessionId ;
mySemesterId = SemesterId ;
myTheprogType = TheprogType ;
myRemark = Remark ;

}
 
 
 
   private  String myCampId; 
 [MaxLength(6)]
 public    String CampId
 { get { return myCampId ;} 
   set { 
  
 myCampId  = value; 
 
 }
} 
 
 private  String myProgId; 
 [MaxLength(6)]
 public    String ProgId
 { get { return myProgId ;} 
   set { 
  
 myProgId  = value; 
 
 }
} 
 
 private  String myAsetId; 
 [MaxLength(9)]
 public    String AsetId
 { get { return myAsetId ;} 
   set { 
  
 myAsetId  = value; 
 
 }
} 
 
 private  String myAsessionId; 
 [MaxLength(9)]
 public    String AsessionId
 { get { return myAsessionId ;} 
   set { 
  
 myAsessionId  = value; 
 
 }
} 
 
 private  String mySemesterId; 
 [MaxLength(1)]
 public    String SemesterId
 { get { return mySemesterId ;} 
   set { 
  
 mySemesterId  = value; 
 
 }
} 
 
 private  String myTheprogType; 
 [MaxLength(10)]
 public    String TheprogType
 { get { return myTheprogType ;} 
   set { 
  
 myTheprogType  = value; 
 
 }
} 
 
 private  String myRemark; 
 [MaxLength(10)]
 public    String Remark
 { get { return myRemark ;} 
   set { 
  
 myRemark  = value; 
 
 }
} 
 

 public AvailableSemester() 
 { } 
  
 public static AvailableSemester  Create() 
 { 
   AvailableSemester  NewAvailableSemester = new AvailableSemester
 { 
 }; 
   return NewAvailableSemester; 
 } }  
    } 