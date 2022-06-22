using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace BtsSerinCookBook.CookBook.Columns
{
    [ColumnsScript("CookBook.Recipe")]
    [BasedOnRow(typeof(RecipeRow), CheckNames = true)]
    public class RecipeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int RecipeId { get; set; }
        [EditLink]
        public string Title { get; set; }
        public DateTime InputDateTime { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public string CookDescription { get; set; }
    }
}