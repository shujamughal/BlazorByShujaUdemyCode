window.GetNumber = function (i) {
    var result = DotNet.invokeMethod("JSInterDemo2", "ReturnArray", i);
    document.getElementById("s1").innerHTML = result;
    
}


window.GetSR = function (num) {
    var result = DotNet.invokeMethodAsync("JSInterDemo2", 'CalculateSquareRootAsync', parseInt(num));
    result.then(function (val) {
        document.getElementById("s1").innerHTML = val;
    });
}