using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace BtsSerinCookBook.CookBook.Columns
{
    [ColumnsScript("CookBook.IngredientMeasures")]
    [BasedOnRow(typeof(IngredientMeasuresRow), CheckNames = true)]
    public class IngredientMeasuresColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int IngredientMeasureId { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}