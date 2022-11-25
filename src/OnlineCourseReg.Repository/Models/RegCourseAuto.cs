using System; 
using System.Collections.ObjectModel; 
using System.ComponentModel.DataAnnotations;

namespace  OnlineCourseReg.Repository.Models 
 { 
    public  partial class  RegCourse : IEntity  
 { 
public RegCourse(Guid RegCourseId, String StudentId, String CampId, String FacId, String DeptId, String ProgId, String ProgOptionId, String AsetId, String AsessionId, String SemesterId, String Surname, String Middlename, String Firstname, String CoursesToReg, String OutCourse, String LevelToDo, Decimal MinSemUnit, Decimal MaxSemUnit, DateTime UploadedDate, DateTime FinalSubmissionDate, String Astatus, Decimal TotalUnit, String Thenature, String Theprog, Guid StudentGUID, Int32 AUserId  ) 
 { 
 myRegCourseId = RegCourseId ;
myStudentId = StudentId ;
myCampId = CampId ;
myFacId = FacId ;
myDeptId = DeptId ;
myProgId = ProgId ;
myProgOptionId = ProgOptionId ;
myAsetId = AsetId ;
myAsessionId = AsessionId ;
mySemesterId = SemesterId ;
mySurname = Surname ;
myMiddlename = Middlename ;
myFirstname = Firstname ;
myCoursesToReg = CoursesToReg ;
myOutCourse = OutCourse ;
myLevelToDo = LevelToDo ;
myMinSemUnit = MinSemUnit ;
myMaxSemUnit = MaxSemUnit ;
myUploadedDate = UploadedDate ;
myFinalSubmissionDate = FinalSubmissionDate ;
myAstatus = Astatus ;
myTotalUnit = TotalUnit ;
myThenature = Thenature ;
myTheprog = Theprog ;
myStudentGUID = StudentGUID ;
myAUserId = AUserId ;

}
 
 
 
   private  Guid myRegCourseId; 
 public    Guid RegCourseId
 { get { return myRegCourseId ;} 
   set { 
  
 myRegCourseId  = value; 
 
 }
} 
 
 private  String myStudentId; 
 [MaxLength(20)]
 public    String StudentId
 { get { return myStudentId ;} 
   set { 
  
 myStudentId  = value; 
 
 }
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
 
 private  String mySurname; 
 [MaxLength(30)]
 public    String Surname
 { get { return mySurname ;} 
   set { 
  
 mySurname  = value; 
 
 }
} 
 
 private  String myMiddlename; 
 [MaxLength(30)]
 public    String Middlename
 { get { return myMiddlename ;} 
   set { 
  
 myMiddlename  = value; 
 
 }
} 
 
 private  String myFirstname; 
 [MaxLength(30)]
 public    String Firstname
 { get { return myFirstname ;} 
   set { 
  
 myFirstname  = value; 
 
 }
} 
 
 private  String myCoursesToReg; 
 [MaxLength(240)]
 public    String CoursesToReg
 { get { return myCoursesToReg ;} 
   set { 
  
 myCoursesToReg  = value; 
 
 }
} 
 
 private  String myOutCourse; 
 [MaxLength(240)]
 public    String OutCourse
 { get { return myOutCourse ;} 
   set { 
  
 myOutCourse  = value; 
 
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
 
 private  Decimal myMinSemUnit; 
 public    Decimal MinSemUnit
 { get { return myMinSemUnit ;} 
   set { 
  
 myMinSemUnit  = value; 
 
 }
} 
 
 private  Decimal myMaxSemUnit; 
 public    Decimal MaxSemUnit
 { get { return myMaxSemUnit ;} 
   set { 
  
 myMaxSemUnit  = value; 
 
 }
} 
 
 private  DateTime myUploadedDate; 
 public    DateTime UploadedDate
 { get { return myUploadedDate ;} 
   set { 
  
 myUploadedDate  = value; 
 
 }
} 
 
 private  DateTime myFinalSubmissionDate; 
 public    DateTime FinalSubmissionDate
 { get { return myFinalSubmissionDate ;} 
   set { 
  
 myFinalSubmissionDate  = value; 
 
 }
} 
 
 private  String myAstatus; 
 [MaxLength(10)]
 public    String Astatus
 { get { return myAstatus ;} 
   set { 
  
 myAstatus  = value; 
 
 }
} 
 
 private  Decimal myTotalUnit; 
 public    Decimal TotalUnit
 { get { return myTotalUnit ;} 
   set { 
  
 myTotalUnit  = value; 
 
 }
} 
 
 private  String myThenature; 
 [MaxLength(10)]
 public    String Thenature
 { get { return myThenature ;} 
   set { 
  
 myThenature  = value; 
 
 }
} 
 
 private  String myTheprog; 
 [MaxLength(6)]
 public    String Theprog
 { get { return myTheprog ;} 
   set { 
  
 myTheprog  = value; 
 
 }
} 
 
 private  Guid myStudentGUID; 
 public    Guid StudentGUID
 { get { return myStudentGUID ;} 
   set { 
  
 myStudentGUID  = value; 
 
 }
} 
 
 private  Int32 myAUserId; 
 public    Int32 AUserId
 { get { return myAUserId ;} 
   set { 
  
 myAUserId  = value; 
 
 }
} 
 

 public RegCourse() 
 { } 
  
 public static RegCourse  Create() 
 { 
   RegCourse  NewRegCourse = new RegCourse
 { 
 }; 
   return NewRegCourse; 
 } }  
    } 