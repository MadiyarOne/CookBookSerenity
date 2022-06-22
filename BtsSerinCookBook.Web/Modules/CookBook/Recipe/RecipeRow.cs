using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace BtsSerinCookBook.CookBook
{
    [ConnectionKey("Default"), Module("CookBook"), TableName("[CookBook].[Recipes]")]
    [DisplayName("Recipe"), InstanceName("Recipe")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecipeRow : Row<RecipeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Recipe Id"), Identity, IdProperty]
        public int? RecipeId
        {
            get => fields.RecipeId[this];
            set => fields.RecipeId[this] = value;
        }

        [DisplayName("Title"), Size(1024), NotNull, QuickSearch, NameProperty]
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Input Date Time"), NotNull]
        public DateTime? InputDateTime
        {
            get => fields.InputDateTime[this];
            set => fields.InputDateTime[this] = value;
        }

        [DisplayName("Description"), NotNull]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Photo Url"), ImageUploadEditor(FilenameFormat = "Recipe/Image/~"), Size(2048), NotNull]
        public string PhotoUrl
        {
            get => fields.PhotoUrl[this];
            set => fields.PhotoUrl[this] = value;
        }

        [DisplayName("Cook Description"), NotNull]
        public string CookDescription
        {
            get => fields.CookDescription[this];
            set => fields.CookDescription[this] = value;
        }
        
        [DisplayName("Recipe Ingredients")]
        [LookupEditor(typeof(RecipePartsRow), Multiple = true, InplaceAdd = true), NotMapped]
        [LinkingSetRelation(typeof(RecipeRecipePartsRow), "RecipeId", "RecipePartId")]
        public List<Int32> RecipePartList
        {
            get => fields.RecipePartList[this];
            set => fields.RecipePartList[this] = value;
        }

        public RecipeRow()
            : base()
        {
        }

        public RecipeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecipeId;
            public StringField Title;
            public DateTimeField InputDateTime;
            public StringField Description;
            public StringField PhotoUrl;
            public StringField CookDescription;
            public ListField<Int32> RecipePartList;
        }
    }
}
