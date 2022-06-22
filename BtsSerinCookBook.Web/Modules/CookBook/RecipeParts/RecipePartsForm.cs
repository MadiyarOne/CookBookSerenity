using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace BtsSerinCookBook.CookBook.Forms
{
    [FormScript("CookBook.RecipeParts")]
    [BasedOnRow(typeof(RecipePartsRow), CheckNames = true)]
    public class RecipePartsForm
    {
        public string Name { get; set; }
        public List<Int32> RecipePartIngredientMeasureList { get; set; }
    }
}