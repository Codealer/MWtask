# Date Range Formatter

Command line application printing date range in console.

Prerequisites:
1. Accepts input parameters as 2 dates in format dd.MM.yyyy
2. Checks for format and culture specific handling
3. Prints shortest date range in console
4. Program is written with consideration of SOLID principles.
5. Program is using NUnit for tests.


Project used Visual Studio 2017 Community.

How to use:
1. Bulid projects
2. Run console
3. Find path for Program.exe
4. Type in console:
> Program.exe date1 date2

examples:
1) Program.exe 01.01.2011 02.01.2011
output: 01 - 02.01.2011
2) Program.exe 01.02.2011 02.01.2011
output: 02.01 - 01.02.2011
3) Program.exe 02.01.2011 01.02.2012
output: 02.01.2011 - 01.02.2012
