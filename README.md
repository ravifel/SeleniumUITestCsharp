# SeleniumUITestCsharp

This is the automated testing project using Selenium Web Driver with C# programming language during the Workshop on automated testing on the "RKTestingTools" channel on Youtube.

Link to the playlist for the Selenium WebDriver + "C#" Workshop: https://youtube.com/playlist?list=PLrEdqqBKCEUeJaRoupDarHUHUamcAqDj4&si=xeWoGkYrQUZ_uhH9

Link to the YouTube channel: https://www.youtube.com/@rameshkudikala83

![image](https://github.com/user-attachments/assets/cd588c1c-1bbc-45c8-a74d-803a781e3ede)

------------------------------------------------------------------
#1 Selenium WebDriver | C#.Net | Workshop
C# seleniumwebdriver #visualstudio #testautomation #pageobjectmodel 
Steps to setUp Webdriver in Visual Studio

1. Download and install Visual Studio 2022
2. Install Latest version of .Net Framework ( If it is not installed)
3. Open the Visual Studio and Create a Unit Test Project
4. Create a Folder Structure for Selenium Webdriver Automation
5. Go to Manage Nuget Packages and Install Required Selenium Libraries
6. Clean and build the Solution.
7. Create a Sample Test for Below Scenarios ( WebSite: https://demowebshop.tricentis.com/
)

Required Selenium Libraries:
![packages-installed](https://github.com/user-attachments/assets/c0618c12-a2a5-436f-a3ab-e337aa08a372)


##### Method 1 - Basic Test #####

Test Scenario:  Validate the register functionality with valid data

Step1 : Launch browser and navigate to site url

Step2 :   

Step 3: Click on register link

Step 4: Verify the register page Title

Step 5: Select the gender Male

Step 6: Enter FirstName

Step 7 : Enter lastname

Step 8: Enter email address

Step 9: Enter pAssword

Step 10 . Enter confirm password

Step 11 . Click register button

Step 12. Verify the registration successfull message 

Step 13. verify the email account at account

------------------------------------------------------------------
#2 Selenium WebDriver | C#.Net | Workshop

##### Method 2 - Same Test with Page Object Model #####
Create Page Classes
Create Base Class - ( Re-usable Methods)
Create Actual Test by calling Page Objects methods
Run  the Test

------------------------------------------------------------------
#3 Selenium WebDriver | C#.Net | Workshop

1. Simplify the Page Object Model
 a. WebdriverExtensions.cs
  i. EnterText(args)
   ii.Click()
  ii IsElementDisplayed()
2. Category of Test cases.(TestCategory("Smoke)]
 a. Smoke Tests
 b.FunctionalTests
  c. UnitTest

3. How to Read Config Data

4. Push the Local code to remote repo
github Url : https://github.com/rkudikala143/SeleniumUITest

------------------------------------------------------------------
#5 Selenium WebDriver | C#.Net | Workshop
1. Create a JSON file with data
2. Create Data Model ( Encapsulation)
3. Read Json Data using System.Text.Json class libraries
4. Create a Test Scripts and read data from JSON file.

Github : https://github.com/rkudikala143/SeleniumUITest/tree/readDataFromJson

------------------------------------------------------------------
#6 Selenium WebDriver | C# -| Workshop -JsonReader(Multiple Objects)
Create a Json file with multiple Data Objects
Create a Data Model
Read multiple Objects from JSon file.
Implements in Selenium WebDriver with C#

Github : https://github.com/rkudikala143/SeleniumUITest/tree/readDataFromJson


