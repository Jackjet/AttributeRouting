﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Constraints")]
    public partial class RouteConstraintsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RouteConstraints.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Constraints", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inline constraints")]
        [NUnit.Framework.TestCaseAttribute("Alpha", "AlphaRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Int", "IntRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Long", "LongRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Float", "FloatRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Double", "DoubleRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Decimal", "DecimalRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Bool", "BoolRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Guid", "GuidRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("DateTime", "DateTimeRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Length", "LengthRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("MinLength", "MinLengthRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("MaxLength", "MaxLengthRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("LengthRange", "LengthRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Min", "MinRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Max", "MaxRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Range", "RangeRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Regex", "RegexRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Compound", "IntRouteConstraint", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Compound", "MaxRouteConstraint", new string[0])]
        public virtual void InlineConstraints(string actionName, string constraintTypeName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inline constraints", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController");
#line 6
 testRunner.When(string.Format("I fetch the routes for the InlineRouteConstraints controller\'s {0} action", actionName));
#line 7
 testRunner.Then(string.Format("the route url is \"Inline-Constraints/{0}/{{x}}\"", actionName));
#line 8
 testRunner.And(string.Format("the parameter \"x\" is constrained by an inline AttributeRouting.Web.Constraints.{0" +
                        "}", constraintTypeName));
#line 10
 testRunner.Given("I have registered the routes for the HttpInlineRouteConstraintsController");
#line 11
 testRunner.When(string.Format("I fetch the routes for the HttpInlineRouteConstraints controller\'s {0} action", actionName));
#line 12
 testRunner.Then(string.Format("the route url is \"Http-Inline-Constraints/{0}/{{x}}\"", actionName));
#line 13
 testRunner.And(string.Format("the parameter \"x\" is constrained by an inline AttributeRouting.Web.Constraints.{0" +
                        "}", constraintTypeName));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple inline constraints per url segment")]
        public virtual void MultipleInlineConstraintsPerUrlSegment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple inline constraints per url segment", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController");
#line 39
 testRunner.When("I fetch the routes for the InlineRouteConstraints controller\'s MultipleWithinUrlS" +
                    "egment action");
#line 40
 testRunner.Then("the route url is \"Inline-Constraints/avatar/{width}x{height}/{image}\"");
#line 41
 testRunner.And("the parameter \"width\" is constrained by an inline AttributeRouting.Web.Constraint" +
                    "s.IntRouteConstraint");
#line 42
 testRunner.And("the parameter \"height\" is constrained by an inline AttributeRouting.Web.Constrain" +
                    "ts.IntRouteConstraint");
#line 44
 testRunner.Given("I have registered the routes for the HttpInlineRouteConstraintsController");
#line 45
 testRunner.When("I fetch the routes for the HttpInlineRouteConstraints controller\'s MultipleWithin" +
                    "UrlSegment action");
#line 46
 testRunner.Then("the route url is \"Http-Inline-Constraints/avatar/{width}x{height}/{image}\"");
#line 47
 testRunner.And("the parameter \"width\" is constrained by an inline AttributeRouting.Web.Constraint" +
                    "s.IntRouteConstraint");
#line 48
 testRunner.And("the parameter \"height\" is constrained by an inline AttributeRouting.Web.Constrain" +
                    "ts.IntRouteConstraint");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Inline constraints specified in the RoutePrefixAttribute")]
        public virtual void InlineConstraintsSpecifiedInTheRoutePrefixAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inline constraints specified in the RoutePrefixAttribute", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given("I have registered the routes for the PrefixedInlineRouteConstraintsController");
#line 53
 testRunner.When("I fetch the routes for the PrefixedInlineRouteConstraints controller\'s Index acti" +
                    "on");
#line 54
 testRunner.Then("the route url is \"Prefixed-Inline-Constraints/{id}/Howdy\"");
#line 55
 testRunner.And("the parameter \"id\" is constrained by an inline AttributeRouting.Web.Constraints.I" +
                    "ntRouteConstraint");
#line 57
 testRunner.Given("I have registered the routes for the HttpPrefixedInlineRouteConstraintsController" +
                    "");
#line 58
 testRunner.When("I fetch the routes for the HttpPrefixedInlineRouteConstraints controller\'s Index " +
                    "action");
#line 59
 testRunner.Then("the route url is \"Http-Prefixed-Inline-Constraints/{id}/Howdy\"");
#line 60
 testRunner.And("the parameter \"id\" is constrained by an inline AttributeRouting.Web.Constraints.I" +
                    "ntRouteConstraint");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Matching inline route constraints")]
        [NUnit.Framework.TestCaseAttribute("Alpha/abc", "Alpha", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Alpha/123", "Alpha", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Int/53", "Int", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Int/abc", "Int", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("IntOptional", "IntOptional", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Long/79", "Long", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Long/xyz", "Long", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Float/1.334", "Float", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Float/gg2", "Float", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Double/3.14", "Double", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Double/adf78", "Double", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Decimal/99.32123345", "Decimal", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Decimal/d8uasdf", "Decimal", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Bool/true", "Bool", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Bool/false", "Bool", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Bool/truish", "Bool", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Bool/falsish", "Bool", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Guid/6076668C-57AA-47FD-A914-94FD552C8493", "Guid", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Guid/6076668C-57AA-47FD-A914-94FD552C", "Guid", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("DateTime/2012-4-22", "DateTime", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("DateTime/Today", "DateTime", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Length/a", "Length", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Length/aa", "Length", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("MinLength/abcdefghi", "MinLength", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("MinLength/abcdefghij", "MinLength", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("MaxLength/abcdefghij", "MaxLength", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("MaxLength/abcdefghijk", "MaxLength", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("LengthRange/abcdefghijk", "LengthRange", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("LengthRange/a", "LengthRange", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("LengthRange/ab", "LengthRange", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("LengthRange/abcdefghij", "LengthRange", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("LengthRange/abcdefghijk", "LengthRange", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Min/0", "Min", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Min/1", "Min", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Max/10", "Max", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Max/11", "Max", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Range/0", "Range", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Range/1", "Range", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Range/10", "Range", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Range/11", "Range", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Regex/Howdy", "Regex", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Regex/BoyHowdy", "Regex", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Compound/5", "Compound", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Compound/5.0", "Compound", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Enum/red", "Enum", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Enum/taupe", "Enum", "is not", new string[0])]
        [NUnit.Framework.TestCaseAttribute("WithOptional", "WithOptional", "is", new string[0])]
        [NUnit.Framework.TestCaseAttribute("WithDefault", "WithDefault", "is", new string[0])]
        public virtual void MatchingInlineRouteConstraints(string url, string action, string condition, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Matching inline route constraints", exampleTags);
#line 62
this.ScenarioSetup(scenarioInfo);
#line 64
 testRunner.Given("I have registered the routes for the InlineRouteConstraintsController");
#line 65
 testRunner.When(string.Format("a request for \"Inline-Constraints/{0}\" is made", url));
#line 66
 testRunner.Then(string.Format("the {0} action {1} matched", action, condition));
#line 68
 testRunner.Given("I have registered the routes for the HttpInlineRouteConstraintsController");
#line 69
 testRunner.When(string.Format("a request for \"Http-Inline-Constraints/{0}\" is made", url));
#line 70
 testRunner.Then(string.Format("the {0} action {1} matched", action, condition));
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
