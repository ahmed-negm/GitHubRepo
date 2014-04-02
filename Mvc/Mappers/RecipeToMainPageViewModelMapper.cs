using RadarcOnline.App.DTO;
using RadarcOnline.App.Presentation.Mvc.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace RadarcOnline.App.Presentation.Mvc.Mappers
{
	public partial class RecipeToMainPageViewModelMapper : RecipeToMainPageViewModelMapperBase
	{
		private static RecipeToMainPageViewModelMapper mapper;

		public static RecipeToMainPageViewModelMapper Mapper
		{
			get
			{
				if(null == mapper)
				{
					mapper = new RecipeToMainPageViewModelMapper();
				}

				return mapper;
			}
		}	
	}

	public abstract class RecipeToMainPageViewModelMapperBase
	{
		public virtual void PostMap(MainPageViewModel mainPageViewModel)
		{
		}

		public virtual void PreMap(MainPageViewModel mainPageViewModel, RecipeDTO recipeDTO)
		{
		}

		public virtual MainPageViewModel Map(RecipeDTO recipeDTO)
		{
			MainPageViewModel mainPageViewModel = new MainPageViewModel();
			this.PreMap(mainPageViewModel, recipeDTO);
			mainPageViewModel.Continent = recipeDTO.Continent;
			mainPageViewModel.Name = recipeDTO.Name;
			mainPageViewModel.Instructions = recipeDTO.Instructions;
			mainPageViewModel.Ingredients = recipeDTO.Ingredients;
			mainPageViewModel.Image = recipeDTO.Image;
			mainPageViewModel.Vegan = recipeDTO.Vegan;
			mainPageViewModel.Calories = recipeDTO.Calories;
			mainPageViewModel.PreparationTime = recipeDTO.PreparationTime;
			mainPageViewModel.Id = recipeDTO.Id;
			this.PostMap(mainPageViewModel);
			return mainPageViewModel;
		}

		public virtual IEnumerable<MainPageViewModel> Map(IEnumerable<RecipeDTO> recipeDTOs)
		{
			return recipeDTOs.Select(Map);
		}
	}
}
