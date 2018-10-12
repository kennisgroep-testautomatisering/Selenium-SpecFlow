﻿using OpenQA.Selenium;

namespace specFlowSeleniumGamersPlaza.Pages
{
    public partial class CategoryPage : BasePage
    {
        static IWebElement SubCategorySection { get { return driver.FindElement(By.Id("subcategories")); } }
        static IWebElement MusicGamesSubCategory { get { return SubCategorySection.FindElement(By.LinkText("Music Games")); } }
        static IWebElement correctProduct { get { return driver.FindElement(By.CssSelector(".ajax_block_product.first_item.item")); } }
        static IWebElement correctOrderButton { get { return correctProduct.FindElement(By.CssSelector(" .button.ajax_add_to_cart_button.exclusive")); } }
        static IWebElement shoppingCartProducts { get { return driver.FindElement(By.CssSelector("#cart_block_list [id^='cart_block_product']")); } }
        static IWebElement Guitarhero { get { return shoppingCartProducts.FindElement(By.LinkText("Guitar Hero...")); } }
    }
}