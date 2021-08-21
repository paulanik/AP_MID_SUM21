app.controller("sellingHistory",function($scope,$http,ajax){
    ajax.get(app_root + "api/Product/All/SellHistory",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
