function deepCopy(obj) {
    if (Object.prototype.toString.call(obj) === '[object Array]') {
        var out = [];
        for (var i = 0; i < obj.length; i++) {
            out[i] = arguments.callee(obj[i]);
        }
        return out;
    }
    if (typeof obj === 'object') {
        var out = {};
        for (var i in obj) {
            out[i] = arguments.callee(obj[i]);
        }
        return out;
    }
    return obj;
}