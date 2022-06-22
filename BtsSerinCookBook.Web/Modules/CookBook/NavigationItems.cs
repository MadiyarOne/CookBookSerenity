using BtsSerinCookBook.CookBook.Pages;
using Serenity.Navigation;

[assembly: NavigationMenu(1000, "CookBook", icon: "fa-book")]
[assembly: NavigationLink(1100, "CookBook/Recipe", typeof(RecipeController), icon: "fa-file")]