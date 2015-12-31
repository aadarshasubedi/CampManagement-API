# CampManagement-API <br />
This small API can be used to create a simple management simulation game with Visual Basic .NET. <br />

# Features: <br />
-- Economics Mechanics such as Inflation that eats your money overtime <br />
-- Taxes! You got to pay taxes to the local government to continue working! <br />
-- Resource management of Wood, Manpower and other things. <br />
-- In-game information is exported and handled outside the .exe on the /Data/ Folder and can be modified according to your needs <br />
-- Easy-to-use: Add the API as a dependency, and call the functions! <br />
-- May not even work yet! <br />

All these features are part of the API at it's current state. These may or may not be currently implemented in the demonstration.

# Setup: <br />
First of all,  I recommend copying the folder "Data" from "**/CampManagement/Bin/Debug/" to your application root location.<br />

To setup taxes, all you have to do is call the EasyTax() or HardTax() (EasyTax tax is 15%. HardTax is 35%) once a year in-game. Or more often. After calling it, it will calculate how much the player shall be taxed, and put the result in "/Data/TaxInfo.txt". You need to diminish the player's money in-game by the value on TaxInfo.txt. <br />

To setup inflation, all you have to do is call the EasyInflation() or HardInflation() once a year in-game. After doing that, make sure to overwrite the in-game wealth with the data from "/Data/FinanceInfo.txt", as the inflation-applied money quantity will be in that file. Otherwise, the inflation will be ignored by the game. <br />
