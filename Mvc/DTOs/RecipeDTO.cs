using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Configuration;

namespace RadarcOnline.App.DTO
{
	public class RecipeDTO : RecipeDTOBase
	{
		// Add your custom members here
	}

	public abstract class RecipeDTOBase
	{
		
		private string continent;
		
		public string Continent
		{ 
			get
			{
				return this.continent;
			}

			set
			{
				if(value != this.continent)
				{
					this.continent = value;					
				}
			} 
		}
		
		private string name;
		
		public string Name
		{ 
			get
			{
				return this.name;
			}

			set
			{
				if(value != this.name)
				{
					this.name = value;					
				}
			} 
		}
		
		private string instructions;
		
		public string Instructions
		{ 
			get
			{
				return this.instructions;
			}

			set
			{
				if(value != this.instructions)
				{
					this.instructions = value;					
				}
			} 
		}
		
		private string ingredients;
		
		public string Ingredients
		{ 
			get
			{
				return this.ingredients;
			}

			set
			{
				if(value != this.ingredients)
				{
					this.ingredients = value;					
				}
			} 
		}
		
		private string image;
		
		public string Image
		{ 
			get
			{
				return this.image;
			}

			set
			{
				if(value != this.image)
				{
					this.image = value;					
				}
			} 
		}
		
		private bool vegan;
		
		public bool Vegan
		{ 
			get
			{
				return this.vegan;
			}

			set
			{
				if(value != this.vegan)
				{
					this.vegan = value;					
				}
			} 
		}
		
		private int calories;
		
		public int Calories
		{ 
			get
			{
				return this.calories;
			}

			set
			{
				if(value != this.calories)
				{
					this.calories = value;					
				}
			} 
		}
		
		private int preparationTime;
		
		public int PreparationTime
		{ 
			get
			{
				return this.preparationTime;
			}

			set
			{
				if(value != this.preparationTime)
				{
					this.preparationTime = value;					
				}
			} 
		}
		
		private string id;
		
		public string Id
		{ 
			get
			{
				return this.id;
			}

			set
			{
				if(value != this.id)
				{
					this.id = value;					
				}
			} 
		}
	}
}
