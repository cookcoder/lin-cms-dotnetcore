﻿using System.ComponentModel.DataAnnotations;

namespace LinCms.Cms.Users
{
    public class UpdateProfileDto
    {
        [Required(ErrorMessage = "请输入昵称")]
        [StringLength(24, ErrorMessage = "昵称应在24个字符内")]
        public string Nickname { get; set; }
        [StringLength(100, ErrorMessage = "个人介绍应在100个字符内")]
        public string Introduction { get; set; }
        [StringLength(100, ErrorMessage = "博客应在100个字符内")]
        public string BlogAddress { get; set; }
    }
}
