# Vendor Tracker

#### By **Samantha Callie**

#### Keep Track of Vendors and Their Orders

## Technologies Used

* HTML
* BootStrap
* C#
* .NET
* ASP.NET Core
* Razor

## Description

This site allows users to view and add to a list of Vendors, each with a name, description, and list of Orders. New Orders can be added to each Vendor, with their own title, description, price, and date.

## Setup/Installation Requirements

1. Press the green <> Code button and select Download ZIP
2. Unzip file
4. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "VendorTracker".
5. In the command line, run the command `dotnet run` to compile and execute the application. Then navigate to https://localhost:5001.
6. Optionally, you can run `dotnet run --launch-profile "production"` to run in the run in production mode, as oppose to development.

## Known Bugs

* Reloading the vendor details page after having just added a new order to it will cause a duplicate of that order to be added again.

## License

MIT License

Copyright (c) 2024 Samantha Callie

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.