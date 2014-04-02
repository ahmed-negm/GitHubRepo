using RadarcOnline.App.Presentation.Mvc.Extensions.ActionResults;
using RadarcOnline.App.Presentation.Mvc.Extensions.Controllers;
using RadarcOnline.App.Presentation.Mvc.Extensions.Helpers;
using RadarcOnline.App.Presentation.Mvc.Models.Shared;
using RadarcOnline.App.Presentation.Mvc.Mappers;
using RadarcOnline.App.Presentation.Mvc.ViewModels;
using RadarcOnline.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RadarcOnline.App.Presentation.Mvc.Controllers
{
	public partial class RecipeController : RecipeControllerBase
	{
		partial void Init();
		public RecipeController(IRecipeService recipeService)
			: base(recipeService)
		{
			Init();
		}
	}
	
	public partial class RecipeControllerBase : BaseController
	{
		#region Members

        protected IRecipeService recipeService;

        #endregion

		#region Constructors

        public RecipeControllerBase(IRecipeService recipeService)
        {
            this.recipeService = recipeService;            
        }	

        #endregion
		#region Action Methods
		public virtual ActionResult MainPage()
		{
			MainPageViewModel viewModel = new MainPageViewModel();
			ViewBag.PageIndex = this.GetPageIndex();
            ViewBag.PageSize = this.GetPageSize();
			ViewBag.SearchValue = this.GetSearchValue();
		
			return View(viewModel);
		}

		[HttpPost]
        public ActionResult MainPage(GridRequestViewModel gridRequest)
        {
			var searchList = this.recipeService.Search(gridRequest.Search, 
                                                        gridRequest.SortColumnName, 
                                                        gridRequest.SortDirection == SortDirection.Ascending, 
                                                        GetGridStartIndex(gridRequest), 
                                                        gridRequest.RowCount);
			var mappedSearchList = RecipeToMainPageViewModelMapper.Mapper.Map(searchList);

            var displayRecords = this.recipeService.SearchCount(gridRequest.Search);
            var totalRecords = string.IsNullOrEmpty(gridRequest.Search)? displayRecords: recipeService.SearchCount(null);

         
			var dateFormat = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en" ? "MM/dd/yyyy" : "dd/MM/yyyy";
			System.Globalization.DateTimeFormatInfo dtfi = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
            dtfi.DateSeparator = "/";

            return Json(new
            {
                iTotalDisplayRecords = displayRecords,
                iTotalRecords = totalRecords,
                sEcho = gridRequest.GridCustomData,
                aaData = mappedSearchList.Select(d => new { d.Continent, d.Name, d.Instructions, d.Ingredients, d.Image, d.Vegan, d.Calories, d.PreparationTime, d.Id })
            });
        }
		
		public virtual ActionResult ReportMainPage()
        {
            var mainPageViewModelList = this.recipeService.Search(this.GetSearchValue());            
			var mappedList = RecipeToMainPageViewModelMapper.Mapper.Map(mainPageViewModelList);

            return new CsvReportResult("Main page", mappedList);
        }

		#endregion
	}
}
