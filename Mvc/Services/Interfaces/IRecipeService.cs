using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;
using RadarcOnline.App.DTO;

namespace RadarcOnline.App.Services
{
    public partial interface IRecipeService
    {
        RecipeDTO Find(string id);
		List<RecipeDTO> FindAll();
		List<RecipeDTO> Search(string searchValue);
        List<RecipeDTO> Search(string searchValue, int pageIndex, int pageSize);
        List<RecipeDTO> Search(string searchValue, string orderBy);
        List<RecipeDTO> Search(string searchValue, string orderBy, int pageIndex, int pageSize);
        List<RecipeDTO> Search(string searchValue, string orderBy = "", bool ascending = true, int pageIndex = 0, int pageSize = 10);
        int SearchCount(string searchValue);
    }
}
