# 📝 Max (Tradition Test)
### Tradition Test
* 先寫程式再寫測試

## 📍 Example
```js
import * as _ from '../src/max.js'

console.log("_.max([4, 2, 8, 6]) = ", _.max([4,2,8,6]));
// => 8
console.log("_.max([]) = ", _.max([]));
// => undefined
```

## 📍 Example Result
```js
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a/my homework/lodash/max/test (master)
$ deno run max_test.js
_.max([4, 2, 8, 6]) =  8
_.max([]) =  undefined
```

## 📍 Test Result
```js
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a/my homework/lodash/max/test (masteest (master)
$ deno test max_test.js
_.max([4, 2, 8, 6]) =  8
_.max([]) =  undefined
running 0 tests from file:///D:/VScode/WP/ccc/110a/sa110a/my%20homework/lodash/max/test/max_test.js        test/max_test.js

test result: ok. 0 passed; 0 failed; 0 ignored; 0 measured; 0 filtered out (24ms)  
```