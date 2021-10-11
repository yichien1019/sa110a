# 📝 Min (BDD)
### BDD : Behavior Driven Development  (先寫測試，再寫程式)
* BDD在寫測試前先寫測試規格書。這份測試規格會用更接近人類語意的自然語言來描述軟體功能和測試案例。而且這份規格不是單純的敘述文件，而是一份「可以被執行的規格」，也就是可以被轉成自動化測試

## 📍 Example
```js
import { assertEquals } from "https://deno.land/std@0.63.0/testing/asserts.ts";
import * as _ from "../src/min.js";

Deno.test("min",() => {
    assertEquals(_.min([4, 2, 8, 6]), 2)
    assertEquals(_.min([]), undefined)
})
```

## 📍 Feature 
```
Feature: 計算此陣列中最小的數值並回傳，如果此陣列為空則回傳未定義
        (Computes the minimum value of array. If array is empty , undefined is returned.)

  Scenario: _.min([4, 2, 8, 6])
    When 當使用者輸入一串數值並且是陣列時
    Then 會輸出此陣列中最小的數值

  Scenario: _.min([])
    When 當使用者未輸入任何數值時
    Then 會輸出未定義(undefined)
```

## 📍 Example Result
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a/my homework/lodash/min/example (master)
$ deno run ex.js 
_.min([4, 2, 8, 6]) =  2
_.min([]) =  undefined
```

## 📍 Test Result
```js
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a/my homework/lodash/min/test (master)
$ deno test min_test.js
running 1 test from file:///D:/VScode/WP/ccc/110a/sa110a/my%20homework/lodash/min/test/min_test.js
test min ... ok (14ms)

test result: ok. 1 passed; 0 failed; 0 ignored; 0 measured; 0 filtered out (42ms)
```