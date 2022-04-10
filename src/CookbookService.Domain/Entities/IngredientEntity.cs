﻿using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class IngredientEntity : BaseEntity, IIngredient
	{
		public string Name { get; set; }
		public int Amount { get; set; }
		public string Measure { get; set; }
		public int Count { get; set; }
	}
}
