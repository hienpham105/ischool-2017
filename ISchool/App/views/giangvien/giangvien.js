var app = angular.module('giangvienModule', []);
app.controller('giangvienCtrl', function ($scope, $http, GiangViensService) {

    $scope.GiangViensData = null;
    // Fetching records from the factory created at the bottom of the script file
    GiangViensService.GetAllRecords().then(function (d) {
        $scope.GiangViensData = d.data; // Success
    }, function () {
        alert('Error Occured !!!'); // Failed
    });
    $scope.getGiangVienItemInput = {
        MAGV:'',
        HOGV:'',
        TENGV: '',
        QUEQUAN: '',
        DIACHI: '',
        NGAYSINH: '',
        SDT: '',
        CMND: '',
        GIOITINH: '',
        EMAIL: '',
        MAHV: '',
        MADV: '',
        MACV: '',
        TRANGTHAIGV: ''
    };

    // Reset product details
    $scope.clear = function () {
        $scope.getGiangVienItemInput.MAGV = "";
        $scope.getGiangVienItemInput.HOGV = "";
        $scope.getGiangVienItemInput.TENGV = "";
        $scope.getGiangVienItemInput.QUEQUAN = "";
        $scope.getGiangVienItemInput.DIACHI = "";
        $scope.getGiangVienItemInput.NGAYSINH = "";
        $scope.getGiangVienItemInput.SDT = "";
        $scope.getGiangVienItemInput.CMND = "";
        $scope.getGiangVienItemInput.GIOITINH = "";
        $scope.getGiangVienItemInput.EMAIL = "";
        $scope.getGiangVienItemInput.MAHV = "";
        $scope.getGiangVienItemInput.MADV = "";
        $scope.getGiangVienItemInput.MACV = "";
        $scope.getGiangVienItemInput.TRANGTHAIGV = "";
    }

    //Add New Item
    $scope.save = function () {
        if ($scope.getGiangVienItemInput.HOGV != "" && $scope.getGiangVienItemInput.TENGV != "" &&
            $scope.getGiangVienItemInput.QUEQUAN != "" && $scope.getGiangVienItemInput.DIACHI != "" &&
            $scope.getGiangVienItemInput.NGAYSINH != "" && $scope.getGiangVienItemInput.SDT != "" &&
            $scope.getGiangVienItemInput.CMND != "" && $scope.getGiangVienItemInput.GIOITINH != "" &&
            $scope.getGiangVienItemInput.EMAIL != "" && $scope.getGiangVienItemInput.MAHV != "" &&
            $scope.getGiangVienItemInput.MADV != "" && $scope.getGiangVienItemInput.MACV != "" &&
            $scope.getGiangVienItemInput.TRANGTHAIGV != "") {
            // or you can call Http request using $http
            $http({
                method: 'POST',
                url: 'api/iGiangvien/PostGiangvien/',
                data: $scope.getGiangVienItemInput
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                $scope.GiangviensData.push(response.data);
                $scope.clear();
                alert("Giang vien Added Successfully !!!");
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
                alert("Error : " + response.data.ExceptionMessage);
            });
        }
        else {
            alert('Please Enter All the Values !!');
        }
    };

    // Edit product details
    $scope.edit = function (data) {
        $scope.getGiangVienItemInput = {
            MAGV: data.MAGV, HOGV: data.HOGV, TENGV: data.TENGV,
            QUEQUAN: data.QUEQUAN, NGAYSINH: data.NGAYSINH, SDT: data.SDT,
            CMND: data.CMND, GIOITINH: data.GIOITINH, MAHV: data.MAHV,
            MADV: data.MADV, MACV: data.MACV, TRANGTHAIGV: data.TRANGTHAIGV
        }
    }
                              
    // Cancel product detailsDIACHI = "";
    $scope.cancel = function () {
        $scope.clear();       
    }                         
                              
    // Update product detailsEMAIL = "";
    $scope.update = function() {
        if ($scope.getGiangVienItemInput.HOGV != "" && $scope.getGiangVienItemInput.TENGV != "" &&
            $scope.getGiangVienItemInput.QUEQUAN != "" && $scope.getGiangVienItemInput.DIACHI != "" &&
            $scope.getGiangVienItemInput.NGAYSINH != "" && $scope.getGiangVienItemInput.SDT != "" &&
            $scope.getGiangVienItemInput.CMND != "" && $scope.getGiangVienItemInput.GIOITINH != "" &&
            $scope.getGiangVienItemInput.EMAIL != "" && $scope.getGiangVienItemInput.MAHV != "" &&
            $scope.getGiangVienItemInput.MADV != "" && $scope.getGiangVienItemInput.MACV != "" &&
            $scope.getGiangVienItemInput.TRANGTHAIGV != "") {
            $http({
                method: 'PUT',
                url: 'api/iGiangvien/PutGiangVien/' + $scope.getGiangVienItemInput.MAGV,
                data: $scope.getGiangVienItemInput
            }).then(function successCallback(response) {
                $scope.GiangViensData = response.data;
                $scope.clear();
                alert("Giang Vien Updated Successfully !!!");
            }, function errorCallback(response) {
                alert("Error : " + response.data.ExceptionMessage);
            });
        }
        else {
            alert('Please Enter All the Values !!');
        }
    };

    // Delete product details
    $scope.delete = function (index) {
        $http({
            method: 'DELETE',
            url: 'api/iGiangvien/DeleteGiangVien/' + $scope.GiangViensData[index].MAGV,
        }).then(function successCallback(response) {
            $scope.GiangViensData.splice(index, 1);
            alert("Product Deleted Successfully !!!");
        }, function errorCallback(response) {
            alert("Error : " + response.data.ExceptionMessage);
        });
    };

});

// Here I have created a factory which is a populer way to create and configure services. You may also create the factories in another script file which is best practice.
// You can also write above codes for POST,PUT,DELETE in this factory instead of controller, so that our controller will look clean and exhibits proper Separation of Concern.
app.factory('GiangviensService', function ($http) {
    var fac = {};
    fac.GetAllRecords = function () {
        return $http.get('api/iGiangvien/GetAllGiangViens');
    }
    return fac;
});