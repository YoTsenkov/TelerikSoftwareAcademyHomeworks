var HttpRequester = (function () {

    var promiseAjaxRequest = function (url, type, data, headers) {
        var ajaxDeferred = Q.defer();

        if (data) {
            data = JSON.stringify(data);
        }

        $.ajax({
            url: url,
            type: type,
            data: data,
            headers: headers,
            contentType: "application/json",
            success: function (responseData) {
                ajaxDeferred.resolve(responseData);
            },
            error: function (errorData) {
                ajaxDeferred.reject(errorData);
            }
        });

        return ajaxDeferred.promise;
    };

    var promiseAjaxRequestGet = function (url) {
        return promiseAjaxRequest(url, "get");
    };

    var promiseAjaxRequestPost = function (url, data, headers) {
        return promiseAjaxRequest(url, "post", data, headers);
    };

    var promiseAjaxRequestPut = function (url, headers) {
        return promiseAjaxRequest(url, "put", {}, headers);
    };

    return {
        getJson: promiseAjaxRequestGet,

        postJson: promiseAjaxRequestPost,

        putJson: promiseAjaxRequestPut
    }
}());