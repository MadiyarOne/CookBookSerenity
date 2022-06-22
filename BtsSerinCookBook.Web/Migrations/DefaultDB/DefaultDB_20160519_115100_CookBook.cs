using FluentMigrator;

namespace BtsSerinCookBook.Migrations.DefaultDB
{
    [Migration(20160519_115100)]
    public class DefaultDB_20160519_115100_CookBook : Migration
    {
        public override void Up()
        {
            Create.Schema("CookBook");

            Create.Table("Recipes").InSchema("CookBook")
                .WithColumn("RecipeId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(1024).NotNullable()
                .WithColumn("InputDateTime").AsDate().NotNullable()
                .WithColumn("Description").AsString(int.MaxValue).NotNullable()
                .WithColumn("PhotoUrl").AsString(2048).NotNullable()
                .WithColumn("CookDescription").AsString(int.MaxValue).NotNullable();

            Create.Table("RecipeParts").InSchema("CookBook")
                .WithColumn("RecipePartId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(int.MaxValue).NotNullable();

            Create.Table("IngredientMeasures").InSchema("CookBook")
                .WithColumn("IngredientMeasureId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(int.MaxValue).NotNullable();
            
            
            
            
            
            Create.Table("RecipeRecipeParts").InSchema("CookBook")
                .WithColumn("RecipeRecipePartId").AsInt32().Identity().PrimaryKey().NotNullable();

            Alter.Table("RecipeRecipeParts").InSchema("CookBook")
                .AddColumn("RecipeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK__RecipeRecipePart__RecipeId", "CookBook", "Recipes", "RecipeId")
                .AddColumn("RecipePartId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK__RecipeRecipeParts__RecipePartId", "CookBook", "RecipeParts",
                    "RecipePartId");
            
            
            

            Create.Table("RecipePartIngredientMeasures").InSchema("CookBook")
                .WithColumn("RecipeIngredientMeasureId").AsInt32().Identity().PrimaryKey().NotNullable();

            Alter.Table("RecipePartIngredientMeasures").InSchema("CookBook")
                .AddColumn("RecipeId")
                    .AsInt32()
                    .NotNullable()
                    .ForeignKey("FK__RecipeIngredientMeasure__RecipePartId", "CookBook", "RecipeParts", "RecipePartId")
                .AddColumn("IngredientMeasureId")
                    .AsInt32()
                    .NotNullable()
                    .ForeignKey("FK__RecipeIngredientMeasure__IngredientMeasureId", "CookBook", "IngredientMeasures",
                        "IngredientMeasureId");
        }

        public override void Down()
        {
        }
    }
}