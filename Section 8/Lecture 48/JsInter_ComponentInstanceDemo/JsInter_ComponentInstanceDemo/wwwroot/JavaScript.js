function JSFunction(name) {
    var result = DotNet.invokeMethod('JsInter_ComponentInstanceDemo', 'FunctionCaller', name);
    alert(result);
}