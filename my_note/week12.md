# 📝軟體工程與演算法第十二週筆記20211201
## 📖 避免C語言陷阱的方法
1. gcc 總是加上 -Wall
2. 使用有 lint 的編輯器
3. 溶入 Linux/POSIX 的環境寫 C 語言，然後善用外部函式庫
    * 例如 : 安裝 WSL 或 msys2
4. 用 valgrind 檢查記憶體漏洞
5. C 語言比較適合做系統程式，或者需要速度很快的程式
6. 要學好更專業的 C 語言，建議向 github 上的高品質程式碼學習
### 🔖 
#### 📍 
## 💻 程式實際操作
### 🔗 c/good/myassert1
![](pic/myassert1.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
#include <stdio.h>
#include <stdlib.h>
//#include <assert.h>

#define test(cond) \
  if (!(cond)) { \
     printf("Error: at FILE=%s LINE=%d\n", __FILE__, __LINE__); \
     exit(1);\
  }

int main() {
  int i=1, j=2;
  test(i==1);
  test(j==1);
}
  ```
</details>

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ gcc myassert1.c -o myassert1

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ ./myassert1
Error: at FILE=myassert1.c LINE=14
```

### 🔗 c/good/myassert2
![](pic/myassert2.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
#include <stdio.h>
#include <stdlib.h>
//#include <assert.h>

#define test(cond, ...) \
  if (!(cond)) { \
     printf("Error: at FILE=%s LINE=%d\n", __FILE__, __LINE__); \
     printf(__VA_ARGS__);\
     exit(1);\
  }

int main() {
  int i=1, j=2;
  test(i==1, "i=%d\n", i);
  test(j==1, "j=%d\n", j);
}
  ```
</details>

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ gcc myassert2.c -o myassert2

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ ./myassert2
Error: at FILE=myassert2.c LINE=15
j=2
```

### 🔗 c/good/myassert3
![](pic/myassert3.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
  ```
</details>

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ gcc myassert3.c -o myassert3

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ ./myassert3
Error: at FILE=myassert3.c LINE=16
  Check:j==1 but j==2

Error: at FILE=myassert3.c LINE=18
  Check:j==1 but j==2
```

### 🔗 c/good/myassert4
![](pic/myassert4.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
  ```
</details>

#### The result of execution
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ gcc myassert4.c -o myassert4

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/c/good (master)
$ ./myassert4
Error: at FILE=myassert4.c LINE=18
  Check:j==1 but j==2

Error: at FILE=myassert4.c LINE=20
  Check:j==1 but j==2

str=hello!
```

### 🔗 
![](pic/.JPG)
<details>
  <summary><b>Show code</b></summary>

  ```
  ```
</details>

#### The result of execution
```
```
## 📖 補充資料
* [C -- 避免陷阱，提高品質的方法 <陳鍾誠>](https://gitlab.com/ccc110/sp/-/blob/master/c/README.md)