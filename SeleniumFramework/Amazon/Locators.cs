﻿namespace SeleniumFramework.Amazon
{
    public static class Locators
    {
        public static class ProductSearch
        {
            public static readonly string SearchInput = "//input[@id='twotabsearchtextbox']";
            public static readonly string AutocompleteResult = "//div[@class='s-suggestion-container']";
            public static readonly string FirstAutocompleteResult = "//*[@id='nav-flyout-searchAjax']/div[2]/div/div[1]/div[1]/div/div";
            public static readonly string SearchResultItem = "//div[@data-component-type='s-search-result']";
        }
        public static class ProductDetails
        {
            public static readonly string AllLinkLocator = "//a[@id='nav-hamburger-menu']";
            public static readonly string ComputersCategoryLocator = "//*[@id='hmenu-content']/ul[1]/li[8]/a";
            public static readonly string MonitorsCategoryLocator = "//*[@id='hmenu-content']/ul[6]/li[9]";
            public static readonly string FirstProductLocator = "//*[@id='search']/div[1]/div[1]/div/span[1]/div[1]/div[5]";
            public static readonly string ProductTitleLocator = "//span[@id='productTitle']";
        }

    }
}