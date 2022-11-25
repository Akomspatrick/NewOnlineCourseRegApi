 using System; 
 using System.Collections.Generic; 
 using System.Linq;
  using System.Text; 
 using System.Data.Common;
    
 namespace  OnlineCourseReg.Repository.Models 
 {  
[Serializable()] 
   public partial class  OnlineResultList :List<OnlineResult>  
 { 
 public  OnlineResult GetItemInList(  String OnlineResultId  )  
 { 
   OnlineResult  NewOnlineResult = new OnlineResult(); 
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( OnlineResultId.ToString().Trim().ToUpper() == this[i].OnlineResultId.ToString().Trim().ToUpper() ) )  
 { 
  NewOnlineResult = this[i]; break ; 
 }  
 }  return  NewOnlineResult;  
 } 
 public  bool  IsItemInList(  String OnlineResultId  )  
 { 
    bool  found= false;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( OnlineResultId.ToString().Trim().ToUpper() == this[i].OnlineResultId.ToString().Trim().ToUpper() ) )  
 { 
  found= true;  break ; 
 }  
 }  return  found;  
 } 
 public  int ItemPositionInList(  String OnlineResultId  )  
 { 
     int Pos = -1;  
 for (int i =0 ; i < this.Count;++i)  
  { if (  ( OnlineResultId.ToString().Trim().ToUpper() == this[i].OnlineResultId.ToString().Trim().ToUpper() ) )  
 { 
    Pos = i;  break ; 
 }  
 }  return  Pos;  
 } 
  }  
    } 