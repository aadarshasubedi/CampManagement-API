# CampManagement-API <br />
_This API can be used to create a simple management simulation game with Visual Basic .NET_ <br />

# Features: <br />
-- API Inflation Functions can be used for a harder gameplay experience, in various levels. <br />
-- API Taxation Functions can be used for a harder gameplay experience, in various levels<br />
-- Resource management of Wood, manpower and other things. <br />
-- API Functions can be used to simplify in-game code. <br />
-- You can play the demo!<br />

Demo built with .NET 4.6.1 - Visual Studio 2015 SP1

_All these features may or may not currently be implemented in the API. If you want to test the API, execute CampManagement._

# Setup: <br />
First of all, copy the folder "Data" from CampManagement/Bin/Debug/ to your game's root location. This includes the GameStats.ini and the DLC_Modules Folder (necessary for mod and dlc support). After that, just be sure to load game information from GameStats.ini when starting the game, and save game information to GameStats.ini when leaving the game. Or every 5 minutes. Up to you.<br />

## To setup the API:
Add the API to your project as a Reference under Project Properties. Use "Imports" to tie it to your form. You need to have something in-game to allow the user to select his prefered difficulty settings. For a easy playthrough, call _Mechanics.SetDifficultyEasy_, for a harder and more punishing playthrough, call _Mechanics.SetDifficultyHard_. This is necessary for the taxes and inflation and other resource calculus to work correctly.

# Usage: <br />

## How to: Taxes:
All you have to do is call _Mechanics.Taxes(PlayerWealthAmountHere)_ once a year in-game or so. After calling it, it will calculate how much the player shall be taxed, and return the new player money, and how much he was taxed. <br />

## How to: Inflation:
All you have to do is call _Mechanics.Inflation(PlayerWealthAmountHere)_ once a year in-game. After calling it, it will calculate how much the player shall have after having his money corrected by the current inflation index, and return the new player money. <br />

## How to: Worker Profit
All you have to do is call _Resources.WorkForceGenerateProfits(TotalWorkerForceHere)_ every time you want to update the player money based on worker production. After calling it, it will calculate how much the player shall have after receiving workforce profits, and return the new player money.<br />

# License: <br />
I have not chosen a proper license for it yet, but: Do not redistribute my CampManagement Demo, or the API. It must be downloaded through here. (You may include the API in your app, that is.) I'd like to receive credits if you use my API. <br />

For commercial usage, contact me.
