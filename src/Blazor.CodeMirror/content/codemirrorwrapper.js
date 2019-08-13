window.codemirror = {
    create: function (textArea, initialCode) {

        var cm = CodeMirror.fromTextArea(textArea, {
            value: initialCode,
            mode: {name: "javascript", json: true},
            lineNumbers: true
        })

        return new Promise(() => { });
    }
};
