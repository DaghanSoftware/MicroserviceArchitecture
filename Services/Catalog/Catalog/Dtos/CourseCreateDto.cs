﻿namespace Catalog.Dtos
{
    public class CourseCreateDto
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public FeatureDto Feature { get; set; }
    }
}
