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
    
    public partial class Tb_Quota
    {
        public System.Guid PrimaryID { get; set; }
        public Nullable<System.Guid> QuotaID { get; set; }
        public Nullable<System.Guid> MeasureID { get; set; }
        public string QuotaName { get; set; }
        public string QuotaValue { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid Creator { get; set; }
        public Nullable<System.DateTime> LastModiTime { get; set; }
        public Nullable<System.Guid> LastModifier { get; set; }
        public bool IsDel { get; set; }
        public int QuotaType { get; set; }
    }
}
