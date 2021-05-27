using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjProductSys.Models
{
    public class CategoryViewModel
    {
        public int 類別編號 { get; set; }
        public string 類別名稱 { get; set; }
        public string 編輯者 { get; set; }
        public string 建立日 { get; set; }
        public string 修改日 { get; set; }
    }
}