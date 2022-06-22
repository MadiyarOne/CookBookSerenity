using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace BtsSerinCookBook.CookBook
{
    [ConnectionKey("Default"), Module("CookBook"), TableName("[CookBook].[RecipePartIngredientMeasures]")]
    [DisplayName("Recipe Part Ingredient Measures"), InstanceName("Recipe Part Ingredient Measures")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecipePartIngredientMeasuresRow : Row<RecipePartIngredientMeasuresRow.RowFields>, IIdRow
    {
        [DisplayName("Recipe Ingredient Measure Id"), Identity, IdProperty]
        public int? RecipeIngredientMeasureId
        {
            get => fields.RecipeIngredientMeasureId[this];
            set => fields.RecipeIngredientMeasureId[this] = value;
        }

        [DisplayName("Recipe"), NotNull, ForeignKey("[CookBook].[RecipeParts]", "RecipePartId"), LeftJoin("jRecipe"), TextualField("RecipeName")]
        public int? RecipeId
        {
            get => fields.RecipeId[this];
            set => fields.RecipeId[this] = value;
        }

        [DisplayName("Ingredient Measure"), NotNull, ForeignKey("[CookBook].[IngredientMeasures]", "IngredientMeasureId"), LeftJoin("jIngredientMeasure"), TextualField("IngredientMeasureName")]
        public int? IngredientMeasureId
        {
            get => fields.IngredientMeasureId[this];
            set => fields.IngredientMeasureId[this] = value;
        }

        [DisplayName("Recipe Name"), Expression("jRecipe.[Name]")]
        public string RecipeName
        {
            get => fields.RecipeName[this];
            set => fields.RecipeName[this] = value;
        }

        [DisplayName("Ingredient Measure Name"), Expression("jIngredientMeasure.[Name]")]
        public string IngredientMeasureName
        {
            get => fields.IngredientMeasureName[this];
            set => fields.IngredientMeasureName[this] = value;
        }

        public RecipePartIngredientMeasuresRow()
            : base()
        {
        }

        public RecipePartIngredientMeasuresRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecipeIngredientMeasureId;
            public Int32Field RecipeId;
            public Int32Field IngredientMeasureId;

            public StringField RecipeName;

            public StringField IngredientMeasureName;
        }
    }
}
