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
    
    public partial class Tb_Mechanism
    {
        public System.Guid MechanismID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid Creator { get; set; }
        public Nullable<System.DateTime> LastModiTime { get; set; }
        public Nullable<System.Guid> LastModifier { get; set; }
        public bool IsDel { get; set; }
        public string MechanismName { get; set; }
        public bool IsShares { get; set; }
        public Nullable<int> SharesNum { get; set; }
        public Nullable<System.DateTime> SetupTime { get; set; }
        public string Remark { get; set; }
        public Nullable<System.Guid> ParentBodyID { get; set; }
        public string ParentBody { get; set; }
        public Nullable<decimal> ParentHoldPercent { get; set; }
        public int ParentHoldCoun { get; set; }
        public int ClassLayer { get; set; }
        public bool IsSpecial { get; set; }
        public Nullable<System.Guid> StructureID { get; set; }
    }
}