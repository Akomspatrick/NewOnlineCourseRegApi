using System; 
using System.Collections.ObjectModel; 
using System.ComponentModel.DataAnnotations;

namespace  OnlineCourseReg.Repository.Models 
 { 
    public  partial class  Student : IEntity  
 { 
public Student(String StudentId, String CampId, String FacId, String DeptId, String ProgId, String ProgOptionId, String AsetId, String AsessionId, String Surname, String Middlename, String Firstname, String IDNo, String Astatus, String StateCode, String sex, String PresentState, Decimal TTNU, Decimal TTCP, Decimal FinalCGPA, String FinalClass, String CurrentLevel, String EntryLevel, String LocgCode, DateTime DateofBirth, String ModeOfEntry, String MaritalStatus, String Remark, String FormNo, String PhoneNo, String EmailAddress, String ContactAddress, String NextOfKin, String KinRelationShip, String KinAddress, String KinPhoneNo, String TheprogType, String CurrentSession, String ThePassword, DateTime PasswordDate, Guid StudentGUID, Int16 AdminBatchNo, String UsedCourses, String MainFeesType, String AsetCodeToUse  ) 
 { 
 myStudentId = StudentId ;
myCampId = CampId ;
myFacId = FacId ;
myDeptId = DeptId ;
myProgId = ProgId ;
myProgOptionId = ProgOptionId ;
myAsetId = AsetId ;
myAsessionId = AsessionId ;
mySurname = Surname ;
myMiddlename = Middlename ;
myFirstname = Firstname ;
myIDNo = IDNo ;
myAstatus = Astatus ;
myStateCode = StateCode ;
mysex = sex ;
myPresentState = PresentState ;
myTTNU = TTNU ;
myTTCP = TTCP ;
myFinalCGPA = FinalCGPA ;
myFinalClass = FinalClass ;
myCurrentLevel = CurrentLevel ;
myEntryLevel = EntryLevel ;
myLocgCode = LocgCode ;
myDateofBirth = DateofBirth ;
myModeOfEntry = ModeOfEntry ;
myMaritalStatus = MaritalStatus ;
myRemark = Remark ;
myFormNo = FormNo ;
myPhoneNo = PhoneNo ;
myEmailAddress = EmailAddress ;
myContactAddress = ContactAddress ;
myNextOfKin = NextOfKin ;
myKinRelationShip = KinRelationShip ;
myKinAddress = KinAddress ;
myKinPhoneNo = KinPhoneNo ;
myTheprogType = TheprogType ;
myCurrentSession = CurrentSession ;
myThePassword = ThePassword ;
myPasswordDate = PasswordDate ;
myStudentGUID = StudentGUID ;
myAdminBatchNo = AdminBatchNo ;
myUsedCourses = UsedCourses ;
myMainFeesType = MainFeesType ;
myAsetCodeToUse = AsetCodeToUse ;

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
 
 private  String myIDNo; 
 [MaxLength(20)]
 public    String IDNo
 { get { return myIDNo ;} 
   set { 
  
 myIDNo  = value; 
 
 }
} 
 
 private  String myAstatus; 
 [MaxLength(20)]
 public    String Astatus
 { get { return myAstatus ;} 
   set { 
  
 myAstatus  = value; 
 
 }
} 
 
 private  String myStateCode; 
 [MaxLength(30)]
 public    String StateCode
 { get { return myStateCode ;} 
   set { 
  
 myStateCode  = value; 
 
 }
} 
 
 private  String mysex; 
 [MaxLength(6)]
 public    String sex
 { get { return mysex ;} 
   set { 
  
 mysex  = value; 
 
 }
} 
 
 private  String myPresentState; 
 [MaxLength(15)]
 public    String PresentState
 { get { return myPresentState ;} 
   set { 
  
 myPresentState  = value; 
 
 }
} 
 
 private  Decimal myTTNU; 
 public    Decimal TTNU
 { get { return myTTNU ;} 
   set { 
  
 myTTNU  = value; 
 
 }
} 
 
 private  Decimal myTTCP; 
 public    Decimal TTCP
 { get { return myTTCP ;} 
   set { 
  
 myTTCP  = value; 
 
 }
} 
 
 private  Decimal myFinalCGPA; 
 public    Decimal FinalCGPA
 { get { return myFinalCGPA ;} 
   set { 
  
 myFinalCGPA  = value; 
 
 }
} 
 
 private  String myFinalClass; 
 [MaxLength(30)]
 public    String FinalClass
 { get { return myFinalClass ;} 
   set { 
  
 myFinalClass  = value; 
 
 }
} 
 
 private  String myCurrentLevel; 
 [MaxLength(10)]
 public    String CurrentLevel
 { get { return myCurrentLevel ;} 
   set { 
  
 myCurrentLevel  = value; 
 
 }
} 
 
 private  String myEntryLevel; 
 [MaxLength(10)]
 public    String EntryLevel
 { get { return myEntryLevel ;} 
   set { 
  
 myEntryLevel  = value; 
 
 }
} 
 
 private  String myLocgCode; 
 [MaxLength(30)]
 public    String LocgCode
 { get { return myLocgCode ;} 
   set { 
  
 myLocgCode  = value; 
 
 }
} 
 
 private  DateTime myDateofBirth; 
 public    DateTime DateofBirth
 { get { return myDateofBirth ;} 
   set { 
  
 myDateofBirth  = value; 
 
 }
} 
 
 private  String myModeOfEntry; 
 [MaxLength(10)]
 public    String ModeOfEntry
 { get { return myModeOfEntry ;} 
   set { 
  
 myModeOfEntry  = value; 
 
 }
} 
 
 private  String myMaritalStatus; 
 [MaxLength(30)]
 public    String MaritalStatus
 { get { return myMaritalStatus ;} 
   set { 
  
 myMaritalStatus  = value; 
 
 }
} 
 
 private  String myRemark; 
 [MaxLength(30)]
 public    String Remark
 { get { return myRemark ;} 
   set { 
  
 myRemark  = value; 
 
 }
} 
 
 private  String myFormNo; 
 [MaxLength(20)]
 public    String FormNo
 { get { return myFormNo ;} 
   set { 
  
 myFormNo  = value; 
 
 }
} 
 
 private  String myPhoneNo; 
 [MaxLength(30)]
 public    String PhoneNo
 { get { return myPhoneNo ;} 
   set { 
  
 myPhoneNo  = value; 
 
 }
} 
 
 private  String myEmailAddress; 
 [MaxLength(40)]
 public    String EmailAddress
 { get { return myEmailAddress ;} 
   set { 
  
 myEmailAddress  = value; 
 
 }
} 
 
 private  String myContactAddress; 
 [MaxLength(100)]
 public    String ContactAddress
 { get { return myContactAddress ;} 
   set { 
  
 myContactAddress  = value; 
 
 }
} 
 
 private  String myNextOfKin; 
 [MaxLength(100)]
 public    String NextOfKin
 { get { return myNextOfKin ;} 
   set { 
  
 myNextOfKin  = value; 
 
 }
} 
 
 private  String myKinRelationShip; 
 [MaxLength(30)]
 public    String KinRelationShip
 { get { return myKinRelationShip ;} 
   set { 
  
 myKinRelationShip  = value; 
 
 }
} 
 
 private  String myKinAddress; 
 [MaxLength(30)]
 public    String KinAddress
 { get { return myKinAddress ;} 
   set { 
  
 myKinAddress  = value; 
 
 }
} 
 
 private  String myKinPhoneNo; 
 [MaxLength(30)]
 public    String KinPhoneNo
 { get { return myKinPhoneNo ;} 
   set { 
  
 myKinPhoneNo  = value; 
 
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
 
 private  String myCurrentSession; 
 [MaxLength(9)]
 public    String CurrentSession
 { get { return myCurrentSession ;} 
   set { 
  
 myCurrentSession  = value; 
 
 }
} 
 
 private  String myThePassword; 
 [MaxLength(20)]
 public    String ThePassword
 { get { return myThePassword ;} 
   set { 
  
 myThePassword  = value; 
 
 }
} 
 
 private  DateTime myPasswordDate; 
 public    DateTime PasswordDate
 { get { return myPasswordDate ;} 
   set { 
  
 myPasswordDate  = value; 
 
 }
} 
 
 private  Guid myStudentGUID; 
 public    Guid StudentGUID
 { get { return myStudentGUID ;} 
   set { 
  
 myStudentGUID  = value; 
 
 }
} 
 
 private  Int16 myAdminBatchNo; 
 public    Int16 AdminBatchNo
 { get { return myAdminBatchNo ;} 
   set { 
  
 myAdminBatchNo  = value; 
 
 }
} 
 
 private  String myUsedCourses; 
 [MaxLength(50)]
 public    String UsedCourses
 { get { return myUsedCourses ;} 
   set { 
  
 myUsedCourses  = value; 
 
 }
} 
 
 private  String myMainFeesType; 
 [MaxLength(10)]
 public    String MainFeesType
 { get { return myMainFeesType ;} 
   set { 
  
 myMainFeesType  = value; 
 
 }
} 
 
 private  String myAsetCodeToUse; 
 [MaxLength(9)]
 public    String AsetCodeToUse
 { get { return myAsetCodeToUse ;} 
   set { 
  
 myAsetCodeToUse  = value; 
 
 }
} 
 

 public Student() 
 { } 
  
 public static Student  Create() 
 { 
   Student  NewStudent = new Student
 { 
 }; 
   return NewStudent; 
 } }  
    } 