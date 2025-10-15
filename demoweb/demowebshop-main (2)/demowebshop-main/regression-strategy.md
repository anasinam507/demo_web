Risk Assessment Matrix

| Feature              | Priority | Impact    | Probability | Overall Risk |
| -------------------- | -------- | --------- | ----------- | ------------ |
| User Registration    | P0       | High      | High        | High         |
| Login/Logout         | P0       | High      | High        | High         |
| Add to Cart          | P0       | High      | High        | High         |
| Checkout & Payment   | P0       | Very High | High        | Very High    |
| Order Confirmation   | P0       | Very High | High        | Very High    |
| Product Catalog      | P1       | Medium    | Medium      | Medium       |
| Search               | P2       | Low       | Medium      | Low          |
| Account Management   | P2       | Medium    | Medium      | Medium       |
| Cross-browser/Mobile | P2       | Medium    | Medium      | Medium       |

Test Selection Strategy

Smoke Suite (must run on every build): Login, Add to Cart, Checkout, and Order Confirmation.

Full Regression (major release): Covers all functional areas along with edge cases.

Targeted Regression (patch release): Only impacted modules plus the smoke suite.

Automation vs Manual

Automated: Login, Add to Cart, Checkout, Order Confirmation, and Order Number validation.

Manual: Negative flows, UI validations, cross-browser checks, and accessibility testing.

Execution Framework

Test execution prioritization will follow P0 first, then P1, P2, and finally P3.

Regression suite will be updated whenever a new feature is added or existing functionality changes.

Timelines:

Smoke suite takes around 15 minutes.

Full regression (automated + manual) takes around 3–4 hours.

Targeted regression usually takes around 1 hour.
