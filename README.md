# _Pierre's Bakery_

#### _This program takes in a bakery order of bread loaves and pastries, and returns a cost_
#### By _**Ian Scott**_

## Description

_Pierre's Bakery is a terminal run c# program that prompts a user for a bakery order (loaves of bread and pastries) and returns a total cost of the order. Cost of bread and pastries are reduced when purchasing multiples. For bread - buy 2 get 1 free. For pastries: buy 1 for $2, or 3 for $5. The program will attempt to up-sell a user if they attempt to purchase an even number of pastries._

### Specifications
| | Behavior | Input | Output | isComplete |
| :-------------     | :-------------     | :------------- | :------------- |:------------- |
|1.|The program can create a custom class instance of Bread | N/A |N/A  | _True_ |
|2.|The program can create a custom class instance of Pastry | N/A | N/A | _True_ |
|3.|The program can take in an order number from the user when creating a Bread object | 2 | 2 Loaves |_True_ |
|4.|The program can take in an order number from the user when creating a Pastry object | 4 | 2 Pastries |_True_ |
|5.|The program will return a total cost of all loaves purchased | 2 | $10 |_True_|
|6.|The program will return a total cost of all pastries purchased | 3 | $6 |_True_|
|7.|The program will incorporate bulk purchase discounts for loaves when calculating price: buy 2 get one free | 3 | $10 |_True_|
|8.|The program will incorporate bulk purchase discounts for pastries when calculating price: buy 1 for $2 or 3 for $5 | 3 | $5 |_True_|
|9.|When the user runs the program there will be a welcome prompt and a description of the cost of bread and Pastries | _Program Start_ | Welcome to Pierre's Bakery! ... |_True_|
|10.|The program will accept user input regarding how many loaves of bread and pastries the user will be purchasing and return total cost of the selection | 3;2 | $14 |_True_|
|11.| The program will not accept non-number inputs, and will re-prompt the user if a non-number has been submitted | Hello! | Please only submit numbers | _True_|
|12.| The program will attempt to up-sell the user if they attempt to purchase an even number of pastries | Pastries: 5 | Would you like 1 additional pastry for only $1? |_True_|
|13| The program will offer a free loaf of bread to the user if they submit a bread order number of 1 less than a multiple of 3|8| Would you like to add another loaf of bread to your order for free?| _True_|


## Setup/Installation Requirements

1. This program utilizes .NET version 3.1, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/3.1 and install the SDK   version 3.1 or greater patch version, but do not upgrade to a higher minor version number.
2. Clone this repository onto your computer: https://github.com/...
3. In your preferred terminal window, navigate into PROJECTNAME.SOLUTIONS/PROJECTNAME using cd (i.e. cd desktop/PROJECTNAME.SOLUTIONS/PROJECTNAME) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore
5. To initiate this terminal program, run the command: $ dotnet run
6. To run the test suite included with this project, within the terminal navigate into PROJECTNAME.TESTS and run the following commands:
    * $ dotnet restore
    * $ dotnet test


## Known Bugs

_There are currently no known bugs._

## Support and contact details

_If you would like to discuss this project with the author, report bugs, or contribute, please contact the author via GitHub._

## Technologies Used

_This program utilizes Object Oriented Programming, .Net 3.1.5, recursive methods, and MSTest to ensure functionality._

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Ian Scott**.