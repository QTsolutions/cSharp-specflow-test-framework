
```
This is the basic project of C#, SPecflow and NUnit. I have tried to build a framework based on Page Object Model.
```
## Technology Used
```
  1. C#
  2. Specflow
  3. Nunit
  4. Visual Studio
```

## Detailed explanation on Automation Framework

### Framework type: Page Object Model flavored with Specflow
```
Contains  UI tests
```

### Project Structure
```
pageObjects:-
Contains locators of objects involved in pages of website
```
```
Hooks:-
This package has all the hooks.
```
```
stepDefinitions:-
This package has all the step definitions. Currently have single step def file containing both API and UI steps
```
```
features:-
This package has all .feature files which represents different test scenarios written in Gherkin Language(plain english).
```
```
drivers:-
This package contains the chrome driver and seleniumWebDriver class. Currently, these scripts are running on chrome of windows. If you want to execute on chrome of Mac then you need to add the chrome driver for mac in this folder
```