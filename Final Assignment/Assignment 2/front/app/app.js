var app = angular.module("myApp", ["ngRoute"]);
var app_root = "https://localhost:44332/";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider

    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })

    .when("/product_Type", {
        templateUrl : "views/pages/product_Type.html",
        controller: 'product_Type'
    })

    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
