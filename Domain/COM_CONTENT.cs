//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class COM_CONTENT
    {
        public int ID { get; set; }
        public string FK_RELATIONID { get; set; }
        public string CONTENT { get; set; }
        public byte[] CONTENTBLOB { get; set; }
        public string FK_TABLE { get; set; }
        public System.DateTime CREATEDATE { get; set; }
    }
}
