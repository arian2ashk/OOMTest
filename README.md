Connected to the issue [here](https://github.com/dotnet/runtime/issues/78959)

Running on .net 7.0.3 (7.0.201 SDK)

- install K6
- Run the solution
- Run `k6 run .\OOMTest\LoadTest.js`
- Watch memory usage going up constantly in task manager
