 using System; 
 using System.Collections.Generic; 
 using System.Linq;
  using System.Text; 
 using System.Data.Common;
    
 namespace  OnlineCourseReg.Repository.Models 
 {  
[Serializable()] 
   public partial class  StudentList :List<Student>  
 { 
 public  Student GetItemInList(  String StudentId  )  
 { 
   Student  NewStudent = new Student(); 
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( StudentId.ToString().Trim().ToUpper() == this[i].StudentId.ToString().Trim().ToUpper() ) )  
 { 
  NewStudent = this[i]; break ; 
 }  
 }  return  NewStudent;  
 } 
 public  bool  IsItemInList(  String StudentId  )  
 { 
    bool  found= false;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( StudentId.ToString().Trim().ToUpper() == this[i].StudentId.ToString().Trim().ToUpper() ) )  
 { 
  found= true;  break ; 
 }  
 }  return  found;  
 } 
 public  int ItemPositionInList(  String StudentId  )  
 { 
     int Pos = -1;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( StudentId.ToString().Trim().ToUpper() == this[i].StudentId.ToString().Trim().ToUpper() ) )  
 { 
    Pos = i;  break ; 
 }  
 }  return  Pos;  
 } 
  }  
    } 