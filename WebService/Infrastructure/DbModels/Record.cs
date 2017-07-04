using System;
using System.Linq;
using System.Text;

namespace Infrastructure.DbModels
{
    ///<summary>
    ///
    ///</summary>
    public class Record
    {
           public Record(){

           }
           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:社保代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PersonalCode_Social {get;set;}

           /// <summary>
           /// Desc:身份证
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IdentityCard {get;set;}

           /// <summary>
           /// Desc:档案号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecordNum {get;set;}

           /// <summary>
           /// Desc:就业证编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EmploymentNum {get;set;}

           /// <summary>
           /// Desc:人员类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PersonType {get;set;}

           /// <summary>
           /// Desc:单位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyName {get;set;}

           /// <summary>
           /// Desc:劳动保障代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PersonalCode_Labor {get;set;}

           /// <summary>
           /// Desc:存档开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StartDate {get;set;}

           /// <summary>
           /// Desc:存档结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EndDate {get;set;}

           /// <summary>
           /// Desc:调整原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ChangeReason {get;set;}

           /// <summary>
           /// Desc:调出去向
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Target {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:经办机构
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperateCompany {get;set;}

           /// <summary>
           /// Desc:经办日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperateDate {get;set;}

           /// <summary>
           /// Desc:档案代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecordCode {get;set;}

           /// <summary>
           /// Desc:公司代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyCode {get;set;}

           /// <summary>
           /// Desc:标记1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark_1 {get;set;}

           /// <summary>
           /// Desc:标记2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark_2 {get;set;}

           /// <summary>
           /// Desc:辅编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SubRecordNum {get;set;}

           /// <summary>
           /// Desc:档案所在地
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecordLocation {get;set;}

           /// <summary>
           /// Desc:录用来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EmploySource {get;set;}

    }
}
