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
    
    public partial class Tb_Company
    {
        public System.Guid EnterpriseID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid Creator { get; set; }
        public Nullable<System.DateTime> LastModiTime { get; set; }
        public Nullable<System.Guid> LastModifier { get; set; }
        public bool IsDel { get; set; }
        public string EnterpriseName { get; set; }
        public string LegalPerson { get; set; }
        public string Industry { get; set; }
        public string CompanyType { get; set; }
        public string EnterpriseType { get; set; }
        public string CompanyAttribute { get; set; }
        public Nullable<System.DateTime> SetUpTime { get; set; }
        public bool IsFamily { get; set; }
        public Nullable<decimal> RegisterCapital { get; set; }
        public Nullable<decimal> SaleCapital { get; set; }
        public Nullable<int> CompanyScale { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyNo { get; set; }
    }
}
