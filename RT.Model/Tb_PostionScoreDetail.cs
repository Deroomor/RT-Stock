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
    
    public partial class Tb_PostionScoreDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid PostionScoreId { get; set; }
        public int Score { get; set; }
        public int PositionFactor { get; set; }
        public System.DateTime CreateTime { get; set; }
        public bool IsDel { get; set; }
        public string PositionFactorItem { get; set; }
    }
}