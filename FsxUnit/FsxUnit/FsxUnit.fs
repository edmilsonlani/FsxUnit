module FsxUnit
open NUnit.Framework
open NUnit.Framework.Constraints

let verifyExceptionsIn (objectToBeTested : obj) =
    match objectToBeTested with
    | :? (unit -> unit) -> box (new TestDelegate(objectToBeTested :?> unit -> unit))
    | _                 -> objectToBeTested

let should (generateConstraint : 'a -> #Constraint) (restriction : 'a) (objectToBeTested : obj) =
    let (constraintObj, result) = (generateConstraint restriction, verifyExceptionsIn objectToBeTested)
    Assert.That(result, constraintObj)

let should'nt (generateConstraint : 'a -> #Constraint) (restriction : 'a) (objectToBeTested : obj) =
    let (constraintObj, result) = (generateConstraint restriction, verifyExceptionsIn objectToBeTested)
    Assert.That(result, new NotConstraint(constraintObj))

let equal x =  EqualConstraint(x)

let not x = new NotConstraint(x)

let contain x = new ContainsConstraint(x)

let haveLength n = Has.Length.EqualTo(n)

let haveCount n = Has.Count.EqualTo(n)

let be = id

let have = id

let Null = new NullConstraint()

let Empty = new EmptyConstraint()

let EmptyString = new EmptyStringConstraint()

let NullOrEmptyString = new NullOrEmptyStringConstraint()

let True = new TrueConstraint()

let False = new FalseConstraint()

let sameAs x = new SameAsConstraint(x)

let throw = Throws.TypeOf

let NaN = new NaNConstraint()

let uniqueItems = new UniqueItemsConstraint()

let greaterThan x = new GreaterThanConstraint(x)

let greaterThanOrEqual x = new GreaterThanOrEqualConstraint(x)

let lessThan x = new LessThanConstraint(x)

let lessThanOrEqual x = new LessThanOrEqualConstraint(x)

let instanceOf x = new InstanceOfTypeConstraint(x)