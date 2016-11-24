
orderApp.config(function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: "/Checkout/Views/CustomerData",
        controller: "customer"
    }).when("/address", {
        templateUrl: "/Checkout/Views/AddressCustomer",
        controller: "address"
    });
});
