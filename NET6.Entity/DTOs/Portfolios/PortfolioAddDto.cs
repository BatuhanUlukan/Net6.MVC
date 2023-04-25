﻿using Microsoft.AspNetCore.Http;

using NET6.Entity.DTOs.Categories;
using NET6.Entity.DTOs.Links;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;

namespace NET6.Entity.DTOs.Portfolios
{
    public class PortfolioAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SeoId { get; set; }
        public IList<SeoDto> Seos { get; set; }
        public Seo Seo { get; set; }
        public IFormFile Photo { get; set; }
        public Guid LinkId { get; set; }
        public IList<LinkDto> Links { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}
