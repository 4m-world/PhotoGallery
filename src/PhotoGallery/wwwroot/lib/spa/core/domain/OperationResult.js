System.register([], function(exports_1) {
    var OperationResult;
    return {
        setters:[],
        execute: function() {
            OperationResult = (function () {
                function OperationResult(succeeded, message) {
                    this.Succeeded = succeeded;
                    this.Message = message;
                }
                return OperationResult;
            })();
            exports_1("OperationResult", OperationResult);
        }
    }
});
