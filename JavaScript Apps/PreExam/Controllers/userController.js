var User = (function () {
    var serviceRootUrl = 'http://localhost:3000/';

    var register = function (username, password) {

        return HttpRequester.postJson(serviceRootUrl + 'user', {
            username: username,
            authCode: CryptoJS.SHA1(username + password).toString()
        });
    };

    var login = function (username, password) {

        return HttpRequester.postJson(serviceRootUrl + "auth", {
            username: username,
            authCode: CryptoJS.SHA1(username + password).toString()
        }).then(function (result) {
            localStorage['sessionKey'] = result.sessionKey;
            localStorage['username'] = result.username;
        });
    };

    var logout = function () {

        return HttpRequester.putJson(serviceRootUrl + 'user',
            {
                "X-SessionKey": localStorage['sessionKey']
            }).then(function () {
                localStorage.clear();
            });
    };

    return {
        register: register,
        login: login,
        logout: logout
    }
}());
