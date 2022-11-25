 using System; 
 using System.Collections.Generic; 
 using System.Linq;
  using System.Text; 
 using System.Data.Common;
    
 namespace  OnlineCourseReg.Repository.Models 
 {  
[Serializable()] 
   public partial class  CourseList :List<Course>  
 { 
 public  Course GetItemInList(  String CampId,String FacId,String DeptId,String ProgId,String ProgOptionId,String AsetId,String AsessionId,String SemesterId,String CourseId  )  
 { 
   Course  NewCourse = new Course(); 
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( CampId.ToString().Trim().ToUpper() == this[i].CampId.ToString().Trim().ToUpper() ) && ( FacId.ToString().Trim().ToUpper() == this[i].FacId.ToString().Trim().ToUpper() ) && ( DeptId.ToString().Trim().ToUpper() == this[i].DeptId.ToString().Trim().ToUpper() ) && ( ProgId.ToString().Trim().ToUpper() == this[i].ProgId.ToString().Trim().ToUpper() ) && ( ProgOptionId.ToString().Trim().ToUpper() == this[i].ProgOptionId.ToString().Trim().ToUpper() ) && ( AsetId.ToString().Trim().ToUpper() == this[i].AsetId.ToString().Trim().ToUpper() ) && ( AsessionId.ToString().Trim().ToUpper() == this[i].AsessionId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) && ( CourseId.ToString().Trim().ToUpper() == this[i].CourseId.ToString().Trim().ToUpper() ) )  
 { 
  NewCourse = this[i]; break ; 
 }  
 }  return  NewCourse;  
 } 
 public  bool  IsItemInList(  String CampId,String FacId,String DeptId,String ProgId,String ProgOptionId,String AsetId,String AsessionId,String SemesterId,String CourseId  )  
 { 
    bool  found= false;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( CampId.ToString().Trim().ToUpper() == this[i].CampId.ToString().Trim().ToUpper() ) && ( FacId.ToString().Trim().ToUpper() == this[i].FacId.ToString().Trim().ToUpper() ) && ( DeptId.ToString().Trim().ToUpper() == this[i].DeptId.ToString().Trim().ToUpper() ) && ( ProgId.ToString().Trim().ToUpper() == this[i].ProgId.ToString().Trim().ToUpper() ) && ( ProgOptionId.ToString().Trim().ToUpper() == this[i].ProgOptionId.ToString().Trim().ToUpper() ) && ( AsetId.ToString().Trim().ToUpper() == this[i].AsetId.ToString().Trim().ToUpper() ) && ( AsessionId.ToString().Trim().ToUpper() == this[i].AsessionId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) && ( CourseId.ToString().Trim().ToUpper() == this[i].CourseId.ToString().Trim().ToUpper() ) )  
 { 
  found= true;  break ; 
 }  
 }  return  found;  
 } 
 public  int ItemPositionInList(  String CampId,String FacId,String DeptId,String ProgId,String ProgOptionId,String AsetId,String AsessionId,String SemesterId,String CourseId  )  
 { 
     int Pos = -1;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( CampId.ToString().Trim().ToUpper() == this[i].CampId.ToString().Trim().ToUpper() ) && ( FacId.ToString().Trim().ToUpper() == this[i].FacId.ToString().Trim().ToUpper() ) && ( DeptId.ToString().Trim().ToUpper() == this[i].DeptId.ToString().Trim().ToUpper() ) && ( ProgId.ToString().Trim().ToUpper() == this[i].ProgId.ToString().Trim().ToUpper() ) && ( ProgOptionId.ToString().Trim().ToUpper() == this[i].ProgOptionId.ToString().Trim().ToUpper() ) && ( AsetId.ToString().Trim().ToUpper() == this[i].AsetId.ToString().Trim().ToUpper() ) && ( AsessionId.ToString().Trim().ToUpper() == this[i].AsessionId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) && ( CourseId.ToString().Trim().ToUpper() == this[i].CourseId.ToString().Trim().ToUpper() ) )  
 { 
    Pos = i;  break ; 
 }  
 }  return  Pos;  
 } 
  }  
    } 