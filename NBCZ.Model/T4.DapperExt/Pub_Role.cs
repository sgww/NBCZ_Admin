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
    public partial class Pub_Role
    {
     		 /// <summary>
     	/// 
     	/// </summary>
        [JsonProperty]	
		public int Id { get; set; }

		 /// <summary>
     	/// 角色编号
     	/// </summary>
        [JsonProperty]	
		public string RoleCode { get; set; }

		 /// <summary>
     	/// 角色名称
     	/// </summary>
        [JsonProperty]	
		public string RoleName { get; set; }

		 /// <summary>
     	/// 备注
     	/// </summary>
        [JsonProperty]	
		public string Remark { get; set; }

		 /// <summary>
     	/// 停用状态 默认0  未停用 1 停用
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

		   
    }
}

