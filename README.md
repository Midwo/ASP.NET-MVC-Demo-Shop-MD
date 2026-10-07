# Demo-Shop MD

🔗 **Live Demo:** https://www.demoshop.mdwojak.pl/

> Full-stack ASP.NET MVC e-commerce platform developed as a portfolio project. The application demonstrates user authentication, product management, shopping cart functionality, payment integration, newsletter automation, background processing, and production-style monitoring tools.

---

## Demo Accounts

### Administrator

Email: `admin@mdwojak.pl`  
Password: `123456Aa!`

### Customer

Email: `klient@mdwojak.pl`  
Password: `123456Aa!`

---

## 1. Project Description

MD Shop is a full-stack ASP.NET MVC e-commerce application created to simulate a real-world online store.

The project includes both customer-facing and administrative functionality, covering the entire purchasing process from account creation and product browsing to order management and email notifications. The application also demonstrates common enterprise features such as OAuth authentication, background job processing, logging, monitoring, and dependency injection.

The goal of the project was to gain practical experience with technologies and patterns commonly used in .NET web applications.

---

## 2. Overview

The application allows users to:

- Create and manage accounts
- Link external authentication providers
- Browse and purchase products
- Manage a shopping cart
- Review order history
- Subscribe to newsletters
- Contact the store through a dedicated support form
- Complete purchases using an online payment gateway

Administrators can:

- Manage products
- Review customer inquiries
- Monitor application logs
- Supervise background tasks
- Manage newsletters
- Track orders and store activity

### Demo Notes

- Facebook and Google authentication are currently disabled in the public demo due to provider verification and policy requirements. The integration implementation remains available in the source code.
- Payments use a Przelewy24 sandbox/test account. Because test merchant accounts have a limited lifespan, payment confirmation and gateway redirection may not always be available. Users are informed about this limitation during checkout.

---

## 3. Tech Stack

### Backend

- ASP.NET MVC
- C#
- LINQ
- Razor

### Frontend

- HTML5
- CSS3
- Bootstrap
- JavaScript
- jQuery

### Authentication

- OAuth2
- Facebook Login Integration
- Google Login Integration

### Dependency Injection

- Ninject

### Background Processing

- Hangfire

### Logging & Monitoring

- ELMAH
- NLog

---

## 4. Functionalities

### Authentication & User Management

- User registration and login
- Role-based access (Customer / Administrator)
- Google OAuth integration*
- Facebook OAuth integration*
- External account linking and unlinking
- Password management
- User account management

### E-Commerce

- Product catalog browsing
- Product details pages
- Product categorization
- Shopping cart management
- Order creation
- Order history
- Order status tracking
- Shipping cost calculation
- Online payment integration (Przelewy24 Sandbox)

### Communication

- Contact form
- Embedded map on contact page
- Automated transactional emails
- Order confirmation emails
- Order cancellation emails
- Newsletter subscription
- Newsletter unsubscribe via email link

### Administration

- Product creation
- Product editing
- Product activation/deactivation
- Customer inquiry management
- Newsletter reporting
- Order management

### Monitoring & Maintenance

- Hangfire background jobs
- Scheduled task monitoring
- Background job execution tracking
- ELMAH error monitoring
- Application logging with NLog

\* OAuth integrations are currently disabled in the public demo due to provider verification requirements.

---

## 5. Screenshots

### Home Page and Product Catalog
Page top:
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_1.png" width="600" alt="photo1">
</br></br></br>
Page center:
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_2.png" width="600" alt="photo2">
</br></br></br>
Page bottom:
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_3.png" width="600" alt="photo3">

Landing page displaying product categories, featured products, promotions, best-selling products, partners, and newsletter subscription.

---

### Other subpages
Shipping page:
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_7.png" width="600" alt="photo4">
</br>
</br>
Contact and Map page:
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_8.png" width="600" alt="photo5">



---
### Product Details
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_15.png" width="600" alt="photo6">


Detailed product page including product information, pricing, images, and purchasing options.

---

### Login & OAuth Authentication

</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_14.png" width="600" alt="photo7">
</br></br></br>
Delinking the account:
</br>
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_10.png" width="600" alt="photo8">


Authentication page supporting standard login as well as Facebook and Google OAuth integration.

---


### Customer & Administration Dashboard

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_4.png" width="600" alt="photo9">

Central management panel containing account settings, order tracking, product administration, newsletter reporting, log access, and scheduled task management.

---

### Order History

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_11.png" width="600" alt="photo10">

Detailed order overview with purchased products, shipping information, payment status.


---

### Transactional Emails

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_16.png" width="600" alt="photo11">

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_12.png" width="600" alt="photo12">

Automated email notifications generated after business events such as order confirmations and order cancellations.

---

### ELMAH Monitoring

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_9.png" width="600" alt="photo13">

---

### Hangfire Dashboard

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_6.png" width="600" alt="photo14">
<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_5.png" width="600" alt="photo15">

Dashboard for managing recurring and background jobs executed by the application.

---

### Generating reports and saving to Excel

<img src="https://github.com/Midwo/ASP.NET-MVC-Demo-Shop-MD/blob/master/DemoShop/PhotosToReadmeFile/DemoShop_13.png" width="600" alt="photo16">

