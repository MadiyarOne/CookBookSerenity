using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace BtsSerinCookBook.CookBook
{
    [ConnectionKey("Default"), Module("CookBook"), TableName("[CookBook].[RecipeRecipeParts]")]
    [DisplayName("Recipe Recipe Parts"), InstanceName("Recipe Recipe Parts")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecipeRecipePartsRow : Row<RecipeRecipePartsRow.RowFields>, IIdRow
    {
        [DisplayName("Recipe Recipe Part Id"), Identity, IdProperty]
        public int? RecipeRecipePartId
        {
            get => fields.RecipeRecipePartId[this];
            set => fields.RecipeRecipePartId[this] = value;
        }

        [DisplayName("Recipe"), NotNull, ForeignKey("[CookBook].[Recipes]", "RecipeId"), LeftJoin("jRecipe"), TextualField("RecipeTitle")]
        public int? RecipeId
        {
            get => fields.RecipeId[this];
            set => fields.RecipeId[this] = value;
        }

        [DisplayName("Recipe Part"), NotNull, ForeignKey("[CookBook].[RecipeParts]", "RecipePartId"), LeftJoin("jRecipePart"), TextualField("RecipePartName")]
        public int? RecipePartId
        {
            get => fields.RecipePartId[this];
            set => fields.RecipePartId[this] = value;
        }

        [DisplayName("Recipe Title"), Expression("jRecipe.[Title]")]
        public string RecipeTitle
        {
            get => fields.RecipeTitle[this];
            set => fields.RecipeTitle[this] = value;
        }

        [DisplayName("Recipe Input Date Time"), Expression("jRecipe.[InputDateTime]")]
        public DateTime? RecipeInputDateTime
        {
            get => fields.RecipeInputDateTime[this];
            set => fields.RecipeInputDateTime[this] = value;
        }

        [DisplayName("Recipe Description"), Expression("jRecipe.[Description]")]
        public string RecipeDescription
        {
            get => fields.RecipeDescription[this];
            set => fields.RecipeDescription[this] = value;
        }

        [DisplayName("Recipe Photo Url"), Expression("jRecipe.[PhotoUrl]")]
        public string RecipePhotoUrl
        {
            get => fields.RecipePhotoUrl[this];
            set => fields.RecipePhotoUrl[this] = value;
        }

        [DisplayName("Recipe Cook Description"), Expression("jRecipe.[CookDescription]")]
        public string RecipeCookDescription
        {
            get => fields.RecipeCookDescription[this];
            set => fields.RecipeCookDescription[this] = value;
        }

        [DisplayName("Recipe Part Name"), Expression("jRecipePart.[Name]")]
        public string RecipePartName
        {
            get => fields.RecipePartName[this];
            set => fields.RecipePartName[this] = value;
        }

        public RecipeRecipePartsRow()
            : base()
        {
        }

        public RecipeRecipePartsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecipeRecipePartId;
            public Int32Field RecipeId;
            public Int32Field RecipePartId;

            public StringField RecipeTitle;
            public DateTimeField RecipeInputDateTime;
            public StringField RecipeDescription;
            public StringField RecipePhotoUrl;
            public StringField RecipeCookDescription;

            public StringField RecipePartName;
        }
    }
}
