namespace ClassLibrary1


type MyBuilder() =
    member x.Zero() : float = 
        0.0

    member x.Yield(a : int) =
        float a
    //member x.Yield(a : uint8) =
    //    float a
        
    //member x.Yield(a : int8) =
    //    float a

    //member x.Yield(a : uint16) =
    //    float a
        
    //member x.Yield(a : int16) =
    //    float a
        
    //member x.Yield(a : uint32) =
    //    float a
        
    //member x.Yield(a : int32) =
    //    float a
    //member x.Yield(a : uint64) =
    //    float a
    //member x.Yield(a : int64) =
    //    float a
    //member x.Yield(a : float) =
    //    float a
    //member x.Yield(a : float32) =
    //    float a
    //member x.Yield(a : decimal) =
    //    float a
    //member x.Yield(a : string) =
    //    float a
    //member x.Yield(a : seq<'a>) =
    //    float a
    //member x.Yield(a : list<'a>) =
    //    float a
    //member x.Yield(a : array<'a>) =
    //    float a
    //member x.Yield(a : option<'a>) =
    //    float a
    //member x.Yield(a : Async<'a>) =
    //    float a
    //member x.Yield(a : list<obj>) =
    //    float a
    member x.Delay(l : unit -> float) =
        l()
    member x.Run(l : float) = 
        l
    member x.Combine(l : float, r : float) = 
        l+r 

module My =
    
    let my = MyBuilder()

