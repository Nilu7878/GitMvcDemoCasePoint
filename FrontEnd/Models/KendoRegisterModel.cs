using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class KendoRegisterModel
    {
         
    
      public int c_empid{get;set;}        
       public string? c_name{get;set;}
       public string? c_email{get;set;}
       public string? c_gender{get;set;}
       public int c_dob{get;set;}
       public string? c_hobby{get;set;}
       public string? c_password{get;set;}
       public string? c_photo{get;set;} 
       public int c_cityid {get;set;}
       public int c_departmentid {get;set;} 
    }
}