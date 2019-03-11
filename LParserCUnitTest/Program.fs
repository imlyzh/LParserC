module Program =
    [<EntryPoint>]
    let debug _ = 
        let r = LParserCUnitTest.TestClass ()
        r.TestUintParser ()
        r.TestIntParser ()
        r.TestFloatParser ()
        0