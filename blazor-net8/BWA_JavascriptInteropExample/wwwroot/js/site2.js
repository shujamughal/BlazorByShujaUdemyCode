function callDotNetStaticMethod() {
    var message =
 DotNet.invokeMethod('BWA_JavascriptInteropExample',
    'GetMessageFromDotNet');
    alert(message);
}






function callDotNetStaticNumberMethod(i) {
    var message = DotNet.invokeMethod('BWA_JavascriptInteropExample', 'ReturnNumberFromDotNet', i);
    document.getElementById('s1').innerHTML = message;
   // alert(message);
}

function callDotNetAsyncStaticMethod() {
    DotNet.invokeMethodAsync('BWA_JavascriptInteropExample', 'GetAsyncMessageFromDotNet')
        .then(message => {
            alert(message);
        });
}