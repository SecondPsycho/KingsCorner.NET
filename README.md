# KingsCorner.NET
A web app to play King's Corner, written in a .NET framework using Razor/Blazor, C#, HTML5 &amp; CSS3.

## Requirements
    -.NET 7.0
    It was written in Windows 10.

## How to Run
    Open a Windows command prompt, navigate to the project folder and enter `dotnet watch` or `dotnet run`.

## What's King's Corner?
    King's Corner is a single-player game played with an ordinary deck of playing cards.
    You draw one card at a time, and place them on a 4x4 grid.
    Kings can only go in corners, Jacks can only got in the top squares and Queens in the left and rightmost squares. 
    You can remove a numbered card from the board by 'matching' it with another card with which it adds up to 10 
    (a 4 & a 6 would match, for instance). 
    If you place all the face cards, you win!
    If you can't place a card, you lose.
    
    (A more complete tutorial is included inside web app itself. Just click on the 'Tutorial' tab.)
    
## Interesting Features
### Undo Functionality
    The code uses a linked list to allow you to undo moves. You'll never have to lose again!
### Every game is Winnable
    If you're shuffling physical cards, not every game will be winnable. 
    My code detects these games before you start, and reshuffles until you get a game you can actually win!
