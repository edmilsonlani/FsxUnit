namespace FsxUnit.Test
open NUnit.Framework
open FsxUnit

[<TestFixture>]
type ``Greater Than tests`` ()=
    // Collection   
    [<Test>] member test.
     ``Number 1 should be greater than 0`` ()=
        1 |> should be (greaterThan 0)

    [<Test>] member test.
     ``Number 0 should fail to be greater than 1`` ()=
        shouldFail(fun () -> 0 |> should be (greaterThan 1))

    [<Test>] member test.
     ``Number 0 should'nt be greater than 1`` ()=
        0 |> should'nt be (greaterThan 1)

    [<Test>] member test.
     ``Number 1 should fail to not be greater than 0`` ()=
        shouldFail(fun () -> 1 |> should'nt be (greaterThan 0))

    [<Test>] member test.
     ``Number 1 should'nt be greater than 1`` ()=
        1 |> should'nt be (greaterThan 1)
    
    [<Test>] member test.
     ``Number 1 should fail to be greater than 1`` ()=
        shouldFail(fun () -> 1 |> should be (greaterThan 1))
    

[<TestFixture>]
type ``Greater Than or Equal tests`` ()=
    // Collection   
    [<Test>] member test.
     ``Number 1 should be greater than 0`` ()=
        1 |> should be (greaterThanOrEqual 0)

    [<Test>] member test.
     ``Number 0 should fail to be greater than 1`` ()=
        shouldFail(fun () -> 0 |> should be (greaterThanOrEqual 1))

    [<Test>] member test.
     ``Number 0 should'nt be greater than 1`` ()=
        0 |> should'nt be (greaterThanOrEqual 1)

    [<Test>] member test.
     ``Number 1 should fail to not be greater than 0`` ()=
        shouldFail(fun () -> 1 |> should'nt be (greaterThanOrEqual 0))

    [<Test>] member test.
     ``Number 1 should be greater than 1`` ()=
        1 |> should be (greaterThanOrEqual 1)
    
    [<Test>] member test.
     ``Number 1 should fail to not be greater than 1`` ()=
        shouldFail(fun () -> 1 |> should'nt be (greaterThanOrEqual 1))
    