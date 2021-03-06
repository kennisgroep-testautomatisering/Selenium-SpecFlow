﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow2.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Order Feature")]
    public partial class OrderFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Order Feature", "As a user I want to be able to login on the webshop and place an order", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login as registered user")]
        public virtual void LoginAsRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login as registered user", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
testRunner.Given("the user is on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
testRunner.When("the user navigates to the loginpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
testRunner.And("the user enters correct username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.And("the user enters correct password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.And("the user clicks on the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("the user is succesfully logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.And("the user navigates to Nintendo Wii Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.And("the user navigates to Music Games Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.And("the user clicks on order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.Then("Product is added to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
