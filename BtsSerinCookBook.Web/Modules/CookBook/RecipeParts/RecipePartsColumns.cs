using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace BtsSerinCookBook.CookBook.Columns
{
    [ColumnsScript("CookBook.RecipeParts")]
    [BasedOnRow(typeof(RecipePartsRow), CheckNames = true)]
    public class RecipePartsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int RecipePartId { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}