﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AssisServiceSpike")]
    public partial class AssisServiceSpikeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AssisServiceSpike.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssisServiceSpike", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            this.FeatureBackground();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
 testRunner.Given("there is a feature file in the project as", "\tFeature: Simple Feature\n\tScenario: Simple Scenario\n\t\tGiven the following books\n\t" +
                    "\t\t| Author      | Title                          | ReadingTime |\r\n\t\t\t| Gojko Adz" +
                    "ic | Bridging the Communication Gap | 11 hours    |", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 12
 testRunner.And("the following binding class", "public class Book\n{\npublic string Author {get;set;}\npublic string Title {get;set;" +
                    "}\npublic TimeSpan ReadingTime {get;set;}\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 21
 testRunner.Given("the following step definitions", "[StepArgumentTransformation(@\"(\\d+) hours\")]\npublic TimeSpan ConvertFromHours(int" +
                    " hours)\n{\n\treturn TimeSpan.FromHours(hours);\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to execute a simple passing scenario")]
        public virtual void ShouldBeAbleToExecuteASimplePassingScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to execute a simple passing scenario", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 32
 testRunner.Given("the following step definitions", "//[Given(\"the following books\")]\npublic void GivenTheFollowingBooks(Table booksTa" +
                    "ble)\n{\n\tvar book = booksTable.CreateSet<Book>().Single();\n\tif (book.ReadingTime " +
                    "!= TimeSpan.FromHours(11))\n\t\tthrow new Exception(\"wrong reading time\");\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 42
 testRunner.And("the following binding class", @"[Binding]
public class StepsWithAssistService
{
private readonly AssistService assistService;

public StepsWithAssistService(AssistService assistService)
{
this.assistService = assistService;
}

//[Given(""the following books"")]
public void GivenTheFollowingBooks_UsageA(Table booksTable)
{
var book = assistService.CreateSet2<Book>(booksTable).Single();
if (book.ReadingTime != TimeSpan.FromHours(11))
throw new Exception(""wrong reading time"");
}
}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 63
 testRunner.And("the following step definitions", "[Given(\"the following books\")]\npublic void GivenTheFollowingBooks_UsageB(Table bo" +
                    "oksTable)\n{\n\tvar book = booksTable.CreateSet2<Book>().Single();\n\tif (book.Readin" +
                    "gTime != TimeSpan.FromHours(11))\n\t\tthrow new Exception(\"wrong reading time\");\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 73
 testRunner.When("I execute the tests");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Total",
                        "Succeeded"});
            table1.AddRow(new string[] {
                        "1",
                        "1"});
#line 74
 testRunner.Then("the execution summary should contain", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
