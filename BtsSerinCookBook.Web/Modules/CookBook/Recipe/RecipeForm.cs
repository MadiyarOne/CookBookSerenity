using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace BtsSerinCookBook.CookBook.Forms
{
    [FormScript("CookBook.Recipe")]
    [BasedOnRow(typeof(RecipeRow), CheckNames = true)]
    public class RecipeForm
    {
        public string Title { get; set; }
        public DateTime InputDateTime { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        [TextAreaEditor(Rows = 8)]
        public string CookDescription { get; set; }
        public List<Int32> RecipePartList { get; set; }
    }
}