﻿using LinCms.Zero.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinCms.Web.Models.v1.Comments
{
    public class CommentSearchDto:PageDto
    {
        public int? ArticleId { get; set; }
    }
}
