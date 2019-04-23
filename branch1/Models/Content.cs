using System;

namespace MvcAppDemo.Models
{
    public class Content
    {
        //主键
        public int Id {get;set;}
        public string title{get;set;}
        public string content{get;set;}
        public int status{get;set;}
        public DateTime add_time{get;set;}
        public DateTime modify_time{get;set;}
    }
}
