# ShellCrap
Reproduction project for a catastrophic crash of MAUI's Shell under iOS

# Description
Deploying this project onto an iPad with iOS 16.6.0 will lead to crashes as soon as you navigate between Flyout items.
From my experience the crash will occurr after 5-6 navigation clicks, but can also occurr much earlier.

To prevent the crash, go into the csproj file and switch to Maui 8 Preview 6 via the <MauiVersion> Tag
