define(['q', 'jquery'], function (Q, $) {
    var HttpRequester = (function () {
        function ajaxRequest(url, type, headers, data) {
            var deffered = Q.defer();

            if (data) {
                data = JSON.stringify(data);
            }

            $.ajax({
                url: url,
                type: type,
                contentType: 'application/json',
                data: data,
                headers: headers || {},
                success: function (responseData) {
                    deffered.resolve(responseData);
                },
                error: function (err) {
                    deffered.reject(err);
                }
            });

            return deffered.promise;
        }

        function getJSON(url, headers) {
            return ajaxRequest(url, 'GET', headers);
        }

        function postJSON(url, headers, data) {
            return ajaxRequest(url, 'POST', headers, data);
        }

        function putJSON(url, headers, data) {
            return ajaxRequest(url, 'PUT', headers, data);
        }

        return {
            getJSON: getJSON,
            postJSON: postJSON,
            putJSON: putJSON
        }
    }());

    return HttpRequester;
});