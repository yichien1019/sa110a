# 📝軟體工程與演算法第二週筆記20210922
## 📖 
### 🔖 
#### 📍 


## 💻 程式實際操作
### 🔗 sa/alg/01-tableLookup/fiboanacci/fiboanacci.js
![](pic/fibonacci.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
function fibonacci (n) {
  if (n < 0) throw Error('fibonacci:n < 0')
  if (n === 0) return 0
  if (n === 1) return 1
  return fibonacci(n - 1) + fibonacci(n - 2)
}

var startTime = Date.now()
const n = 50
console.log(`fibonacci(${n})=${fibonacci(n)}`)
var endTime = Date.now()
var milliSeconds = endTime - startTime
console.log(`time:${milliSeconds}ms`)
  ```
</details> 

* 嚴格相等(===)比較兩個值，而被比較的兩個值都不會轉換成其他型別。如果值是不同型別，就會被視為不相等。如果兩值型別相同但不是數字，若值相同，則為相等。

#### The result of execution ( 📍 Big-O(2^n))
* fiboanacci(40)是電腦可運算範圍極限，所以fiboanacci(50)會跑不動
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/01-tableLookup/fiboanacci (master)
$ deno run fibonacci.js                                                        
fibonacci(40)=102334155
time:1250ms

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/01-tableLookup/fiboanacci (master)
$ deno run fibonacci.js
```

### 🔗 sa/alg/01-tableLookup/fiboanacci/fibonacci_lookup.js
![](pic/fibonaccilookup.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
var fib = [0, 1]

function fibonacci (n) {
  if (n < 0) throw Error('fibonacci:n < 0')
  if (fib[n] != null) return fib[n]
  fib[n] = fibonacci(n - 1) + fibonacci(n - 2) 
  return fib[n]
}

var startTime = Date.now()
const n = 50 
console.log(`fibonacci(${n})=${fibonacci(n)}`)
var endTime = Date.now()
var milliSeconds = endTime - startTime
console.log(`time:${milliSeconds}ms`)
console.log('fib[]=', fib)
  ```
</details>

* 利用array紀錄，再用查找字典方式查詢，之接回傳數值，減少運算次數

#### The result of execution( 📍 Big-O(n))
* 加入了`fib[]`，將運算過的結果紀錄下來，可以增加運算的速度
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/01-tableLookup/fiboanacci (master)
$ deno run fibonacci_lookup.js 
fibonacci(50)=12586269025
time:0ms
fib[]= [
           0,          1,           1,          2,
           3,          5,           8,         13,
          21,         34,          55,         89,
         144,        233,         377,        610,
         987,       1597,        2584,       4181,
        6765,      10946,       17711,      28657,
       46368,      75025,      121393,     196418,
      317811,     514229,      832040,    1346269,
     2178309,    3524578,     5702887,    9227465,
    14930352,   24157817,    39088169,   63245986,
   102334155,  165580141,   267914296,  433494437,
   701408733, 1134903170,  1836311903, 2971215073,
  4807526976, 7778742049, 12586269025
]
```

### 🔗 sa/alg/01-tableLookup/fiboanacci/fibonacci_loop.js
![](pic/fibonacciloop.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
function fibonacci (n) {
  if (n===0) return 0
  if (n===1) return 1
  var fi2 = 0, fi1 = 1 // f(0)=0, f(1)=1
  for (var i=2; i<=n; i++) {
    var fi = fi1+fi2
    fi2 = fi1
    fi1 = fi
  }
  return fi
}

var startTime = Date.now()
const n = 100
console.log(`fibonacci(${n})=${fibonacci(n)}`)
var endTime = Date.now()
var milliSeconds = endTime - startTime
console.log(`time:${milliSeconds}ms`)
  ```
</details>

#### The result of execution( 📍 Big-O(n))
* 遞迴的執行速度最快
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/01-tableLookup/fiboanacci (master)
$ deno run fibonacci_loop.js
fibonacci(100)=354224848179262000000
time:1ms
```

### 🔗 
#### The result of execution
```
```

### 🔗 
#### The result of execution
```
```


## 📖 補充資料