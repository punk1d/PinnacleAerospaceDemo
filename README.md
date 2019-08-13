# PinnacleAerospaceDemo

A Quick Demo on Selenium Tools and MS Unit Test using C#

## Installation

You would need an installation of Visual Studio and git in your local environment. 

  - Git can be [downloaded here](https://desktop.github.com/).
  - VS Community can be [downloaded here](https://visualstudio.microsoft.com/es/vs/).

Clone the repository with the following git command and place it in an empty folder:

```bash
git clone https://github.com/punk1d/PinnacleAerospaceDemo.git
```
Open the .sln file inside the local repository and Visual Studio will load the solution for you.

## How do i get this running?

The following steps will guide you to the most basic execution of the Test Suite:

  1.  Load Up the project by going into the local repository and load up the .sln file
  2.  Using Visual Studio, in the main menu head to "Test>Windows>Test Explorer"
  3.  Test Explorer will come up as a side-window in which tests are located inside their suites
  4.  Select the highest item in the tree view to get all suites running
  5.  Selecting individual suites/tests is also possible
  6.  Go to "Test>Run" and select a plan on how to run your Test Cases

## Project background

This project contains a suite of 26 Tests that were designed for the following scenarios described:

  [https://docs.google.com/document/d/1K1R2mM8qduajiUNbF09s2eczs_24GMyibFjEB_4XwLo/edit#](https://docs.google.com/document/d/1K1R2mM8qduajiUNbF09s2eczs_24GMyibFjEB_4XwLo/edit#)
  
 # Troubleshoot
 
 So far, this is the list of identified problems for some users:
 
 ## Admin permissions
 
 When building the application some users may experience the following Output:
 
  ```bash
   Command "chmod +x " exited with code 9009
  ```
  
  This can be solved by running Visual Studio in admin mode.
  
  ## Run suites using the Test menu
  
  Unit Test projects won't run by using the "play" icon in the menu at the top of Visual Studio IDE, nor when selecting "Debuv>Start Debugging" or hitting "F5"
  
  Instead, tests can be run through "Test>Run" options or selecting the wanted tests and selecting "Run Selected Tests" out of the context menu.
  
  
  
  
