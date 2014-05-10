var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

var regex = new RegExp('<(.*?)>', 'g');

var extracted = html.replace(regex, '');

console.log(extracted);

