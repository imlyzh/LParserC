module Program =
    [<EntryPoint>]
    let debug _ = 
        let r = LParserCUnitTest.TestClass ()
        r.TestUintParser ()
        r.TestIntParser ()
        r.TestRationalParser ()
        r.TestFloatParser ()
        r.TestCharParser ()
        r.TestStringParser ()
        0