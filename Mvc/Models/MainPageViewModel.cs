using Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace RadarcOnline.App.Presentation.Mvc.ViewModels
{
	public partial class MainPageViewModel
	{
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Continent", ResourceType=typeof(AppResources))]
		public string Continent { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Name", ResourceType=typeof(AppResources))]
		public string Name { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Instructions", ResourceType=typeof(AppResources))]
		public string Instructions { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Ingredients", ResourceType=typeof(AppResources))]
		public string Ingredients { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Image", ResourceType=typeof(AppResources))]
		public string Image { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Vegan", ResourceType=typeof(AppResources))]
		public bool Vegan { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Calories", ResourceType=typeof(AppResources))]
		public int Calories { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_PreparationTime", ResourceType=typeof(AppResources))]
		public int PreparationTime { get; set; }
		[Required(ErrorMessageResourceType=typeof(Shared), ErrorMessageResourceName="RequiredField")]
		[Display(Name="MainPageViewModel_Id", ResourceType=typeof(AppResources))]
		public string Id { get; set; }

		public virtual string IdentityDescription		
		{
			get
			{
				return this.Continent;
			}
		}
	}
}
