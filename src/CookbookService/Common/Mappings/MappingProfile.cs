using AutoMapper;
using CookbookService.API.Access.Commands;
using CookbookService.API.DTO;
using CookbookService.Domain;

namespace CookbookService.API.Common.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<AddMenuCommand, MenuEntity>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<MenuDTO, MenuEntity>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<DayDTO, DayEntity>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<MealDTO, MealEntity>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<DishDTO, DishEntity>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<IngredientDTO, IngredientEntity>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));

			CreateMap<MenuEntity, MenuDTO>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<DayEntity, DayDTO>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<MealEntity, MealDTO>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<DishEntity, DishDTO>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
			CreateMap<IngredientEntity, IngredientDTO>()
				.ForAllMembers(o => o.Condition((src, dest, value) => value != null));
		}
	}
}
