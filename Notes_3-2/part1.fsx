// Problem
// Feature: applying a discount
// sceneraio eligble registered customers get 10% discount when they spend 100 or more
// Given the following registered customers
// | customer id | is eligible
// |John | true
// |Mary | true
// |Richard | false
// id, isEligible, isRegistered

type Customer = {
    id: string
    isEligible: bool
    isRegistered: bool
}

let calculateTotal (customer: Customer, cost: decimal): decimal =
    if customer.isEligible && cost >= 100M && customer.isRegistered then
        0.9M * cost
    else
        cost

[<EntryPoint>]
let main argv = 
    let john = {id="John"; isEligible=true; isRegistered=true}
    let mary = {id="John"; isEligible=true; isRegistered=true}
    let richard = {id="John"; isEligible=false; isRegistered=true}
    let sarah = {id="Sarah"; isEligible=false; isRegistered=false}

    let assertJohn: bool = calculateTotal (john, 100.0M) = 90.0M
    let assertMary: bool = calculateTotal (mary, 99.00M) = 99.0M
    let assertRichard: bool = calculateTotal (richard, 100.0M) = 100.0M
    let assertSarah: bool = calculateTotal (sarah, 100.0M) = 100.0M
    
    // Testing
    assert assertJohn
    assert assertMary
    assert assertRichard
    assert assertSarah
    0
