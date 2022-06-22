using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace BtsSerinCookBook.CookBook.Forms
{
    [FormScript("CookBook.IngredientMeasures")]
    [BasedOnRow(typeof(IngredientMeasuresRow), CheckNames = true)]
    public class IngredientMeasuresForm
    {
        public string Name { get; set; }
    }
}