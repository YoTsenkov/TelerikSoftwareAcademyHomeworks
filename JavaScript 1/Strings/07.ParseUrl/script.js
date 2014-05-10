function parseUrl(url) {
    var protocol = new String();
    var server = new String();
    var resource = new String();

    //extracting the protocol
    var protocolIndex = url.indexOf(':');
    protocol = url.slice(0, protocolIndex);

    //extracting the resource
    var slashCount = 0;
    var resourceIndex;
    for (var i = 0; i < url.length; i++) {
        if (url[i] === '/') {
            slashCount++;
            if (slashCount === 3) {
                resourceIndex = i;
                break;
            }
        }
    }
    resource = url.slice(resourceIndex, url.length);

    //extractiong the server
    server = url.slice(url.indexOf('www.'), resourceIndex);

    return {
        protocol: protocol,
        server: server,
        resource: resource
    };
}

var url = 'http://www.devbg.org/forum/index.php';
var obj = parseUrl(url);
console.log(obj.protocol);
console.log(obj.server);
console.log(obj.resource);