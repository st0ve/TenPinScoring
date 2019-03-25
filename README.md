#Ten Pin Bowling Scoring

The ask:
Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces the total score for the game.

Out of scope:
- Checking for valid rolls
- Checking for correct number of rolls and frames
- Scores for intermediate frames

Dependencies:
- Microsoft .NET Framework 4

Build instructions:
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe {path to}\TenPinScoring\TenPinScoring.sln

Run program instructions:
{path to}\TenPinScoring.exe {space separated list of integer rolls}
Perfect game example: TenPinScoring.exe 10 10 10 10 10 10 10 10 10 10 10 10

Run unit test instructions:
{path to}\TenPinScoring\packages\NUnit.ConsoleRunner.3.10.0\tools\nunit3-console.exe {path to}\TenPinScoring\TenPinTests\bin\Debug\TenPinTests.dll