/// <reference path="code.ts"/>
/// <reference path="scripts\typings\qunit\qunit.d.ts"/>


test("will add 5 to number in ts", function () {

    var ml : mathLib = new mathLib();
    var res: number = ml.add5(10);

    equal(res, 15, "should add 5");
});