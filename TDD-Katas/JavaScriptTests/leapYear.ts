class leapYearCalc {

    static IsLeapYear(arg: number) {

        var divisbleBy4 = (arg % 4) == 0;
        var divisbleBy100 : boolean= (arg % 100) == 0;
        var divisbleBy400: boolean = (arg % 400) == 0;
        var result = (divisbleBy4 || divisbleBy400) && !divisbleBy100;    
        return result;
    }

    
}

