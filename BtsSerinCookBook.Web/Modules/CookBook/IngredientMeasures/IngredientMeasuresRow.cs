using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace BtsSerinCookBook.CookBook
{
    [ConnectionKey("Default"), Module("CookBook"), TableName("[CookBook].[IngredientMeasures]")]
    [DisplayName("Ingredient Measures"), InstanceName("Ingredient Measures")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript(Permission = "*")]
    public sealed class IngredientMeasuresRow : Row<IngredientMeasuresRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ingredient Measure Id"), Identity, IdProperty]
        public int? IngredientMeasureId
        {
            get => fields.IngredientMeasureId[this];
            set => fields.IngredientMeasureId[this] = value;
        }

        [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        public IngredientMeasuresRow()
            : base()
        {
        }

        public IngredientMeasuresRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IngredientMeasureId;
            public StringField Name;
        }
    }
}
