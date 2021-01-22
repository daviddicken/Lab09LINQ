# Lab09LINQ
 
**Author**: David Dicken
**Version**: 1.4.0   
Date: 1/21/2021  

## Overview
This program reads a json file and using LINQ it parses the json file down to unique neighborhoods.

## Walk Through
When you run this program it will read a json file data.json of cities and neighborhoods.
The first thing to get printed to the screen is all neighborhoods that were parsed from the json. Press any key to continue.
Next the program will remove all the neighborhoods that do not have names and display the remaining ones to the screen. Press any key to continue.
After that all duplicate neighborhoods will be removed leaving only unique neighborhood to be displayed to the screen. Press any key to continue.
Then we combine all of the search queries into one query and redisplay those neighborhoods. Press any key to continue.
Lastly we reparse the original Json file and remove the neighnorhoods that do not have a name using a method call.

## Example
25. Inwood
26. East Harlem
27. Hell's Kitchen
28. Upper Manhattan
29. Roosevelt Island
30. Midtown
31. Hunter College, Rockefeller University
32. Battery Park City
33. Manhattanville
34. Murray Hill
35. Carnegie Hill
36. Yorkville
37. Lenox Hill
38. Kips Bay
39. South Cove
Press any key to continue

## Architecture
This app was built with Visual Studio using C# and LINQ.
