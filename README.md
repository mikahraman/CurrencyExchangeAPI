# Currency Exchange API

This is an ASP.NET Core 8.0 Web API project that provides real-time currency exchange rates. As a portfolio project, its main goal is to demonstrate how to build a RESTful service, use `HttpClient` to connect to third-party APIs (in this case, the Frankfurter API), and handle JSON data effectively.

## Main Features
* **Clean Endpoint:** Uses a clear RESTful URL structure: `GET /api/currency/{code}`.
* **Live Data Integration:** Connects to the free Frankfurter API to fetch up-to-date exchange rates.
* **Swagger Documentation:** Includes OpenAPI (Swagger) support by default, allowing anyone to test the API directly from the browser.
* **Proper Error Handling:** The API is built to return appropriate HTTP status codes (like 404 Not Found or 500 Server Error) when a request fails.
<img width="1706" height="630" alt="Screenshot1" src="https://github.com/user-attachments/assets/ea8cfe9a-c346-4006-8b87-2466eab9c9be" />
<img width="1685" height="866" alt="Screenshot2" src="https://github.com/user-attachments/assets/e329f708-794d-4850-a1b1-49a13a8c94fe" />
<img width="1668" height="851" alt="Screenshot3" src="https://github.com/user-attachments/assets/28dd4db6-65fa-4f67-92f6-1c0294447da1" />
<img width="1658" height="846" alt="Screenshot4" src="https://github.com/user-attachments/assets/323104c5-42b4-4ce4-b83f-961264a61741" />


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
