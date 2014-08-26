var Post = (function () {
    var serviceRootUrl = 'http://localhost:3000/';

    var create = function (title, body) {

        return HttpRequester.postJson(serviceRootUrl + 'post', {
            title: title,
            body: body
        }, {
            "X-SessionKey": localStorage['sessionKey']
        });
    };

    var getAll = function () {

        return HttpRequester.getJson(serviceRootUrl + "post");
    };



    return {
        create: create,
        getAll: getAll
    }
}());

