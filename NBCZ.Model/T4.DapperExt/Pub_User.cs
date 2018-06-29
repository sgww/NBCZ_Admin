//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2018-06-29 10:49:31
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using DapperExtensions.Mapper;
using Newtonsoft.Json;
namespace NBCZ.Model
{	
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Pub_User
    {
     		 /// <summary>
     	/// 自增主键
     	/// </summary>
        [JsonProperty]	
		public int Id { get; set; }

		 /// <summary>
     	/// 登录用户名
     	/// </summary>
        [JsonProperty]	
		public string UserCode { get; set; }

		 /// <summary>
     	/// 昵称/用户名
     	/// </summary>
        [JsonProperty]	
		public string UserName { get; set; }

		 /// <summary>
     	/// 真实姓名
     	/// </summary>
        [JsonProperty]	
		public string RealName { get; set; }

		 /// <summary>
     	/// 登录密码
     	/// </summary>
        [JsonProperty]	
		public string UserPwd { get; set; }

		 /// <summary>
     	/// 性别
     	/// </summary>
        [JsonProperty]	
		public bool Sex { get; set; }

		 /// <summary>
     	/// 身份证号码
     	/// </summary>
        [JsonProperty]	
		public string IdentityNo { get; set; }

		 /// <summary>
     	/// 生日
     	/// </summary>
        [JsonProperty]	
		public DateTime? Birthday { get; set; }

		 /// <summary>
     	/// 部门编号
     	/// </summary>
        [JsonProperty]	
		public string DeptCode { get; set; }

		 /// <summary>
     	/// 是否是管理员 默认不是 0  是1
     	/// </summary>
        [JsonProperty]	
		public bool ManagerFlag { get; set; }

		 /// <summary>
     	/// 电话
     	/// </summary>
        [JsonProperty]	
		public string Tel { get; set; }

		 /// <summary>
     	/// 邮箱
     	/// </summary>
        [JsonProperty]	
		public string EMail { get; set; }

		 /// <summary>
     	/// QQ
     	/// </summary>
        [JsonProperty]	
		public string QQ { get; set; }

		 /// <summary>
     	/// 备注
     	/// </summary>
        [JsonProperty]	
		public string Remark { get; set; }

		 /// <summary>
     	/// 停用状态 默认0 未停用 1停用
     	/// </summary>
        [JsonProperty]	
		public bool StopFlag { get; set; }

		 /// <summary>
     	/// 创建人
     	/// </summary>
        [JsonProperty]	
		public string Crid { get; set; }

		 /// <summary>
     	/// 创建时间
     	/// </summary>
        [JsonProperty]	
		public DateTime? Crdt { get; set; }

		 /// <summary>
     	/// 最后更新人
     	/// </summary>
        [JsonProperty]	
		public string Lmid { get; set; }

		 /// <summary>
     	/// 最后更新时间
     	/// </summary>
        [JsonProperty]	
		public DateTime? Lmdt { get; set; }

		 /// <summary>
     	/// 最后登录时间
     	/// </summary>
        [JsonProperty]	
		public DateTime? LoginDate { get; set; }

		 /// <summary>
     	/// 省份编号
     	/// </summary>
        [JsonProperty]	
		public string ProvinceCode { get; set; }

		 /// <summary>
     	/// 城市编号
     	/// </summary>
        [JsonProperty]	
		public string CityCode { get; set; }

		 /// <summary>
     	/// 区域编号
     	/// </summary>
        [JsonProperty]	
		public string RegionCode { get; set; }

		 /// <summary>
     	/// 地址
     	/// </summary>
        [JsonProperty]	
		public string UserAddress { get; set; }

		 /// <summary>
     	/// 微信openid
     	/// </summary>
        [JsonProperty]	
		public string Wxcode { get; set; }

		 /// <summary>
     	/// 头像地址
     	/// </summary>
        [JsonProperty]	
		public string HeadUrl { get; set; }

		   
    }
}

