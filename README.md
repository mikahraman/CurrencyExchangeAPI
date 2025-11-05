# Currency Exchange API

This is an ASP.NET Core 8.0 Web API project that provides real-time currency exchange rates. As a portfolio project, its main goal is to demonstrate how to build a RESTful service, use `HttpClient` to connect to third-party APIs (in this case, the Frankfurter API), and handle JSON data effectively.

## Main Features
* **Clean Endpoint:** Uses a clear RESTful URL structure: `GET /api/currency/{code}`.
* **Live Data Integration:** Connects to the free Frankfurter API to fetch up-to-date exchange rates.
* **Swagger Documentation:** Includes OpenAPI (Swagger) support by default, allowing anyone to test the API directly from the browser.
* **Proper Error Handling:** The API is built to return appropriate HTTP status codes (like 404 Not Found or 500 Server Error) when a request fails.

## Technology Used
* **Framework:** .NET 8.0 (ASP.NET Core Web API)
* **Language:** C# 12
* **Documentation:** Swagger (OpenAPI)
* **Dependencies:** `System.Text.Json` (for handling JSON data)

## How to Use
1.  Run the project from Visual Studio.
2.  The browser will automatically open the Swagger UI page (e.g., `https://localhost:7126/swagger`).
3.  Find the `GET /api/Currency/{code}` endpoint and expand it.
4.  Click the "Try it out" button.
5.  Enter a currency code (like `USD` or `EUR`) into the `code` field and click "Execute".
6.  You will see the live exchange rate data in the response body below.

---
Mehmet İkbal Kahraman - *Developed as a backend portfolio project.*
