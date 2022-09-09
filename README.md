# BFF.Mobile

BFF.Mobile is a BFF in a demo suite of apps. The suite includes BFF.Mobile, [OrderProcessing.Customer](https://github.com/Sara-Jade/OrderProcessing.Customer), [OrderProcessing.Product](https://github.com/Sara-Jade/OrderProcessing.Product), and [BFF.Web](https://github.com/Sara-Jade/BFF.Web).

<br>

## Getting Started

### You will need
- Visual Studio 2022. The [VS Community](https://visualstudio.microsoft.com/vs/community/) edition is free. This project was built with VS 2022, and I haven't tested it with older versions.
- .NET 6
- Postman or a web browser to demo

<br>

## Demoing
1. Start [OrderProcessing.Customer](https://github.com/Sara-Jade/OrderProcessing.Customer).
2. Verify that [OrderProcessing.Customer](https://github.com/Sara-Jade/OrderProcessing.Customer)'s `GET` `/api/Customer/GetAllCustomers` route returns data.
1. Keep [OrderProcessing.Customer](https://github.com/Sara-Jade/OrderProcessing.Customer) open as you switch to BFF.Mobile.
4. BFF.Mobile contains `MobileBFFController.cs` with a port number associated with [OrderProcessing.Customer](https://github.com/Sara-Jade/OrderProcessing.Customer). *You may need to update this port number the first time you start the BFF.*
1. BFF.Mobile utilizes Swagger. As such, use Visual Studio to start the project, and Swagger will open in your browser.
6. The first route should return data.
2. You may also use Postman or your web browser to demo, e.g., `http://localhost:<port number>/api/<controller name minus "controller">/<route>`

<br>

## Build
Use Visual Studio 2022 to build.

<br>

## Test
Use Swagger, Postman or your web browser for manual testing/demoing. As stated in Demoing, don't forget to update [BFF.Mobile](https://github.com/Sara-Jade/BFF.Mobile)'s port number the first time using it!

<br>

## Contribute

1. Currently, the only implemented route is `GET` `/api/MobileBFF/GetAllCustomers`. Other routes could be implemented.
2. Adding a frontend as a separate project would be useful.