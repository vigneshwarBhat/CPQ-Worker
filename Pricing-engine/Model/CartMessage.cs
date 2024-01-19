﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Pricing_Engine.Model
{
    public class CartMessage
    {
        public Guid CartId { get; set; }
        public Guid PriceListId { get; set; }
        public IEnumerable<CartItemRequest> CartItems { get; set; }
    }
    public class CartItemRequest
    {
        [Required]
        public Guid ItemId { get; set; }
        [Required]
        public bool IsPrimaryLine { get; set; }
        [Required]
        public LineType LineType { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        public string ExternalId { get; set; }
        [Required]
        public int PrimaryTaxLineNumber { get; set; }
        [Required]
        public Product Product { get; set; }

        [JsonIgnore]
        public Guid CartId { get; set; }

    }

    public enum LineType
    {
        None = 0,
        ProductService = 1
    }

    public class Product
    {

        [Required]
        public Guid Id { get; set; }
    }
}

