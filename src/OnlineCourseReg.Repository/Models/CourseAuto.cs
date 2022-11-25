using System; 
using System.Collections.ObjectModel; 
using System.ComponentModel.DataAnnotations;

namespace  OnlineCourseReg.Repository.Models 
 { 
    public  partial class  Course : IEntity  
 { 
public Course(String CampId, String FacId, String DeptId, String ProgId, String ProgOptionId, String AsetId, String AsessionId, String SemesterId, String CourseId, String CourseName, Decimal CourseUnit, String LevelToDo, String CourseNature, String HasPreq, String LecturesInCharge, String Venue, String Theprog  ) 
 { 
 myCampId = CampId ;
myFacId = FacId ;
myDeptId = DeptId ;
myProgId = ProgId ;
myProgOptionId = ProgOptionId ;
myAsetId = AsetId ;
myAsessionId = AsessionId ;
mySemesterId = SemesterId ;
myCourseId = CourseId ;
myCourseName = CourseName ;
myCourseUnit = CourseUnit ;
myLevelToDo = LevelToDo ;
myCourseNature = CourseNature ;
myHasPreq = HasPreq ;
myLecturesInCharge = LecturesInCharge ;
myVenue = Venue ;
myTheprog = Theprog ;

}
 
 
 
   private  String myCampId; 
 [MaxLength(6)]
 public    String CampId
 { get { return myCampId ;} 
   set { 
  
 myCampId  = value; 
 
 }
} 
 
 private  String myFacId; 
 [MaxLength(6)]
 public    String FacId
 { get { return myFacId ;} 
   set { 
  
 myFacId  = value; 
 
 }
} 
 
 private  String myDeptId; 
 [MaxLength(6)]
 public    String DeptId
 { get { return myDeptId ;} 
   set { 
  
 myDeptId  = value; 
 
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
 
 private  String myProgOptionId; 
 [MaxLength(6)]
 public    String ProgOptionId
 { get { return myProgOptionId ;} 
   set { 
  
 myProgOptionId  = value; 
 
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
 
 private  String myCourseId; 
 [MaxLength(6)]
 public    String CourseId
 { get { return myCourseId ;} 
   set { 
  
 myCourseId  = value; 
 
 }
} 
 
 private  String myCourseName; 
 [MaxLength(60)]
 public    String CourseName
 { get { return myCourseName ;} 
   set { 
  
 myCourseName  = value; 
 
 }
} 
 
 private  Decimal myCourseUnit; 
 public    Decimal CourseUnit
 { get { return myCourseUnit ;} 
   set { 
  
 myCourseUnit  = value; 
 
 }
} 
 
 private  String myLevelToDo; 
 [MaxLength(10)]
 public    String LevelToDo
 { get { return myLevelToDo ;} 
   set { 
  
 myLevelToDo  = value; 
 
 }
} 
 
 private  String myCourseNature; 
 [MaxLength(1)]
 public    String CourseNature
 { get { return myCourseNature ;} 
   set { 
  
 myCourseNature  = value; 
 
 }
} 
 
 private  String myHasPreq; 
 [MaxLength(1)]
 public    String HasPreq
 { get { return myHasPreq ;} 
   set { 
  
 myHasPreq  = value; 
 
 }
} 
 
 private  String myLecturesInCharge; 
 [MaxLength(60)]
 public    String LecturesInCharge
 { get { return myLecturesInCharge ;} 
   set { 
  
 myLecturesInCharge  = value; 
 
 }
} 
 
 private  String myVenue; 
 [MaxLength(60)]
 public    String Venue
 { get { return myVenue ;} 
   set { 
  
 myVenue  = value; 
 
 }
} 
 
 private  String myTheprog; 
 [MaxLength(10)]
 public    String Theprog
 { get { return myTheprog ;} 
   set { 
  
 myTheprog  = value; 
 
 }
} 
 

 public Course() 
 { } 
  
 public static Course  Create() 
 { 
   Course  NewCourse = new Course
 { 
 }; 
   return NewCourse; 
 } }  
    } 