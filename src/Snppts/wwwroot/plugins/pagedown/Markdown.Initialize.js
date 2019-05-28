(function () {
    var converter1 = Markdown.getSanitizingConverter();

    converter1.hooks.chain("preBlockGamut", function (text, rbg) {
        return text.replace(/^ {0,3}""" *\n((?:.*?\n)+?) {0,3}""" *$/gm, function (whole, inner) {
            return "<blockquote>" + rbg(inner) + "</blockquote>\n";
        });
    });

    var editor1 = new Markdown.Editor(converter1);

    editor1.run();

    var converter2 = new Markdown.Converter();

    converter2.hooks.chain("preConversion", function (text) {
        return text.replace(/\b(a\w*)/gi, "*$1*");
    });

    converter2.hooks.chain("plainLinkText", function (url) {
        return "This is a link to " + url.replace(/^https?:\/\//, "");
    });

    var help = function () { alert("Do you need help?"); }
    var options = {
        helpButton: { handler: help },
        strings: { quoteexample: "whatever you're quoting, put it right here" }
    };
    var editor2 = new Markdown.Editor(converter2, "-second", options);

    editor2.run();
})();