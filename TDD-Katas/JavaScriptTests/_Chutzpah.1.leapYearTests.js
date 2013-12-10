test("2001 is a typical common year", function () {
    var year = 2001;
    var res = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, false, "no leapYear expected");
});

test("1996 is a typical leap year", function () {
    var year = 1996;
    var res = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, false, "leapYear expected");
});

test("2000 is an atypical leap year", function () {
    var year = 1900;
    var res = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, false, "no leapYear expected");
});

test("1900 is an atypical common year", function () {
    var year = 1900;
    var res = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, false, "no leapYear expected");
});
