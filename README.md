# CampManagement-API <br />
_This small API can be used to create a simple management simulation game with Visual Basic .NET_ <br />

# Features: <br />
-- **Economics Mechanics such as Inflation that eats your money overtime** <br />
-- Taxes! You got to pay taxes to the local government to continue working! <br />
-- Resource management of Wood, manpower and other things. <br />
-- The API handles connection to the game through files inside the Data Folder. <br />
-- Easy-to-use: Add the API as a dependency, and call the functions! <br />
-- This is a proof-of-concept of gaming on Visual Basic and may not work. <br />

_All these features are part of the API at it's current state. These may or may not be currently implemented in the demo "CampManagement"._

# Setup: <br />
First of all, I recommend copying the folder "Data" from CampManagement/Bin/Debug/ to your game's root location. After doing that, create a timer in-game that will read the current amount of money the player from "/Data/FinanceInfo.txt" every 3s or so. This is  **obligatory**. You may also need to read from other files on the "Data" Folder. Check Timer1 and Timer2 on CampManagement for more information.<br />

## To setup taxes:
All you have to do is call the EasyTax() or HardTax() (EasyTax tax is 15%. HardTax is 35%) once a year in-game. Or more often. After calling it, it will calculate how much the player shall be taxed, and put the result in "/Data/TaxInfo.txt". You need to diminish the player's money in-game by the value on TaxInfo.txt. <br />

## To setup inflation:
All you have to do is call the EasyInflation() or HardInflation() once a year in-game. After doing that, make sure to overwrite the in-game wealth with the data from "/Data/FinanceInfo.txt", as the inflation-applied money quantity will be in that file. Otherwise, the inflation will be ignored by the game. <br />
