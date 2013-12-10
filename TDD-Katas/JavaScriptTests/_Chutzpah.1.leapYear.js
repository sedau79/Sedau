var leapYearCalc = (function () {
    function leapYearCalc() {
    }
    leapYearCalc.IsTruelyLeapYear = function (arg) {
        var divisbleBy4 = (arg % 4) == 0;
        var divisbleBy100 = (arg % 100) == 0;
        var divisbleBy400 = (arg % 400) == 0;
        var result = (divisbleBy4 || divisbleBy400) && !divisbleBy100;
        return result;
    };
    return leapYearCalc;
})();
