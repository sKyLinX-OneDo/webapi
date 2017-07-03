using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SqlSugar;

namespace Infrastructure.DbModels
{
    /// <summary>
    /// 数据库模型 通过Attribute控制数据库表与对象关系映射
    /// </summary>
    [SugarTable("Record")]
    public class Archives
    {
        public string Name { get; set; }

        [SugarColumn(ColumnName="IdentityCard")]
        public string ID { get; set; }

        [SugarColumn(ColumnName = "PersonalCode_Social")]
        public string SocialCode { get; set; }

        public string CompanyName { get; set; }

        [SugarColumn(ColumnName ="Remark_1")]
        public string Remark { get; set; }

    }
}