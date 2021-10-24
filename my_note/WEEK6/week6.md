# 📝軟體工程與演算法第六週筆記20211020
## 📖 亂數生成

### 🔖 蒙地卡羅法
### 🔖 亂數產生法
## 📖 馬可夫鏈
![](pic/Markovkate.png)
* 狀態空間中經過從一個狀態到另一個狀態的轉換的隨機過程，狀態轉移的機率固定，不會隨時間變化
* 


#### 📍 
## 💻 程式實際操作
### 🔗 alg/02-random/random/randomTest.js 
![](pic/)
<details>
  <summary><b>Show random function</b></summary>

  ```
const SEED_MAX = 9999997
var d = new Date();
var seed = d.getTime()%SEED_MAX; //371

export function random() {
    seed = (seed+37 ) % SEED_MAX
    var x = Math.sin(seed) * 93177
    return x - Math.floor(x);
}
  ```
</details>

* seed的曲線震盪嚴重，得到的數據很亂
* 疑問 : 亂數是均等分布嗎 ?

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/02-random/random (master)
$ deno run randomTest.js 
0.9854174966894789
0.9881908166717039 
0.3078704557265155 
0.8046740412319195 
0.08530648931628093
0.629051597599755  
0.192245967220515  
0.7560685200514854 
0.2937368352377234 
0.9060103630763479
```

### 🔗 alg/02-random/random/random2Test.js
![](pic/)
<details>
  <summary><b>Show random2 function</b></summary>

  ```
// 來源：https://stackoverflow.com/questions/521295/seeding-the-random-number-generator-in-javascript
var m_w = 123456789;
var m_z = 987654321;
var mask = 0xffffffff;

// Takes any integer
function seed(i) {
    m_w = i;
    m_z = 987654321;
}

// Returns number between 0 (inclusive) and 1.0 (exclusive),
// just like Math.random().
export function random()
{
    m_z = (36969 * (m_z & 65535) + (m_z >> 16)) & mask;
    m_w = (18000 * (m_w & 65535) + (m_w >> 16)) & mask;
    var result = ((m_z << 16) + m_w) & mask;
    result /= 4294967296;
    return result + 0.5;
}
  ```
</details>

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/02-random/random (master)
$ deno run random2Test.js
0.45231413352303207
0.7940094328951091
0.377391537418589
0.8408720137085766
0.19487653020769358
0.8352998823393136
0.8078417882788926
0.6857897664885968
0.2777199756819755
0.04474068386480212
```

### 🔗 alg/02-random/random/random3Test.js
![](pic/)
<details>
  <summary><b>Show code</b></summary>

  ```
const M = {}

M.seed = function(s) {
  return function() {
      s = Math.sin(s) * 10000;
      return s - Math.floor(s);
  };
};

// usage:
var random1 = M.seed(42);
var random2 = M.seed(random1());
M.random = M.seed(random2());

export default M;
  ```
</details>

* 兩層函式作法
#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/02-random/random (master)
$ deno run random3Test.js
0.23011085025609646
0.8670096341811586
0.7390208207862088
0.7399558389925005
0.07551365502513363
0.6879794036875637
0.7579290497783404
0.3737038815897904
0.46428991103312
0.9655514713977027
```

### 🔗 alg/03-monteCarlo/pi/monteCarloPi.js 
![](pic/)
<details>
  <summary><b>Show code</b></summary>

  ```
function monteCarloPi(n) {
  let hits = 0
  for (let i=0;i<n; i++) {
    let x = Math.random()
    let y = Math.random()
    if (x*x+y*y <= 1) hits++
  }
  return 4*(hits/n)
}
console.log('MonteCarloPi(1000000)=', monteCarloPi(1000000))
  ```
</details>

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/03-monteCarlo/pi (master)
$ deno run monteCarloPi.js 
MonteCarloPi(1000000)= 3.141968

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/03-monteCarlo/pi (master)
$ deno run monteCarloPi.js 
MonteCarloPi(1000000)= 3.14024
```

### 🔗 
![](pic/)
<details>
  <summary><b>Show code</b></summary>

  ```
  ```
</details>

#### The result of execution
```
```

### 🔗 
![](pic/)
<details>
  <summary><b>Show code</b></summary>

  ```
  ```
</details>

#### The result of execution
```
```


## 📖 補充資料