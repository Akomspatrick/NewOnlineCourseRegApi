 using System; 
 using System.Collections.Generic; 
 using System.Linq;
  using System.Text; 
 using System.Data.Common;
    
 namespace  OnlineCourseReg.Repository.Models 
 {  
[Serializable()] 
   public partial class  RegCourseList :List<RegCourse>  
 { 
 public  RegCourse GetItemInList(  String StudentId,String SemesterId  )  
 { 
   RegCourse  NewRegCourse = new RegCourse(); 
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( StudentId.ToString().Trim().ToUpper() == this[i].StudentId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) )  
 { 
  NewRegCourse = this[i]; break ; 
 }  
 }  return  NewRegCourse;  
 } 
 public  bool  IsItemInList(  String StudentId,String SemesterId  )  
 { 
    bool  found= false;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( StudentId.ToString().Trim().ToUpper() == this[i].StudentId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) )  
 { 
  found= true;  break ; 
 }  
 }  return  found;  
 } 
 public  int ItemPositionInList(  String StudentId,String SemesterId  )  
 { 
     int Pos = -1;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( StudentId.ToString().Trim().ToUpper() == this[i].StudentId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) )  
 { 
    Pos = i;  break ; 
 }  
 }  return  Pos;  
 } 
  }  
    } 