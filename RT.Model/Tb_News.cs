//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RT.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_News
    {
        public System.Guid NewID { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Source { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> ReleaseTime { get; set; }
        public Nullable<System.Guid> ReleaseUserID { get; set; }
        public Nullable<bool> ReleaseStatus { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> PageView { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid Creator { get; set; }
        public Nullable<System.DateTime> LastModiTime { get; set; }
        public Nullable<System.Guid> LastModifier { get; set; }
        public bool IsDel { get; set; }
    }
}
