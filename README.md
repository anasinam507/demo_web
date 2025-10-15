Demo Web Shop

Overview

This project is created for the Demo Web Shop application. It includes both automation (Selenium C# with Page Object Model) and manual testing documentation. The main focus is to cover an end-to-end purchase flow and to provide a clear regression testing strategy.

Setup Instructions:

Clone this repository or download it as a ZIP file.

Open the solution in Visual Studio.

Restore dependencies by running: dotnet restore

To execute the tests, run: dotnet test

Environment

OS: Windows 10/11

Language: C# (.NET 6)

Automation Framework: Selenium with MSTest

Browser: Chrome (latest)

Driver: ChromeDriver

Automated Test Scenarios

The following scenarios are automated:

Login (valid and invalid credentials)

User registration with a unique email

Add product (14.1-inch Laptop) to the cart

Validate product name and price consistency across pages

Checkout flow (billing, shipping, payment steps)

Order confirmation (Thank You page)

Order number validation with regex

Manual Test Cases

Manual test cases are included in the project: /Manual-Test-Cases/manual-test-cases.md These cover 20+ scenarios including positive, negative, boundary, cross-browser, and accessibility cases.

Regression Strategy

The regression testing approach is documented here: /Regression-Strategy/regression-strategy.md This explains the risk matrix, smoke suite, targeted vs full regression, and execution timelines.

Artifacts

If tests fail, screenshots and logs can be generated (this can be configured in test settings).

Assumptions

Dummy billing/shipping details are used.

Payment gateway is simulated, not a real transaction.

Chrome browser is assumed for automation runs.
