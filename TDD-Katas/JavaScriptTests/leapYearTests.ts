/// <reference path="leapYear.ts"/>
/// <reference path="scripts\typings\qunit\qunit.d.ts"/>

//A leap year is defined as one that is divisible by 4, 
//but is not otherwise divisible by 100 unless it is also divisible by 400.
//For example, 2001 is a typical common year and 1996 is a typical leap year, 
//whereas 1900 is an atypical common year and 2000 is an atypical leap year. 

test("2001 is a typical common year", function () {

    var year: number = 2001;
    var res: boolean = leapYearCalc.IsTruelyLeapYear(year);
  
    equal(res, false, "no leapYear expected");
});

test("1996 is a typical leap year", function () {

    var year: number = 1996;
    var res: boolean = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, true, "leapYear expected");
});

test("2000 is an atypical leap year", function () {

    var year: number = 1900;
    var res: boolean = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, false, "no leapYear expected");
});

test("1900 is an atypical common year", function () {

    var year: number = 1900;
    var res: boolean = leapYearCalc.IsTruelyLeapYear(year);

    equal(res, false, "no leapYear expected");
});