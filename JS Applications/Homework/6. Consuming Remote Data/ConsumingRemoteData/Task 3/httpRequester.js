var httpRequester = (function () {
    var URL_RESOURSE = 'http://localhost:3000/students/';
    
    function ajaxRequest(url, type, data) {
        var deffered = Q.defer();
        
        if (data) {
            data = JSON.stringify(data);
        }

        $.ajax({
            url: url,
            type: type,
            data: data,
            contentType: 'application/json',
            success: function (responseData) {
                deffered.resolve(responseData);
            },
            error: function (error) {
                deffered.reject(error);
            }
        });

        return deffered.promise;
    }

    function getRequest() {
        return ajaxRequest(URL_RESOURSE, 'GET');
    }

    function postRequest(data) {
        return ajaxRequest(URL_RESOURSE, 'POST', data);
    }

    function deleteRequest(id) {
        return ajaxRequest(URL_RESOURSE + id, 'POST');
    }

    return {
        getRequest: getRequest,
        postRequest: postRequest,
        deleteRequest: deleteRequest
    }
}());