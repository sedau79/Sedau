/// <reference path="code.js"/>
/// <reference path="scripts\typings\qunit\qunit.d.ts"/>

test("will add 5 to number", function () {
    var res = mathLib.add5(10);

    equal(res, 15, "should add 5");
});