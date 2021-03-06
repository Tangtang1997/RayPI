﻿using System;
using MediatR;

namespace RayPI.AppService.Article.Dtos
{
    public class CreateArticleDto : IRequest<Guid>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 副标题
        /// </summary>
        public string SubTitle { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
