# CampManagement-API <br />
_This small API can be used to create a simple management simulation game with Visual Basic .NET_ <br />

# Features: <br />
-- **Economics Mechanics such as Inflation that eats your money overtime** <br />
-- Taxes! You got to pay taxes to the local government to continue working! <br />
-- Resource management of Wood, manpower and other things. <br />
-- The API handles connection to the game through files inside the Data Folder. <br />
-- Easy-to-use: Add the API as a dependency, and call the functions! <br />
-- This is a proof-of-concept of gaming on Visual Basic and may not work. <br />

Demo built with .NET 4.6 - Visual Studio 2015 Professional - Update 1 not installed.

_All these features are part of the API at it's current state. These may or may not be currently implemented in the demo "CampManagement"._

# Setup: <br />
First of all, I recommend copying the folder "Data" from CampManagement/Bin/Debug/ to your game's root location. After that, create a timer that will read information from Data/FinanceInfo.txt, Data/WoodInfo.txt etc and keep it updated with the UI every 0.3 seconds, This is **obligatory for the API to be in sync with your game!**. If you want an example, check out Timer1 and Timer2 on CampManagement.<br />

## To setup the API:
Add the API to your project as a Reference under Project Properties. Use "Imports" to tie it to your form.

## To setup taxes:
All you have to do is call Mechanics.Taxes() once a year in-game or so. After calling it, it will calculate how much the player shall be taxed, and update the money the player has in-game. <br />

## To setup inflation:
All you have to do is call Mechanics.Inflation() once a year in-game. After calling it, it will calculate how much the player shall have after having his money corrected by the current inflation index, and update the money the player has in-game. <br />
