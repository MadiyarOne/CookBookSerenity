using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace BtsSerinCookBook.CookBook
{
    [ConnectionKey("Default"), Module("CookBook"), TableName("[CookBook].[RecipeParts]")]
    [DisplayName("Recipe Parts"), InstanceName("Recipe Parts")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript(Permission = "*")]

    public sealed class RecipePartsRow : Row<RecipePartsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Recipe Part Id"), Identity, IdProperty]
        public int? RecipePartId
        {
            get => fields.RecipePartId[this];
            set => fields.RecipePartId[this] = value;
        }

        [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }
        
        [DisplayName("Recipe Ingredients")]
        [LookupEditor(typeof(IngredientMeasuresRow), Multiple = true, InplaceAdd = true), NotMapped]
        [LinkingSetRelation(typeof(RecipePartIngredientMeasuresRow), "RecipeId", "IngredientMeasureId")]
        public List<Int32> RecipePartIngredientMeasureList
        {
            get => fields.RecipePartIngredientMeasureList[this];
            set => fields.RecipePartIngredientMeasureList[this] = value;
        }

        public RecipePartsRow()
            : base()
        {
        }

        public RecipePartsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecipePartId;
            public StringField Name;
            public ListField<Int32> RecipePartIngredientMeasureList;
        }
    }
}
