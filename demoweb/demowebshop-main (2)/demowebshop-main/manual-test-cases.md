TC_001 – Login with Valid Credentials

Objective: Confirm that login works with correct credentials.

Priority: P0

Type: Functional

Prerequisites: A registered user must exist.

Test Data: Email = abbasiaqsa18@gmail.com, 
Password = Test@123

Steps:

Open the website and go to Login page.

Enter valid email and password.

Click on the Login button.

Expected Result: User should be logged in successfully and redirected to the homepage.

Acceptance Criteria: Home page should display “Welcome” message.

TC_002 – Login with Invalid Password 

Objective: Check error handling for wrong password.

Priority: P1

Type: Negative

Prerequisites: Valid user account exists.

Test Data: Email = abbasiaqsa18@gmail.com
, Password = Test@123456

Steps:

Go to Login page.

Enter valid email and incorrect password.

Click Login.

Expected Result: Error message should be displayed – “Login was unsuccessful.”

Acceptance Criteria: User remains on login page.

TC_003 – Register New User

Objective: Ensure new user registration works with unique email.

Priority: P0

Type: Functional/UI

Prerequisites: None.

Test Data: Email = abbasiaqsa12@gmail.com
, Password = Test@123

Steps:

Click on Register.

Enter details with unique email.

Submit form.

Expected Result: Registration should be successful, and user should be logged in.

Acceptance Criteria: Success message is shown.

TC_004 – Navigate to Notebooks Page

Objective: Verify navigation to “Notebooks” under “Computers.”

Priority: P1

Type: Functional/UI

Steps:

Hover over “Computers.”

Click on “Notebooks.”

Expected Result: Notebooks page should open.

Acceptance Criteria: URL contains /notebooks.

TC_005 – Add Laptop to Cart

Objective: Add “14.1-inch Laptop” to cart and validate cart update.

Priority: P0

Type: Functional

Steps:

Open product page for “14.1-inch Laptop.”

Click “Add to Cart.”

Expected Result: Success message displayed, cart badge updates.

Acceptance Criteria: Cart quantity = 1.

TC_006 – Price Consistency Between PDP and Cart

Objective: Ensure product price is the same on Product page and Cart.

Priority: P0

Type: Functional

Steps:

Note the price on product page.

Add product to cart.

Compare cart subtotal with PDP price.

Expected Result: Prices should match.

Acceptance Criteria: No mismatch in price.

TC_007 – Checkout Process

Objective: Verify user can proceed through checkout with dummy billing/shipping data.

Priority: P0

Type: Functional/Integration

Prerequisites: At least one product in cart.

Test Data: Billing Address = Dummy details (e.g., Name: John Doe, Address: 123 Test Street, Country: USA).

Steps:

Go to cart.

Accept terms and conditions.

Click Checkout and fill in details.

Expected Result: Checkout proceeds successfully to payment.

Acceptance Criteria: No validation errors.

TC_008 – Order Confirmation

Objective: Verify order is placed successfully.

Priority: P0

Type: Functional

Prerequisites: Checkout completed.

Steps:

Place the order.

Observe confirmation page.

Expected Result: Thank you message displayed.

Acceptance Criteria: Order number is generated.

TC_009 – Order Number Format Validation

Objective: Ensure order number follows the correct format.

Priority: P1

Type: Functional

Steps:

Capture order number from confirmation page.

Expected Result: Order number matches “Order #12345” format.

Acceptance Criteria: Regex validation passes.

TC_010 – Login with Blank Fields

Objective: Validate behavior when login form is empty.

Priority: P2

Type: Negative

Steps:

Go to Login page.

Leave email and password blank.

Click Login.

Expected Result: Validation error message appears.

Acceptance Criteria: User is not logged in.

TC_011 – Invalid Email Format During Registration

Objective: Verify error message for wrong email format.

Priority: P2

Type: Negative

Test Data: Email = abbasiaqsa18@gmail (missing .com)

Steps:

Open Register page.

Enter invalid email.

Submit.

Expected Result: “Wrong email” error displayed.

Acceptance Criteria: Registration blocked.

TC_012 – Missing Billing Address Fields

Objective: Ensure mandatory billing fields are validated.

Priority: P1

Type: Functional/Negative

Steps:

Go to checkout.

Leave billing address blank.

Click Continue.

Expected Result: Error message shown.

Acceptance Criteria: Cannot proceed.

TC_013 – Multiple Products Cart Calculation

Objective: Validate subtotal calculation with multiple products.

Priority: P0

Type: Functional

Steps:

Add multiple products to cart.

Check subtotal.

Expected Result: Subtotal = sum of product prices.

TC_014 – Shipping Method Selection

Objective: Verify user can select a shipping method.

Priority: P2

Type: Functional

Expected Result: At least one shipping method selectable.

TC_015 – Payment Method Selection

Objective: Confirm payment method selection works.

Priority: P2

Type: Functional

TC_016 – Logout

Objective: Verify logout functionality.

Priority: P2

Type: Functional

TC_017 – Session Persistence

Objective: Verify user stays logged in after refreshing the page.

Priority: P2

Type: Functional

TC_018 – Cross Browser Compatibility

Objective: Ensure site works on Chrome, Edge, Firefox.

Priority: P1

Type: Compatibility

TC_019 – Mobile Responsiveness

Objective: Validate UI on mobile screen size.

Priority: P2

Type: UI/Compatibility

TC_020 – Accessibility Checks

Objective: Confirm form fields and images meet accessibility standards.

Priority: P3

Type: Accessibility