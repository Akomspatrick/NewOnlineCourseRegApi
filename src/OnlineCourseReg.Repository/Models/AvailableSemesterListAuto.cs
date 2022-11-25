 using System; 
 using System.Collections.Generic; 
 using System.Linq;
  using System.Text; 
 using System.Data.Common;
    
 namespace  OnlineCourseReg.Repository.Models 
 {  
[Serializable()] 
   public partial class  AvailableSemesterList :List<AvailableSemester>  
 { 
 public  AvailableSemester GetItemInList(  String CampId,String ProgId,String AsetId,String AsessionId,String SemesterId  )  
 { 
   AvailableSemester  NewAvailableSemester = new AvailableSemester(); 
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( CampId.ToString().Trim().ToUpper() == this[i].CampId.ToString().Trim().ToUpper() ) && ( ProgId.ToString().Trim().ToUpper() == this[i].ProgId.ToString().Trim().ToUpper() ) && ( AsetId.ToString().Trim().ToUpper() == this[i].AsetId.ToString().Trim().ToUpper() ) && ( AsessionId.ToString().Trim().ToUpper() == this[i].AsessionId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) )  
 { 
  NewAvailableSemester = this[i]; break ; 
 }  
 }  return  NewAvailableSemester;  
 } 
 public  bool  IsItemInList(  String CampId,String ProgId,String AsetId,String AsessionId,String SemesterId  )  
 { 
    bool  found= false;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( CampId.ToString().Trim().ToUpper() == this[i].CampId.ToString().Trim().ToUpper() ) && ( ProgId.ToString().Trim().ToUpper() == this[i].ProgId.ToString().Trim().ToUpper() ) && ( AsetId.ToString().Trim().ToUpper() == this[i].AsetId.ToString().Trim().ToUpper() ) && ( AsessionId.ToString().Trim().ToUpper() == this[i].AsessionId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) )  
 { 
  found= true;  break ; 
 }  
 }  return  found;  
 } 
 public  int ItemPositionInList(  String CampId,String ProgId,String AsetId,String AsessionId,String SemesterId  )  
 { 
     int Pos = -1;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( CampId.ToString().Trim().ToUpper() == this[i].CampId.ToString().Trim().ToUpper() ) && ( ProgId.ToString().Trim().ToUpper() == this[i].ProgId.ToString().Trim().ToUpper() ) && ( AsetId.ToString().Trim().ToUpper() == this[i].AsetId.ToString().Trim().ToUpper() ) && ( AsessionId.ToString().Trim().ToUpper() == this[i].AsessionId.ToString().Trim().ToUpper() ) && ( SemesterId.ToString().Trim().ToUpper() == this[i].SemesterId.ToString().Trim().ToUpper() ) )  
 { 
    Pos = i;  break ; 
 }  
 }  return  Pos;  
 } 
  }  
    } 