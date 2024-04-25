// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

open ClassLibrary1
open My



//let a =
//    my {
//        yield my {
        
//            yield my {
//               yield  my {
                
//                    yield my {
//                        yield 3s
//                        yield my {
//                            yield 1uy
//                            yield my {
//                                yield my {
//                                   yield 1
//                                   yield my {
//                                        yield my {
        
//                                            yield my {
//                                                yield my {
                
//                                                    yield my {
//                                                        yield 3s
//                                                        yield my {
//                                                            yield 1uy
//                                                            yield my {
//                                                                yield my {
//                                                                   yield 1
//                                                                }   
//                                                            }
//                                                        }   
//                                                    }
//                                                }   
//                                            }
//                                        }   
//                                    }
//                                }   
//                            }
//                        }   
//                    }
//                }   
//            }
//        }   
//    }
//printfn "%f" a

let a =
    my {
        my {
        
            my {
                my {
                
                    my {
                        3
                        my {
                            1
                            my {
                                my {
                                   1
                                   my {
                                        my {
        
                                            my {
                                                my {
                
                                                    my {
                                                        3
                                                        my {
                                                            1
                                                            my {
                                                                my {
                                                                   1
                                                                }   
                                                            }
                                                        }   
                                                    }
                                                }   
                                            }
                                        }   
                                    }
                                }   
                            }
                        }   
                    }
                }   
            }
        }   
    }
printfn "%f" a