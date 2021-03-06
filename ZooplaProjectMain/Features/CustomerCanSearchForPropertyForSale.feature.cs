// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ZooplaProjectMain.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CustomerCanSearchForPropertyForSale", Description="  As a customer\r\n  I want the ability to search for a property for sale\r\n  So tha" +
        "t I can purchase the property", SourceFile="Features\\CustomerCanSearchForPropertyForSale.feature", SourceLine=0)]
    public partial class CustomerCanSearchForPropertyForSaleFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CustomerCanSearchForPropertyForSale.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CustomerCanSearchForPropertyForSale", "  As a customer\r\n  I want the ability to search for a property for sale\r\n  So tha" +
                    "t I can purchase the property", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CustomerCanSearchForPropertiesForSale(string location, string minPrice, string maxPrice, string property, string bed, string propertyType, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer Can search for properties for sale", null, exampleTags);
#line 6
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    testRunner.Given("I navigate to zoopla homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
    testRunner.When(string.Format("I enter a \"{0}\" in the search text box", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
    testRunner.And(string.Format("I select \"{0}\" from Min price dropdown", minPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
    testRunner.And(string.Format("I select \"{0}\" from Max price dropdown", maxPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
    testRunner.And(string.Format("I select \"{0}\" from Property type dropdown", property), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
    testRunner.And(string.Format("I select \"{0}\" from Bedrooms dropdown", bed), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
    testRunner.And("I click on Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.Then(string.Format("a list of \"{0}\" in \"{1}\" are displayed", propertyType, location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer Can search for properties for sale, Manchester", SourceLine=17)]
        public virtual void CustomerCanSearchForPropertiesForSale_Manchester()
        {
#line 6
  this.CustomerCanSearchForPropertiesForSale("Manchester", "£120,000", "£230,000", "Houses", "3+", "Houses", ((string[])(null)));
#line hidden
        }
        
        public virtual void CustomerCannotSearchForPropertyWithMissingValues(string location, string minPrice, string maxPrice, string property, string bed, string propertyType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer cannot search for property with missing values", null, @__tags);
#line 24
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
    testRunner.Given("I navigate to zoopla homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
    testRunner.When(string.Format("I enter a \"{0}\" in the search text box", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
    testRunner.And(string.Format("I select \"{0}\" from Min price dropdown", minPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
    testRunner.And(string.Format("I select \"{0}\" from Max price dropdown", maxPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
    testRunner.And(string.Format("I select \"{0}\" from Property type dropdown", property), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
    testRunner.And(string.Format("I select \"{0}\" from Bedrooms dropdown", bed), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.And("I click on Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
    testRunner.Then("an error message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer cannot search for property with missing values, ", new string[] {
                "ignore"}, SourceLine=35)]
        public virtual void CustomerCannotSearchForPropertyWithMissingValues_()
        {
#line 24
  this.CustomerCannotSearchForPropertyWithMissingValues("", "£120,000", "£230,000", "Houses", "3+", "Houses", ((string[])(null)));
#line hidden
        }
        
        public virtual void ErrorPageIsDisplayedForInvalidSearch(string location, string minPrice, string maxPrice, string property, string bed, string propertyType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error page is displayed for invalid search", null, @__tags);
#line 39
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
    testRunner.Given("I navigate to zoopla homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
    testRunner.When(string.Format("I enter a \"{0}\" in the search text box", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
    testRunner.And(string.Format("I select \"{0}\" from Min price dropdown", minPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
    testRunner.And(string.Format("I select \"{0}\" from Max price dropdown", maxPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
    testRunner.And(string.Format("I select \"{0}\" from Property type dropdown", property), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
    testRunner.And(string.Format("I select \"{0}\" from Bedrooms dropdown", bed), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
    testRunner.And("I click on Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
    testRunner.Then("an error result page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Error page is displayed for invalid search, Variant 0", new string[] {
                "ignore"}, SourceLine=50)]
        public virtual void ErrorPageIsDisplayedForInvalidSearch_Variant0()
        {
#line 39
  this.ErrorPageIsDisplayedForInvalidSearch("M39 1XC", "£120,000", "£230,000", "Houses", "3+", "Houses", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Error page is displayed for invalid search, Variant 1", new string[] {
                "ignore"}, SourceLine=50)]
        public virtual void ErrorPageIsDisplayedForInvalidSearch_Variant1()
        {
#line 39
  this.ErrorPageIsDisplayedForInvalidSearch("£££", "£250,000", "£400,000", "Farms/land", "No min", "Property", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Error page is displayed for invalid search, Variant 2", new string[] {
                "ignore"}, SourceLine=50)]
        public virtual void ErrorPageIsDisplayedForInvalidSearch_Variant2()
        {
#line 39
  this.ErrorPageIsDisplayedForInvalidSearch("123", "£120,000", "£230,000", "Flats", "3+", "Flats", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Error page is displayed for invalid search, Variant 3", new string[] {
                "ignore"}, SourceLine=50)]
        public virtual void ErrorPageIsDisplayedForInvalidSearch_Variant3()
        {
#line 39
  this.ErrorPageIsDisplayedForInvalidSearch("123", "", "", "", "", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
